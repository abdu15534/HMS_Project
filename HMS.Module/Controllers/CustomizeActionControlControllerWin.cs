using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;

namespace HMS.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class CustomizeActionControlControllerWin : Controller
    {
    //    protected override void OnActivated()
    //    {
    //        base.OnActivated();
    //        Frame.GetController<MyFilterController>().dateFilterAction.CustomizeControl += CustomizeActionControlControllerWin_CustomizeControl;
    //    }
    //    private void CustomizeActionControlControllerWin_CustomizeControl(object sender,
    //CustomizeControlEventArgs e)
    //    {
    //        BarEditItem barItem = e.Control as BarEditItem;
    //        if (barItem != null)
    //        {
    //            RepositoryItemDateEdit repositoryItem = (RepositoryItemDateEdit)barItem.Edit;
    //            repositoryItem.Mask.UseMaskAsDisplayFormat = true;
    //            repositoryItem.Mask.EditMask = "yyyy-MMM-dd";
    //            barItem.Width = 270;
    //        }
    //    }
    //    protected override void OnDeactivated()
    //    {
    //        Frame.GetController<MyFilterController>().dateFilterAction.CustomizeControl -=
    //CustomizeActionControlControllerWin_CustomizeControl;
    //        base.OnDeactivated();
    //    }
    }
}
