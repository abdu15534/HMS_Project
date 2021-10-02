using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]

    public partial class SupervisionDetails
    {
        public SupervisionDetails(Session session) : base(session) { }
        public override void AfterConstruction() 
        {
            base.AfterConstruction();
            date = DateTime.Now;
        }



        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsDeleted)
            {
                this.price = this.admission.roomSupervisionCost;
                this.admission.CalculateRoomServices();


                if (this.doctor == null)
                    this.Delete();
            }
        }

        

        protected override void OnDeleting()
        {
            base.OnDeleting();
            this.admission.MedicalSupervisionSum -= this.price;
            this.admission.CalculateRoomServices();
        }

        protected override void OnSaved()
        {
            base.OnSaved();

            if (!IsDeleted)
            {
                this.price = this.admission.roomSupervisionCost;
                this.admission.CalculateRoomServices();
            }

        }
    }

}
