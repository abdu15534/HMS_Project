using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Utils;
using DevExpress.ExpressApp.Xpo;
using System;

namespace HMS.Win
{
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.WinApplication._members
    public partial class HMSWindowsFormsApplication : WinApplication
    {
        public HMSWindowsFormsApplication()
        {
            InitializeComponent();
            //LinkNewObjectToParentImmediately = true;
            NewObjectViewController.DefaultNewObjectActionItemListMode = NewObjectActionItemListMode.Default;
            securityStrategyComplex1.AllowAnonymousAccess = true;
            SplashScreen = new DXSplashScreen(typeof(XafSplashScreen), new DefaultOverlayFormOptions());
        }
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args)
        {
            args.ObjectSpaceProviders.Add(new SecuredObjectSpaceProvider((SecurityStrategyComplex)Security, XPObjectSpaceProvider.GetDataStoreProvider(args.ConnectionString, args.Connection, true), false));
            args.ObjectSpaceProviders.Add(new NonPersistentObjectSpaceProvider(TypesInfo, null));
            ((SecuredObjectSpaceProvider)args.ObjectSpaceProviders[0]).AllowICommandChannelDoWithSecurityContext = true;
        }
        private void HMSWindowsFormsApplication_CustomizeLanguagesList(object sender, CustomizeLanguagesListEventArgs e)
        {
            string userLanguageName = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            if (userLanguageName != "en-US" && e.Languages.IndexOf(userLanguageName) == -1)
            {
                e.Languages.Add(userLanguageName);
            }
        }
        private void HMSWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e)
        {
#if EASYTEST
            e.Updater.Update();
            e.Handled = true;
#else
            if (System.Diagnostics.Debugger.IsAttached)
            {
                e.Updater.Update();
                e.Handled = true;
            }
            else
            {
                string message = "The application cannot connect to the specified database, " +
                    "because the database doesn't exist, its version is older " +
                    "than that of the application or its schema does not match " +
                    "the ORM data model structure. To avoid this error, use one " +
                    "of the solutions from the https://www.devexpress.com/kb=T367835 KB Article.";

                if (e.CompatibilityError != null && e.CompatibilityError.Exception != null)
                {
                    message += "\r\n\r\nInner exception: " + e.CompatibilityError.Exception.Message;
                }
                throw new InvalidOperationException(message);
            }
#endif
        }


        #region RTL

        public void ApplyRightToLeft(System.Windows.Forms.Form form)
        {
            if (form != null)
            {
                form.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                form.RightToLeftLayout = true;
            }
        }
        protected override void OnCustomizeTemplate(DevExpress.ExpressApp.Templates.IFrameTemplate frameTemplate, string templateContextName)
        {
            base.OnCustomizeTemplate(frameTemplate, templateContextName);
            if (currentLanguage == "ar" || currentLanguage == "he") // Right-To-Left languages  
                ApplyRightToLeft(frameTemplate as System.Windows.Forms.Form);
        }
        protected override System.Windows.Forms.Form CreateModelEditorForm()
        {
            System.Windows.Forms.Form form = base.CreateModelEditorForm();
            if (currentLanguage == "ar" || currentLanguage == "he") // Right-To-Left languages  
                ApplyRightToLeft(form);
            return form;
        }
        public string currentLanguage
        {
            get
            {
                try
                {
                    string output;
                    output = "en";
                    if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name != "")
                        output = System.Threading.Thread.CurrentThread.CurrentUICulture.Name.Substring(0, 2).ToLower();
                    return output;
                    // First two Letter ar,en, ... etc  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "";
                }
            }

        }

        #endregion


        private void HMSWindowsFormsApplication_CreateCustomTemplate(object sender, CreateCustomTemplateEventArgs e)
        {
            //if (e.Context == TemplateContext.View) e.Template = new Forms.MainRibbonForm1();
        }
    }
}
