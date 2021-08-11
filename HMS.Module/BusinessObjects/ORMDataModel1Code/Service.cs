using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultProperty("ID")]
    public partial class Service
    {
        public Service(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        ServiceTypes serviceType;

        public ServiceTypes ServiceType
        {
            get => serviceType;
            set => SetPropertyValue(nameof(ServiceType), ref serviceType, value);
        }


    }
    public enum ServiceTypes
    {
         لم_يحدد = 0, الطوارئ = 1, القلب = 2,الجهاز_الهضمى_و_المناظير = 3, النساء_والولادة = 4, الصدر = 5, الجلدية = 6, المسالك_البولية = 7, الانف_والأذن_والسمعيات = 8, المخ_والأعصاب = 9, الرمد = 10, التخدير = 11, الجراحة = 12, العظام = 13, العلاج_الطبيعى = 14, الأسنان = 15, الأشعة = 16, تحاليل = 17
    }

}
