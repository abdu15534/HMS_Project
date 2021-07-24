using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;

namespace HMS.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class WinAlternatingRowsController : ViewController
    {
        public WinAlternatingRowsController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }


        private void WinAlternatingRowsController_ViewControlsCreated(object sender, EventArgs e)
        {
            GridListEditor listEditor = ((ListView)View).Editor as GridListEditor;
            if (listEditor != null)
            {

                GridView gridView = listEditor.GridView;

                gridView.OptionsView.EnableAppearanceOddRow = true;
                gridView.Appearance.OddRow.BackColor = Color.FromArgb(244, 244, 244);

            }
        }

        void GridControlViewController_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Info.Column.SummaryItem.DisplayFormat))
            {
                e.Info.DisplayText = /*String.Format(e.Info.Column.SummaryItem.DisplayFormat, e.Info.Value)*/ e.Info.Value.ToString();
                
            }
        }

     }
}
