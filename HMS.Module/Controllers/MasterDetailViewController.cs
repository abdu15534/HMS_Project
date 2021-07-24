using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace HMS.Module.Controllers
{
    public partial class MasterDetailViewController : ViewController<ListView>
    {
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
        //    GridListEditor gridListEditor = View.Editor as GridListEditor;
        //    if (gridListEditor != null)
        //    {
        //        GridControl grid = gridListEditor.Grid;
        //        GridView view = gridListEditor.GridView;
        //        view.OptionsPrint.PrintDetails = true;
        //        view.OptionsDetail.ShowDetailTabs = true;
        //        view.OptionsView.ShowDetailButtons = true;
        //        view.OptionsDetail.EnableMasterViewMode = true;
        //        view.MasterRowExpanded += view_MasterRowExpanded;
        //    }
        //}
        //private void view_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        //{
        //    GridView masterView = sender as GridView;
        //    GridView detailView = masterView.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
        //    detailView.BeginUpdate();
        //    detailView.OptionsDetail.EnableMasterViewMode = false;
        //    detailView.OptionsBehavior.Editable = false;
        //    detailView.OptionsDetail.ShowDetailTabs = true;


        //    foreach (GridColumn col in detailView.Columns)
        //    {
        //        if (col.FieldName.Contains("!"))
        //        {
        //            col.Visible = false;
        //            col.OptionsColumn.ShowInCustomizationForm = false;
        //        }
        //    }

        //    detailView.EndUpdate();
        }
    }
}