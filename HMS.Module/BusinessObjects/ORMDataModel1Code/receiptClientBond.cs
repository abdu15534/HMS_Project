using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using System.Linq;
using System.Windows.Forms;
using DevExpress.ExpressApp;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class receiptClientBond
    {
        public receiptClientBond(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            date = DateTime.Now;
            journal = new JournalEntry(Session);
            journal.date = DateTime.Now;
        }
        public enum PaymentType { General = 0, Admission = 1, Emergency = 2, Appointment = 3}

        PaymentType paymentType;

        public PaymentType PaymentDestnation
        {
            get => paymentType;
            set => SetPropertyValue(nameof(PaymentDestnation), ref paymentType, value);
        }

        public enum BondTypes { receiptClient, paymentSupplier, receiptManagement, paymentManagement }

        //XPCollection collection = new XPCollection(typeof(Admission));
        //XPCollection xpcUsers = new XPCollection(Session, typeof(eFlowUser), CriteriaOperator.Parse(criteria));
        //public XPCollection<Admission> admissions = 
        //Query<Admission>().Where(o => o.servicesSum > 0);
        

        

        protected override void OnSaving()
        {
            var user = SecuritySystem.CurrentUser.ToString();
            base.OnSaving();
            if (this.Session.IsNewObject(this))
            {
                user = SecuritySystem.CurrentUser.ToString();

                this.CreatedBy = user;
            }

            this.UpdatedBy = user;

            journal.type = this.GetType().ToString();
            journal.objectKey = this.id.ToString();
            


            if(fromAccount != null && intoAccount != null)
            {
                fromAccountBalance = fromAccount.credit - fromAccount.debit;
                intoAccountBalance = intoAccount.credit - intoAccount.debit;
            }

        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            if (post)
            {
                OrderConfirm(false);
            }
            this.journal.Delete();
            
        }


        public void OrderConfirm(bool add)
        {
            
            if (add)
            {
                

                

                Payments clientPayments = new Payments(Session);
                Patient patient = Session.Query<Patient>().Where(o => o.account == fromAccount).Single();
                if(PaymentDestnation == (PaymentType)0)
                {
                    clientPayments.ReceptionDesk = null;
                    clientPayments.Emergency = null;
                    clientPayments.Appointment = null;
                }
                else if (PaymentDestnation == (PaymentType)1)
                {
                    try
                    {
                        ReceptionDesk entry = Session.Query<ReceptionDesk>().Where(o => o.patient == patient && o.isDischarged == false).ToList()[0];
                        clientPayments.ReceptionDesk = entry;
                        clientPayments.Emergency = null;
                        clientPayments.Appointment = null;
                    }
                    catch
                    {
                        MessageBox.Show("لا توجد اقامة حالية لهذا العميل", "خطاء ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (PaymentDestnation == (PaymentType)2)
                {
                    try
                    {
                        Emergency emergency = Session.Query<Emergency>().Where(o => o.Patient == patient).OrderByDescending(t => t.date).ToList()[0];
                        clientPayments.Emergency = emergency;
                        clientPayments.ReceptionDesk = null;
                        clientPayments.Appointment = null;
                    }
                    catch
                    {
                        MessageBox.Show("لا يوجد اي ملف طوارئ لهذا العميل", "خطاء ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (PaymentDestnation == (PaymentType)3)
                {
                    try
                    {
                        Appointment appointment = Session.Query<Appointment>().Where(o => o.Patient == patient).OrderByDescending(t => t.StartOn).ToList()[0];
                        clientPayments.Appointment = appointment;
                        clientPayments.ReceptionDesk = null;
                        clientPayments.Emergency = null;
                    }
                    catch
                    {
                        MessageBox.Show("لا توجد اي حجوزات لهذا العميل", "خطاء ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                journal.DeleteDetails();

                this.statement = $"سند قبض رقم: {this.id} دفعة من حساب السادة / {fromAccount.accountName} يودع في حساب حساب {intoAccount.accountName}";

                var acc1 = new JournalDetails(Session);
                acc1.account = fromAccount;
                acc1.credit = amount;
                acc1.statement = this.statement;
                acc1.journal = this.journal;

                var acc2 = new JournalDetails(Session);
                acc2.account = intoAccount;
                acc2.debit = amount;
                acc2.statement = this.statement;
                acc2.journal = this.journal;

                clientPayments.Patient = patient;
                clientPayments.amount = this.amount;
                clientPayments.date = DateTime.Now;
                clientPayments.journalEntry = this.journal;
                journal.Post(false);
                post = true;


            }



            else
            {
                try
                {
                    Payments payment = Session.Query<Payments>().Where(o => o.journalEntry == journal).Single();
                    payment.Delete();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                
                journal.Post(true);
                post = false;
            }

            journal.statement = this.statement;
        }
    }

}
