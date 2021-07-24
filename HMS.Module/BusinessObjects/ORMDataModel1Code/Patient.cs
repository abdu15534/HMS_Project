using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class Patient
    {
        public Patient(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            account = new Account(Session);

            account.SubAccount = Session.FindObject<SubAccount>(new BinaryOperator("accountNumber", 10301 ));
       }

        Blood bloodType;
        public Blood BloodType
        {
            get => bloodType;
            set => SetPropertyValue(nameof(BloodType), ref bloodType, value);
        }


        Genders gender;
        public Genders Gender
        {
            get => gender;
            set => SetPropertyValue(nameof(Gender), ref gender, value);
        }

        public enum Blood
        {
            [Description("Unknown")]
            NotSet,
            [Display(Name = "O+")]
            OPositive,
            [Display(Name = "A+")]
            APositive,
            [Display(Name = "B+")]
            BPositive,
            [Display(Name = "AB+")]
            ABPositive,
            [Display(Name = "AB-")]
            ABNegative,
            [Display(Name = "A-")]
            ANegative,
            [Display(Name = "B-")]
            BNegative,
            [Display(Name = "O-")]
            ONegative
        }

        public enum Genders
        {
            male, female
        }
/*
        private XPCollection<AuditDataItemPersistent> auditTrail;
        [CollectionOperationSet(AllowAdd = false, AllowRemove = false)]
        public XPCollection<AuditDataItemPersistent> AuditTrail
        {
            get
            {
                if (auditTrail == null)
                {
                    auditTrail = AuditedObjectWeakReference.GetAuditTrail(Session, this);
                }
                return auditTrail;
            }
        }
*/



        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.Session.IsNewObject(this))
                account.accountName = FullName;
        }

        protected override void OnSaved()
        { 
            base.OnSaved();
        }

    }
}
