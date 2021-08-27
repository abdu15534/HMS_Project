using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2

{


    [DefaultProperty("ID")]
    public partial class Service
    {
        public Service(Session session) : base(session) { 
        }

        public override void AfterConstruction() { base.AfterConstruction(); }
        public enum ServiceTypes
        {
            لم_يحدد = 0, الطوارئ = 1, القلب = 2, الجهاز_الهضمى_و_المناظير = 3, النساء_والولادة = 4, الصدر = 5, الجلدية = 6, المسالك_البولية = 7, الانف_والأذن_والسمعيات = 8, المخ_والأعصاب = 9, الرمد = 10, التخدير = 11, الجراحة = 12, العظام = 13, العلاج_الطبيعى = 14, الأسنان = 15, الأشعة = 16, تحاليل = 17, Other = 18, Blood = 19
        }

        ServiceTypes serviceType;

        public ServiceTypes ServiceType
        {
            get => serviceType;
            set => SetPropertyValue(nameof(ServiceType), ref serviceType, value);
        }

        protected override void OnSaving()
        {
            //Session.Query<Service>().Where(o => o.serviceType == this.serviceType && (o.puchasingOrder.isConfirmed == true || o.puchasingOrder == this)).Sum(p => p.price * Convert.ToDecimal(p.quantity));



            //if (this.serviceType != ServiceTypes.لم_يحدد)
            //{
            //    //Session.Query<Service>().Where(o => o.serviceType == this.serviceType && (o.ID.("Max(ID)") == true);
                
            //    //if (this.serviceType == ServiceType)
            //    //{
            //        if (this.Session.IsNewObject(this))
            //        {
            //        var NewID = Session.Query<Service>().Where(o => (ServiceTypes)o.serviceType == (ServiceTypes)this.serviceType).Max(p => p.ID);
            //        if (NewID == null || NewID == 0)
            //            {
            //                int idNum = this.ID + 1;
            //                //this.ID = idNum;
            //                //String s = idNum.ToString("D4");
            //                //ID = DateTime.Now.Year.ToString() + s;
            //            }
            //            //else
            //            //{
            //            //    int newID = Convert.ToInt32(result) + 1;
            //            //    this.ID = newID;
            //            //    //String s = ID.ToString("D4");
            //            //    //ID = DateTime.Now.Year.ToString() + s;
            //            //}

            //        }
            //    //}


                //List<int> IDs = new List<int>();

                //{
                //    IDs.Add(ID);
                //}
                //int[] IDsList = IDs.ToArray();

                //if (ServiceType == this.serviceType)
                //{
                //    ID = IDsList.Max() + 1;
                //}

            //}


            base.OnSaving();
        }


    }


}
