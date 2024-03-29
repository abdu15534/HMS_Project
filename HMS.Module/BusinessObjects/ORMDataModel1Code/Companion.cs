﻿using DevExpress.ExpressApp;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    public partial class Companion
    {
        public Companion(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        Relatives relative;
        public Relatives Relative
        {
            get => relative;
            set => SetPropertyValue(nameof(Relative), ref relative, value);
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


        public enum Relatives
        {
            [Display(Name = "والد / والدة")]
            Parent,
            [Display(Name = "أخ / أخت")]
            Sibling,
            [Display(Name = "زوج / زوجة")]
            Spouse,
            [Display(Name = "إبن / إبنة")]
            Child,
            [Display(Name = "أخرى")]
            Other
        }

    }

}
