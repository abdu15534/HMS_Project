using System;
using System.Linq;
using System.Collections.Generic;

namespace HMS.Module.Win
{
    public sealed partial class HMSWindowsFormsModule
    {
        // Extends the Application Model elements for View and Navigation Items to be able to specify custom controls via the Model Editor.
        // Refer to the http://documentation.devexpress.com/#Xaf/CustomDocument3169 help article for more information.
        public override void ExtendModelInterfaces(DevExpress.ExpressApp.Model.ModelInterfaceExtenders extenders)
        {
            base.ExtendModelInterfaces(extenders);
            extenders.Add<HMS.Module.Editors.IModelCustomUserControlViewItem, Editors.IModelWinCustomUserControlViewItem>();
            extenders.Add<DevExpress.ExpressApp.SystemModule.IModelNavigationItem, Controllers.IModelWinCustomFormPathNavigationItem>();
        }
    }
}
