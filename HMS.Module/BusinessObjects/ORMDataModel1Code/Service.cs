using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2

{


    [DefaultProperty("ID")]
    public partial class Service
    {
        public Service(Session session) : base(session)
        {
        }

        public override void AfterConstruction() { base.AfterConstruction(); }
        public enum ServiceTypes
        {
            لم_يحدد = 0, الطوارئ = 1, القلب = 2, الجهاز_الهضمى_و_المناظير = 3, النساء_والولادة = 4, الصدر = 5, الجلدية = 6, المسالك_البولية = 7, الانف_والأذن_والسمعيات = 8, المخ_والأعصاب = 9, الرمد = 10, التخدير = 11, الجراحة = 12, العظام = 13, العلاج_الطبيعى = 14, الأسنان = 15, الأشعة = 16, تحاليل = 17, Other = 18, Blood = 19, Surgeries = 20
        }

        ServiceTypes serviceType;

        public ServiceTypes ServiceType
        {
            get => serviceType;
            set => SetPropertyValue(nameof(ServiceType), ref serviceType, value);
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.Session.IsNewObject(this))
            {
                int lastservice = Session.Query<Service>().Where(o => this.ServiceType == o.ServiceType).Max(t => t.ID);
                object val = Convert.ChangeType(this.serviceType, this.serviceType.GetTypeCode());
                int Id = Convert.ToInt32(val);
                //this.ID = ProccessServiceID(Id, lastservice);
            }
        }
        //public int ProccessServiceID(int depID, int maxID)
        //{
        //    string strDepID = depID.ToString();
        //    string strMaxID = maxID.ToString();
        //    strMaxID = strMaxID.Substring(strDepID.Length);
        //    var result = Convert.ToInt32(strMaxID) + 1;
        //    strMaxID = result.ToString("D3");
        //    result = Convert.ToInt32(strDepID + strMaxID);
        //    return result;
        //}
    }
    public enum ServiceTypes
    {
        لم_يحدد = 0, الطوارئ = 1, القلب = 2, الجهاز_الهضمى_و_المناظير = 3, النساء_والولادة = 4, الصدر = 5, الجلدية = 6, المسالك_البولية = 7, الانف_والأذن_والسمعيات = 8, المخ_والأعصاب = 9, الرمد = 10, التخدير = 11, الجراحة = 12, العظام = 13, العلاج_الطبيعى = 14, الأسنان = 15, الأشعة = 16, تحاليل = 17, Other = 18, Blood = 19
    }


}

