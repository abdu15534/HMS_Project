using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.Linq;
using System.Windows.Forms;
using DevExpress.ExpressApp;
using System.Collections.Generic;
using DevExpress.Data.Filtering;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class receiptClientBond
    {
        string stringQueryComplement = "')";
        string intQueryComplement = ")";
        string xrayQuery = "SELECT  dbo.Xrays.id, dbo.Xrays.Patient, dbo.Patient.FullName, dbo.Service.Name, dbo.XraysDetails.price FROM dbo.Xrays INNER JOIN dbo.XraysDetails ON dbo.Xrays.id = dbo.XraysDetails.Xrays INNER JOIN dbo.Service ON dbo.XraysDetails.service = dbo.Service.ID INNER JOIN dbo.Patient ON dbo.Xrays.Patient = dbo.Patient.ID WHERE        (dbo.Xrays.id = ";
        string appointmentsQuery = "SELECT        TOP (100) PERCENT dbo.ClinicServiceDetail.Appointment, dbo.Appointment.Patient, dbo.Patient.FullName, dbo.Service.Name, dbo.Service.Price FROM dbo.Appointment INNER JOIN dbo.ClinicServiceDetail ON dbo.Appointment.Oid = dbo.ClinicServiceDetail.Appointment INNER JOIN dbo.Patient ON dbo.Appointment.Patient = dbo.Patient.ID INNER JOIN dbo.Service ON dbo.ClinicServiceDetail.ClinicService = dbo.Service.ID WHERE(dbo.Appointment.Oid  = '";
        string testQuery = "SELECT        dbo.Test.id, dbo.Test.Patient, dbo.Patient.FullName, dbo.Service.Name, dbo.TestDetails.price FROM dbo.Patient INNER JOIN dbo.Test ON dbo.Patient.ID = dbo.Test.Patient INNER JOIN dbo.TestDetails ON dbo.Test.id = dbo.TestDetails.Test INNER JOIN dbo.Service ON dbo.TestDetails.service = dbo.Service.ID WHERE        (dbo.Test.id = ";
        string endoQuery = "SELECT  dbo.Endscope.id, dbo.Endscope.Patient, dbo.Patient.FullName, dbo.Service.Name, dbo.EndscopeDetails.price FROM dbo.EndscopeDetails INNER JOIN dbo.Endscope ON dbo.EndscopeDetails.Endscope = dbo.Endscope.id INNER JOIN dbo.Patient ON dbo.Endscope.Patient = dbo.Patient.ID INNER JOIN dbo.Service ON dbo.EndscopeDetails.service = dbo.Service.ID WHERE        (dbo.Endscope.id = ";
        public receiptClientBond(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            date = DateTime.Now;
            journal = new JournalEntry(Session);
            journal.date = DateTime.Now;
        }
        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(Department) && newValue != null && fromAccount != null)
            {
                Session.Delete(ReceiptItems);
                this.amount = 0;
                if (Department.ID == 8)
                {
                    string fullQuery = GetTargetAppointment();
                    addServices(fullQuery);
                }
                else if (Department.ID == 9)
                {
                    try
                    {
                        Xrays xray = Session.Query<Xrays>().Where(p => p.Patient.account == fromAccount).First();
                        amount = xray.total;
                        Targetid = xray.id.ToString();
                        string fullXrayQuery = xrayQuery + Targetid + intQueryComplement;
                        addServices(fullXrayQuery);

                    }
                    catch
                    {
                    }
                }
                else if (Department.ID == 10)
                {
                    try
                    {
                        Test test = Session.Query<Test>().Where(p => p.Patient.account == fromAccount).First();
                        amount = test.total;
                        Targetid = test.id.ToString();
                        string fullTestQuery = testQuery + Targetid + intQueryComplement;
                        addServices(fullTestQuery);

                    }
                    catch
                    {
                    }
                }
                else if (Department.ID == 11)
                {
                    try
                    {
                        Endscope endo = Session.Query<Endscope>().Where(p => p.Patient.account == fromAccount).First();
                        amount = endo.total;
                        Targetid = endo.id.ToString();
                        string fullEndoQuery = endoQuery + Targetid + intQueryComplement;
                        addServices(fullEndoQuery);

                    }
                    catch
                    {
                    }
                }
            }
            else if (propertyName == nameof(fromAccount) && newValue != null && Department != null)
            {
                Session.Delete(ReceiptItems);
                this.amount = 0;
                if (Department.ID == 8)
                {
                    string fullQuery = GetTargetAppointment();
                    addServices(fullQuery);
                }
                else if (Department.ID == 9)
                {
                    try
                    {
                        Xrays xray = Session.Query<Xrays>().Where(p => p.Patient.account == fromAccount).First();
                        amount = xray.total;
                        Targetid = xray.id.ToString();
                        string fullXrayQuery = xrayQuery + Targetid + intQueryComplement;
                        addServices(fullXrayQuery);

                    }
                    catch
                    {
                    }
                }
                else if (Department.ID == 10)
                {
                    try
                    {
                        Test test = Session.Query<Test>().Where(p => p.Patient.account == fromAccount).First();
                        amount = test.total;
                        Targetid = test.id.ToString();
                        string fullTestQuery = testQuery + Targetid + intQueryComplement;
                        addServices(fullTestQuery);

                    }
                    catch
                    {
                    }
                }
                else if (Department.ID == 11)
                {
                    try
                    {
                        Endscope endo = Session.Query<Endscope>().Where(p => p.Patient.account == fromAccount).First();
                        amount = endo.total;
                        Targetid = endo.id.ToString();
                        string fullEndoQuery = endoQuery + Targetid + intQueryComplement;
                        addServices(fullEndoQuery);

                    }
                    catch
                    {
                    }
                }
            }
        }

        private  string GetTargetAppointment()
        {
            string fullQuery = null;
            try
            {
                Appointment appo = Session.Query<Appointment>().Where(a => a.Patient.account == fromAccount).OrderByDescending(p => p.StartOn).First();
                Targetid = appo.Oid.ToString();
                fullQuery = appointmentsQuery + Targetid + stringQueryComplement;
                ReceiptItem reciptItem1 = new ReceiptItem(Session);
                reciptItem1.Name = appo.Apttype + " " + appo.clinc.Name + " دكتور " + appo.Doctor.FullName;
                reciptItem1.Price = appo.ExaminationPrice;
                reciptItem1.Date = DateTime.Now;
                reciptItem1.reciptBond = this;
                amount = appo.total;
                return fullQuery;

            }
            catch
            {
                return fullQuery;
            }
        }

        ////IList<XPBaseObject> admat;

        //public List<object> Admat
        //{
        //    get {
        //        //Type objType = Department.type;
        //        string query = "SELECT        TOP (100) PERCENT dbo.ClinicServiceDetail.Appointment, dbo.Appointment.Patient, dbo.Patient.FullName, dbo.Service.Name, dbo.Service.Price FROM dbo.Appointment INNER JOIN dbo.ClinicServiceDetail ON dbo.Appointment.Oid = dbo.ClinicServiceDetail.Appointment INNER JOIN dbo.Patient ON dbo.Appointment.Patient = dbo.Patient.ID INNER JOIN dbo.Service ON dbo.ClinicServiceDetail.ClinicService = dbo.Service.ID WHERE(dbo.Patient.FullName = N'" + fromAccount.accountName +"')";
        //        DevExpress.Xpo.DB.SelectedData x2 = Session.ExecuteQuery(query);
        //        DevExpress.Xpo.DB.SelectStatementResultRow[] x3 = x2.ResultSet[0].Rows;
        //        List<object> x5 = new List<object>();
        //        foreach (var item in x3)
        //        {
        //            var listItem = new List<object>();
        //            var t = item.GetType().GetProperties();
        //            Console.WriteLine(t);
        //            listItem.Add(item.Values.GetValue(4));
        //            listItem.Add(item.Values.GetValue(0));
        //            x5.Add(listItem);
        //        }
        //        //if (this.Department.ID == 6)
        //        //{
        //        //object obj = Session.FindObject(typeof(ClinicServiceDetail), CriteriaOperator.Parse("Contains([Subject], ?)", paramValue));
        //        //var x = Session.Query<ClinicServiceDetail>().Where(p => p.Appointment.Patient.FullName == fromAccount.accountName).ToList();
        //        //    IList<object> y = (IList<object>)x;
        //            return x5;
        //        //}
        //        //return null;            
        //    }
        //    //set => SetPropertyValue(nameof(Admat), ref admat, value);
        //}
        public enum PaymentType { General = 0, Admission = 1, Emergency = 2}

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

        public void addServices(string query)
        {
            DevExpress.Xpo.DB.SelectedData services = Session.ExecuteQuery(query);
            DevExpress.Xpo.DB.SelectStatementResultRow[] resultRows = services.ResultSet[0].Rows;
            List<object> x5 = new List<object>();
            foreach (var item in resultRows)
            {
                ReceiptItem reciptItem = new ReceiptItem(Session);
                reciptItem.Name = item.Values.GetValue(3).ToString();
                reciptItem.Price = Convert.ToDecimal(item.Values.GetValue(4));
                reciptItem.Date = DateTime.Now;
                reciptItem.reciptBond = this;
                x5.Add(item.Values.GetValue(3));
            }
        }

        public void OrderConfirm(bool add)
        {
            
            if (add)
            {
                

                

                Payments clientPayments = new Payments(Session);
                Patient patient = Session.Query<Patient>().Where(o => o.account == fromAccount).Single();
                //if(PaymentDestnation == (PaymentType)0)
                //{
                //    clientPayments.ReceptionDesk = null;
                //    clientPayments.Emergency = null;
                //    clientPayments.Appointment = null;
                //}
                //else 
                if (PaymentDestnation == (PaymentType)1)
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
                else if (Department.ID == 8)
                {
                    try
                    {
                        Appointment appointment = Session.Query<Appointment>().Where(o => o.Patient == patient).OrderByDescending(t => t.StartOn).ToList()[0];
                        appointment.AptStatus = Appointment.AppointmentStatus.Paid;
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
                else if (Department.ID == 9 )
                {
                    try
                    {
                        Xrays xray = Session.GetObjectByKey<Xrays>(Convert.ToInt32(Targetid));
                        xray.Paid = true;

                    }
                    catch
                    {
                        MessageBox.Show("لا توجد اي اشعة لهذا العميل", "خطاء ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }else if(Department.ID == 10)
                {
                    try
                    {
                        Test test = Session.GetObjectByKey<Test>(Convert.ToInt32(Targetid));
                        test.Paid = true;

                    }
                    catch
                    {
                        MessageBox.Show("لا توجد اي تحاليل لهذا العميل", "خطاء ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }
                else if (Department.ID == 11)
                {
                    try
                    {
                        Endscope endo = Session.GetObjectByKey<Endscope>(Convert.ToInt32(Targetid));
                        endo.Paid = true;

                    }
                    catch
                    {
                        MessageBox.Show("لا توجد اي مناظير لهذا العميل", "خطاء ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (Department.ID == 9)
                    {
                        Xrays xray = Session.GetObjectByKey<Xrays>(Convert.ToInt32(Targetid));
                        xray.Paid = false;
                    }
                    else if (Department.ID == 10)
                    {
                        Test test = Session.GetObjectByKey<Test>(Convert.ToInt32(Targetid));
                        test.Paid = false;
                    }
                    else if (Department.ID == 11)
                    {
                        Endscope endo = Session.GetObjectByKey<Endscope>(Convert.ToInt32(Targetid));
                        endo.Paid = false;
                    }
                    else if (Department.ID == 8)
                    {
                        Appointment appointment = Session.GetObjectByKey<Appointment>(Targetid); ;
                        appointment.AptStatus = Appointment.AppointmentStatus.NotSet;
                    }
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
