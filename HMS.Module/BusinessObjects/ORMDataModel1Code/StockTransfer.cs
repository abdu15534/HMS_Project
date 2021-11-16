using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Drawing;
using DevExpress.Persistent.Base;

namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class StockTransfer
    {
        public StockTransfer(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); this.Date = DateTime.Now; }

        [DevExpress.Xpo.Size(SizeAttribute.Unlimited), ValueConverter(typeof(ImageValueConverter)), Delayed, VisibleInListView(false), ImmediatePostData]
        public Image ReportScan
        {
            get { return GetDelayedPropertyValue<Image>("ReportScan"); }
            set { SetDelayedPropertyValue<Image>("ReportScan", value); }
        }
    }

}
