﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class Transfer : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string ffromSection;
        public string fromSection
        {
            get { return ffromSection; }
            set { SetPropertyValue<string>(nameof(fromSection), ref ffromSection, value); }
        }
        string fintoSection;
        public string intoSection
        {
            get { return fintoSection; }
            set { SetPropertyValue<string>(nameof(intoSection), ref fintoSection, value); }
        }
        string ffromRoom;
        public string fromRoom
        {
            get { return ffromRoom; }
            set { SetPropertyValue<string>(nameof(fromRoom), ref ffromRoom, value); }
        }
        string fintoRoom;
        public string intoRoom
        {
            get { return fintoRoom; }
            set { SetPropertyValue<string>(nameof(intoRoom), ref fintoRoom, value); }
        }
        string fstatement;
        public string statement
        {
            get { return fstatement; }
            set { SetPropertyValue<string>(nameof(statement), ref fstatement, value); }
        }
    }

}
