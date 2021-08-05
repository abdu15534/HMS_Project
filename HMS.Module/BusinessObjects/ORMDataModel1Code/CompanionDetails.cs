using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    [DeferredDeletion(false)]
    public partial class CompanionDetails
    {

        public CompanionDetails(Session session) : base(session)
        {
        }
        public override void AfterConstruction() { base.AfterConstruction(); date = DateTime.Now.Date; }



        protected override void OnSaving()
        {
            base.OnSaving();
            if(this.Stay!= null)
            {
                if(this.Stay.Patient.Nationality != Patient.Nationalitys.مصر)
                {
                    price = 100 * Convert.ToDecimal(1.5);
                }
                else
                {
                    price = 100;
                }
            }
        }

    }

}