using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class MyFilterController : ViewController
    {
        //public ParametrizedAction dateFilterAction;
        //public MyFilterController()
        //{
        //    TargetViewType = ViewType.ListView;
        //    TargetObjectType = typeof(Stay);
        //    dateFilterAction = new ParametrizedAction(this, "MyDateFilter", PredefinedCategory.Search, typeof(DateTime));
        //    dateFilterAction.NullValuePrompt = "Enter date";
        //    dateFilterAction.Execute += dateFilterAction_Execute;
        //}
        //private void dateFilterAction_Execute(object sender, ParametrizedActionExecuteEventArgs e)
        //{
        //    CriteriaOperator criterion = null;
        //    if (e.ParameterCurrentValue != null && e.ParameterCurrentValue.ToString() != string.Empty)
        //    {
        //        criterion = new BinaryOperator("StayStart", Convert.ToDateTime(e.ParameterCurrentValue));
        //    }
        //    ((ListView)View).CollectionSource.Criteria[dateFilterAction.Id] = criterion;
        //}
    }
}
