using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
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
            //Patient result = Session.Query<Patient>().OrderByDescending(t => t.ID).FirstOrDefault();


            account = new Account(Session);

            account.SubAccount = Session.FindObject<SubAccount>(new BinaryOperator("accountNumber", 10301));
        }

        string fullName;
        public string FullName
        {
            get => fullName;
            set => SetPropertyValue(nameof(FullName), ref fullName, value);
        }

        Blood bloodType;
        public Blood BloodType
        {
            get => bloodType;
            set => SetPropertyValue(nameof(BloodType), ref bloodType, value);
        }


        Relegions relegion;
        public Relegions Relegion
        {
            get => relegion;
            set => SetPropertyValue(nameof(Relegion), ref relegion, value);
        }
        public enum Relegions
        {
            مسلم, مسيحى, أخرى
        }


        string phonenumber1;
        public string PhoneNumber1
        {
            get => phonenumber1;
            set => SetPropertyValue(nameof(PhoneNumber1), ref phonenumber1, value);
        }






        string phonenumber2;
        public string PhoneNumber2
        {
            get => phonenumber2;
            set => SetPropertyValue(nameof(PhoneNumber2), ref phonenumber2, value);
        }

        string occubations;
        public string Occubation
        {
            get => occubations;
            set => SetPropertyValue(nameof(Occubation), ref occubations, value);
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

        [DevExpress.Xpo.Size(SizeAttribute.Unlimited), ValueConverter(typeof(ImageValueConverter)), Delayed, VisibleInListView(false)]
        public Image ImageProperty
        {
            get { return GetDelayedPropertyValue<Image>("ImageProperty"); }
            set { SetDelayedPropertyValue<Image>("ImageProperty", value); }
        }


        public enum Genders
        {
            male, female
        }

        Nationalitys nationality;
        public Nationalitys Nationality
        {
            get => nationality;
            set => SetPropertyValue(nameof(Nationality), ref nationality, value);
        }

        public enum Nationalitys
        {
            [Description("مصر")]
            مصر,
            [Display(Name = "الأردن")]
            الأردن,
            [Display(Name = "سوريا")]
            سوريا,
            [Display(Name = "السودان")]
            السودان,
            [Display(Name = "السعودية")]
            السعودية,
            [Display(Name = "ليبيا")]
            ليبيا,
            [Display(Name = "اليمن")]
            اليمن,
            [Display(Name = "الإمارات")]
            الإمارات,
            [Display(Name = "فلسطين")]
            فلسطين,
            [Display(Name = "الكويت")]
            الكويت,
            [Display(Name = "تونس")]
            تونس,
            [Display(Name = "أخرى")]
            أخرى,
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
            {
                account.accountName = FullName;
                object result = Session.Evaluate<Patient>(CriteriaOperator.Parse("Max(ID)"), null);
                if (result == null)
                {
                    int idNum = this.ID + 1;
                    //this.ID = idNum;
                    String s = idNum.ToString("D4");
                    MedicalID = DateTime.Now.Year.ToString() + s;
                }
                else
                {
                    int newID = Convert.ToInt32(result) + 1;
                    this.ID = newID;
                    String s = ID.ToString("D4");
                    MedicalID = DateTime.Now.Year.ToString() + s;
                }
            }
            if (phonenumber1.Length != 11)
                throw new ArgumentException("برجاء إدخال رقم هاتف صحيح!", nameof(phonenumber1));
            //{
            //    MessageBox.Show("برجاء إدخال رقم هاتف صحيح!.", "رقم الهاتف غير صحيح", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}


            if (nationalID.Length != 14)
            {
                MessageBox.Show("برجاء التأكد من الرقم القومى!", "برجاء التأكد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (ImageProperty == null)
            //{
            //    MessageBox.Show("برجاء التأكد من إدخال صورة البطاقة الشخصي!", "برجاء التأكد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            string[] authorsList = FullName.Split(' ');
            if (authorsList.Length < 4)
            {
                throw new ArgumentException("برجاء التأكد من إدخال الاسم الرباعي!", nameof(FullName));
                //MessageBox.Show("برجاء التأكد من إدخال الاسم الرباعي!", "برجاء التأكد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        protected override void OnSaved()
        {
            base.OnSaved();
        }

    }
}
