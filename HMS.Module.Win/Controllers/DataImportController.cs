﻿using DevExpress.Data.Filtering;
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
using ClosedXML.Excel;
using DevExpress.Xpo;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Layout;
using System.Diagnostics;
using XafDataModel.Module.BusinessObjects.test2;
using DevExpress.XtraReports.UI;
using static XafDataModel.Module.BusinessObjects.test2.Service;
using ServiceTypes = XafDataModel.Module.BusinessObjects.test2.Service.ServiceTypes;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class DataImportController : ViewController
    {
        public DataImportController()
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
        private void ImportujPozycjeExcelAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            
        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            DataTable dt;
            
            OpenFileDialog excel = new OpenFileDialog();
            excel.Filter = "Dokument excel|*.xls;*.xlsx";
            excel.Title = "أختر الملف الذي يحتوي على خدمات العيادات و الطوارئ";
            if (excel.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    SplashScreenManager.ShowDefaultWaitForm("ارجوك انتظر", "جاري حفظ الخدمات ...");

                    dt = ExtractDataTable(excel, 1);



                    foreach (DataRow row in dt.Rows)
                    {
                        //Debug.WriteLine(dt.Rows);
                        Service service = ObjectSpace.CreateObject<Service>();
                        //fzp.Ilosc = 1;
                        string myString = "";
                        //row[0] - produkt
                        //string[] ciag = row[0].ToString().Split('-');

                        if (row[0] != DBNull.Value)
                        {
                            //myString = row[0].ToString();
                            if (!string.IsNullOrEmpty(row[0].ToString()))
                                service.ID = Convert.ToInt32(row[0].ToString());
                        }

            
                        if (row[1] != DBNull.Value)
                        {
                            myString = row[1].ToString();
                            service.ServiceType = (ServiceTypes)Convert.ToInt32(row[1].ToString());
                            //if (!string.IsNullOrEmpty(row[1].ToString()))
                            //    fzp.NazwaProduktu = row[1].ToString();
                        }

                      
                        if (row[2] != DBNull.Value)
                        {
                            myString += " - " + row[2].ToString();
                            //if (!string.IsNullOrEmpty(row[2].ToString()))
                            //{
                            //    fzp.Cena = Convert.ToDecimal(row[2].ToString()) / fzp.Ilosc;
                            //}

                        }

                   
                       
                        if (row[3] != DBNull.Value)
                        {
                            //myString += " - " + row[3].ToString();
                            if (!string.IsNullOrEmpty(row[3].ToString()))
                            {
                                service.Name = row[3].ToString();
                            }
                        }
                       


                        if (row[4] != DBNull.Value)
                        {
                            //myString += " - " + row[4].ToString();
                            if (!string.IsNullOrEmpty(row[4].ToString()))
                            {
                                service.Price = Convert.ToDecimal(row[4].ToString());
                            }

                        }
                        

                        //row[5]- czy kwota netto ( nie uzywamy )  

                        //row[6]- NKUP/KUP  
                        //if (row[5] != DBNull.Value)
                        //{
                        //    myString += " - " + row[5].ToString();
                        //    //if (!string.IsNullOrEmpty(row[6].ToString()))
                        //    //{
                        //    //    if (row[6].ToString().ToLower() == "kup")
                        //    //        fzp.NKUP = KupNKup.KUP_;
                        //    //    else
                        //    //        fzp.NKUP = KupNKup.NKUP;
                        //    //}

                        //}

                        Debug.WriteLine(myString);
                        //    //row[7]- Srodek trwaly  
                        //    if (row[7] != DBNull.Value)
                        //    {
                        //        if (!string.IsNullOrEmpty(row[7].ToString()))
                        //        {
                        //            if (row[7].ToString().ToLower() == "tak")
                        //                fzp.SrodekTrwaly = true;
                        //            else
                        //                fzp.SrodekTrwaly = false;
                        //        }
                        //        else
                        //            fzp.SrodekTrwaly = false;
                        //    }
                        //    else
                        //        fzp.SrodekTrwaly = false;

                        //    //try  
                        //    //{  
                        //    //    if (fzp.Produkt != null && fzp.Oddzial != null &&  
                        //    //    fzp.Dzial != null && fzp.KomorkaKoszt != null)  
                        //    //    {  
                        //    //        fzp.Konto = string.Format("{0}-{1}-{2}-{3}-{4}",  
                        //    //       fzp.Produkt.Identyfikator,  
                        //    //       fzp.Oddzial.Konto,  
                        //    //       fzp.Dzial.SymbolDzialu,  
                        //    //       fzp.KomorkaKoszt.Konto,  
                        //    //       fzp.NKUP.ToString()  
                        //    //       );  
                        //    //    }  
                        //    //}  
                        //    //catch  
                        //    //{  
                        //    //    fzp.Konto = null;  
                        //    //}  


                        //    fzp.FakturaZakupu = fz;
                        //    fzp.Save();
                    }

                    ObjectSpace.CommitChanges();
                    ObjectSpace.Refresh();

                    SplashScreenManager.CloseForm(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    SplashScreenManager.CloseForm(false);
                    ErrorSplashScreen(ex, "حدث خطأ أثناء استيراد البيانات من ملف Excel. انقر فوق الرسالة لمعرفة التفاصيل.");
                }

            }
        }

        private void AddXrayServices_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            DataTable dt;

            OpenFileDialog excel = new OpenFileDialog();
            excel.Filter = "Dokument excel|*.xls;*.xlsx";
            excel.Title = "أختر الملف الذي يحتوي على الاشعة";
            if (excel.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    SplashScreenManager.ShowDefaultWaitForm("ارجوك انتظر", "جاري حفظ الخدمات ...");

                    dt = ExtractDataTable(excel, 2);



                    foreach (DataRow row in dt.Rows)
                    {
                        //Debug.WriteLine(dt.Rows);
                        Service service = ObjectSpace.CreateObject<Service>();
                        //fzp.Ilosc = 1;
                        string myString = "";
                        //row[0] - produkt
                        //string[] ciag = row[0].ToString().Split('-');

                        if (row[0] != DBNull.Value)
                        {
                            myString = row[0].ToString();
                            if (!string.IsNullOrEmpty(row[0].ToString()))
                                service.ID = Convert.ToInt32(row[0].ToString());

                        }


                        if (row[1] != DBNull.Value)
                        {
                            myString += " - "+ row[1].ToString();
                            service.ServiceType = (ServiceTypes)16;
                            //if (!string.IsNullOrEmpty(row[1].ToString()))
                            //    fzp.NazwaProduktu = row[1].ToString();
                        }


                        if (row[2] != DBNull.Value)
                        {
                            myString += " - " + row[2].ToString();
                            //if (!string.IsNullOrEmpty(row[2].ToString()))
                            //{
                            //    fzp.Cena = Convert.ToDecimal(row[2].ToString()) / fzp.Ilosc;
                            //}

                        }



                        if (row[3] != DBNull.Value)
                        {
                            //myString += " - " + row[3].ToString();
                            if (!string.IsNullOrEmpty(row[3].ToString()))
                            {
                                service.Name = row[3].ToString();
                            }
                        }



                        if (row[4] != DBNull.Value)
                        {
                            //myString += " - " + row[4].ToString();
                            if (!string.IsNullOrEmpty(row[4].ToString()))
                            {
                                service.EnglishName = row[4].ToString();
                            }

                        }


                        //row[5]- czy kwota netto ( nie uzywamy )  
 
                        if (row[5] != DBNull.Value)
                        {
                            //myString += " - " + row[5].ToString();
                            if (!string.IsNullOrEmpty(row[5].ToString()))
                            {
                                service.Price = Convert.ToDecimal(row[5].ToString());
                            }

                        }

                        Debug.WriteLine(myString);
                         


                        //    fzp.FakturaZakupu = fz;
                        //    fzp.Save();
                    }

                    ObjectSpace.CommitChanges();
                    ObjectSpace.Refresh();

                    SplashScreenManager.CloseForm(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    SplashScreenManager.CloseForm(false);
                    ErrorSplashScreen(ex, "حدث خطأ أثناء استيراد البيانات من ملف Excel. انقر فوق الرسالة لمعرفة التفاصيل.");
                }

            }
        }

        private void AddTests_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            DataTable dt;

            OpenFileDialog excel = new OpenFileDialog();
            excel.Filter = "Dokument excel|*.xls;*.xlsx";
            excel.Title = "أختر الملف الذي يحتوي على التحالي";
            if (excel.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    SplashScreenManager.ShowDefaultWaitForm("ارجوك انتظر", "جاري حفظ الخدمات ...");
                    dt = ExtractDataTable(excel, 3);




                    foreach (DataRow row in dt.Rows)
                    {
                        //Debug.WriteLine(dt.Rows);
                        Service service = ObjectSpace.CreateObject<Service>();
                        //fzp.Ilosc = 1;
                        string myString = "";
                        

                        if (row[0] != DBNull.Value)
                        {
                            //myString = row[0].ToString();
                            if (!string.IsNullOrEmpty(row[0].ToString()))
                                service.ID = Convert.ToInt32(row[0].ToString());
                            
                        }


                        if (row[1] != DBNull.Value)
                        {
                            myString = " - " + row[1].ToString();
                            service.ServiceType = (ServiceTypes)17;
                            //if (!string.IsNullOrEmpty(row[1].ToString()))
                            //    fzp.NazwaProduktu = row[1].ToString();
                        }


                        if (row[2] != DBNull.Value)
                        {
                            //myString += " - " + row[2].ToString();
                            if (!string.IsNullOrEmpty(row[2].ToString()))
                            {
                                service.Name = row[2].ToString();
                            }

                        }



                        if (row[3] != DBNull.Value)
                        {
                            //myString += " - " + row[3].ToString();
                            if (!string.IsNullOrEmpty(row[3].ToString()))
                            {
                                service.Price = Convert.ToDecimal(row[3].ToString());
                            }
                        }

                        Debug.WriteLine(myString);
                        

                        //    fzp.FakturaZakupu = fz;
                        //    fzp.Save();
                    }

                    ObjectSpace.CommitChanges();
                    ObjectSpace.Refresh();

                    SplashScreenManager.CloseForm(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    SplashScreenManager.CloseForm(false);
                    ErrorSplashScreen(ex, "حدث خطأ أثناء استيراد البيانات من ملف Excel. انقر فوق الرسالة لمعرفة التفاصيل.");
                }

            }
        }

        private void AddPharmacy_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            DataTable dt;

            OpenFileDialog excel = new OpenFileDialog();
            excel.Filter = "Dokument excel|*.xls;*.xlsx";
            excel.Title = "أختر الملف الذي يحتوي على الأدوية";
            if (excel.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    SplashScreenManager.ShowDefaultWaitForm("ارجوك انتظر", "جاري حفظ الأدوية ...");

                    dt = ExtractDataTable(excel, 2);


                    //fz = (ObjectSpace.Owner as DetailView).CurrentObject as FakturaZakupu;

                    foreach (DataRow row in dt.Rows)
                    {
                        //Debug.WriteLine(dt.Rows);
                        Product product = ObjectSpace.CreateObject<Product>();
                        //fzp.Ilosc = 1;
                        string myString = "";


                        if (row[5] != DBNull.Value)
                        {
                            myString = row[5].ToString();
                            if (!string.IsNullOrEmpty(row[5].ToString()))
                                product.sellingPrice = Convert.ToDecimal(row[5].ToString());
                        }


                        if (row[9] != DBNull.Value)
                        {
                            myString += " - " + row[9].ToString();
                            //service.ServiceType = (ServiceTypes)17;
                            //if (!string.IsNullOrEmpty(row[1].ToString()))
                            //    fzp.NazwaProduktu = row[1].ToString();
                        }


                        if (row[10] != DBNull.Value)
                        {
                            myString += " - " + row[10].ToString();
                            if (!string.IsNullOrEmpty(row[10].ToString()))
                            {
                                //service.Name = row[2].ToString();
                            }

                        }



                        if (row[11] != DBNull.Value)
                        {
                            myString += " - " + row[11].ToString();
                            if (!string.IsNullOrEmpty(row[11].ToString()))
                            {
                                product.name = row[11].ToString();
                            }
                        }

                        if (row[12] != DBNull.Value)
                        {
                            myString += " - " + row[12].ToString();
                            if (!string.IsNullOrEmpty(row[12].ToString()))
                            {
                                try 
                                { 
                                    product.id = Convert.ToInt32(row[12].ToString());
                                }
                                catch
                                {
                                    product.Delete();
                                }
                            }
                        }
                        product.category = ObjectSpace.FindObject<Category>(CriteriaOperator.Parse("name = ?", "دواء"));

                        Debug.WriteLine(myString);


                        //    fzp.FakturaZakupu = fz;
                        //    fzp.Save();
                    }

                    ObjectSpace.CommitChanges();
                    ObjectSpace.Refresh();

                    SplashScreenManager.CloseForm(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    SplashScreenManager.CloseForm(false);
                    ErrorSplashScreen(ex, "حدث خطأ أثناء استيراد البيانات من ملف Excel. انقر فوق الرسالة لمعرفة التفاصيل.");
                }

            }
        }

        private void AddStock_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            DataTable dt;

            OpenFileDialog excel = new OpenFileDialog();
            excel.Filter = "Dokument excel|*.xls;*.xlsx";
            excel.Title = "أختر الملف الذي يحتوي على المستهلكات";
            if (excel.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    SplashScreenManager.ShowDefaultWaitForm("ارجوك انتظر", "جاري حفظ المستهلكات ...");
                    dt = ExtractDataTable(excel, 1);

                    //fz = (ObjectSpace.Owner as DetailView).CurrentObject as FakturaZakupu;

                    foreach (DataRow row in dt.Rows)
                    {
                       
                        Product product = ObjectSpace.CreateObject<Product>();
                        //string myString = "";

                        product.id = Convert.ToInt32(GetCellValue(row,0));

                        product.name = GetCellValue(row, 1);

                        product.TempQuantity = Convert.ToDouble(GetCellValue(row, 2));

                        ProductUnit Unit = ObjectSpace.FindObject<ProductUnit>(CriteriaOperator.Parse("unit = ?", GetCellValue(row, 3)));

                        product.purchasingUnit = Unit;
                        product.sellUnit = Unit;

                        product.category = ObjectSpace.FindObject<Category>(CriteriaOperator.Parse("name = ?", "مستهلكات"));

                        product.purchasingPrice = Convert.ToDecimal(GetCellValue(row, 4));
                       
                        //Debug.WriteLine(myString);

                        ObjectSpace.CommitChanges();
                    }

                    ObjectSpace.Refresh();

                    SplashScreenManager.CloseForm(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    SplashScreenManager.CloseForm(false);
                    ErrorSplashScreen(ex, "حدث خطأ أثناء استيراد البيانات من ملف Excel. انقر فوق الرسالة لمعرفة التفاصيل.");
                }

            }
        }

        private string GetCellValue(DataRow row, int cellIdx)
        {

            try
            {
                if (row[cellIdx] != DBNull.Value)
                {
                    if (!string.IsNullOrEmpty(row[cellIdx].ToString()))
                        return row[cellIdx].ToString();
                }
                return null;
            }
            catch (Exception e)
            {
                ErrorSplashScreen(e, e.Message);
                return null;
            }
         
        }

        private void ErrorSplashScreen(Exception ex, string msg)
        {
            Tracing.Tracer.LogError(ex);
            MessageOptions mo = new MessageOptions();
            mo.Duration = 3000;
            mo.Message = msg;
            mo.Type = InformationType.Error;
            mo.OkDelegate = () =>
            {
                IObjectSpace os = Application.CreateObjectSpace(typeof(ErrorBox));
                //ErrorBox eb = new ErrorBox(ex.Message);
                //DetailView dv = Application.CreateDetailView(os, eb);

                //Application.ShowViewStrategy.ShowViewInPopupWindow(dv);
            };
            Application.ShowViewStrategy.ShowMessage(mo);
        }

        private static DataTable ExtractDataTable(OpenFileDialog excel, int sheetNum)
        {
            bool EmptyRow;
            DataTable dt;
            using (XLWorkbook workBook = new XLWorkbook(excel.FileName))
            {
                #region Deserializacja Excel  
                var rows = workBook.Worksheet(sheetNum).RowsUsed();

                dt = new DataTable();

                bool isFirstRow = true;

                foreach (var row in rows)
                {
                    //Console.WriteLine(row);
                    EmptyRow = row.IsEmpty();


                    if (isFirstRow)
                    {
                        foreach (IXLCell cell in row.Cells())//foreach (IXLCell cell in row.Cells())  
                        {
                            //Debug.WriteLine(cell.Value);
                            //Console.WriteLine(cell.Value);
                            //Console.WriteLine("##");
                            dt.Columns.Add(cell.Value.ToString());
                        }

                        isFirstRow = false;
                    }
                    else
                    {
                        bool czyDodany = false;

                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                        {
                            //Console.OutputEncoding = System.Text.Encoding.UTF8;
                            //Console.WriteLine(cell.Value);
                            //Debug.WriteLine(cell.Value);
                            if (czyDodany == false)
                            {
                                dt.Rows.Add();
                                czyDodany = true;
                            }

                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }

                    }



                }
                #endregion
            }

            return dt;
        }

        private void PrintProductLable_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.StockProductLable report = new reports.StockProductLable();

            var curr = View.CurrentObject as Product;
            report.Parameters["parameter1"].Value = curr.id;
            report.ShowPreviewDialog();
        }

        private void AddPurchasingOrder_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            DataTable dt;

            OpenFileDialog excel = new OpenFileDialog();
            excel.Filter = "Dokument excel|*.xls;*.xlsx";
            excel.Title = "أختر الملف الذي يحتوي على المستهلكات";
            if (excel.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    SplashScreenManager.ShowDefaultWaitForm("ارجوك انتظر", "جاري حفظ المستهلكات ...");

                    var supplier = ObjectSpace.FindObject<Account>(CriteriaOperator.Parse("[accountName] = ?", "مخزون بضاعة اول المدة"));
                    var Order = ObjectSpace.CreateObject<PurchasingOrder>();
                    Order.supplierAccount = supplier;
                    Order.inventory = ObjectSpace.FindObject<Inventory>(CriteriaOperator.Parse("[Name] = ?", "Stock"));
                    Order.paymentAccount = ObjectSpace.FindObject<Account>(CriteriaOperator.Parse("[accountName] = ?", "مخزون بضاعة اول المدة"));
                    
                    dt = ExtractDataTable(excel, 1);
                    



                    foreach (DataRow row in dt.Rows)
                    {
                        try
                        {
                            //Debug.WriteLine(dt.Rows);
                            //        //fzp.Ilosc = 1;
                            string myString = "";


                            if (row[0] != DBNull.Value)
                            {
                                myString += row[0].ToString() + "first";
                                if (!string.IsNullOrEmpty(row[0].ToString()))
                                {
                                }
                            }
                            var xlProduct = ObjectSpace.GetObjectByKey<Product>(Convert.ToInt32(row[0].ToString()));

                            PurchasingOrderDetail purchase = ObjectSpace.CreateObject<PurchasingOrderDetail>();
                            //ObjectSpace.FindObject<Product>(CriteriaOperator.Parse("[name] = ? AND [sellingPrice] = ?", supplies2[j].name.ToString(), supplies2[j].purchasingPrice.ToString()));
                            purchase.product = xlProduct;
                            
                            
                            

                            if (row[1] != DBNull.Value)
                            {
                                myString += " - " + row[1].ToString() + "second";
                                //service.ServiceType = (ServiceTypes)17;
                                if (!string.IsNullOrEmpty(row[1].ToString()))
                                {

                                }
                            }


                            if (row[2] != DBNull.Value)
                            {
                                myString += " - " + row[2].ToString() + "therd";
                                if (!string.IsNullOrEmpty(row[2].ToString()))
                                {
                                    purchase.quantity = Convert.ToDouble(row[2].ToString());
                                }

                            }


                            if (row[3] != DBNull.Value)
                            {
                                Debug.WriteLine(row[3].ToString());
                                myString += " - " + row[3].ToString() + "fourth";
                                if (!string.IsNullOrEmpty(row[3].ToString()))
                                {
                                    
                                    
                                }
                            }
                            if (row[4] != DBNull.Value)
                            {
                                //myString += " - " + row[4].ToString()+ "fifth";
                                if (!string.IsNullOrEmpty(row[3].ToString()))
                                {
                                    purchase.price = Convert.ToDecimal(row[3].ToString());
                                }
                            }

                            Debug.WriteLine(myString);
                            //        ObjectSpace.CommitChanges();
                            Order.PurchasingOrderDetails.Add(purchase);
                        }
                        catch
                        {

                        }


                        ObjectSpace.CommitChanges();
                        //    //    fzp.FakturaZakupu = fz;
                        //    //    fzp.Save();
                    }

                    ObjectSpace.Refresh();

                    SplashScreenManager.CloseForm(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    ErrorSplashScreen(ex, "حدث خطأ أثناء استيراد البيانات من ملف Excel. انقر فوق الرسالة لمعرفة التفاصيل.");
                    
                }

            }
            //var Supplies = ObjectSpace.GetObjects<Product>().Where(p => p.category.name == "مستهلكات");
            //foreach (var item in Supplies.ToList())
            //{
            //}
        }
    }
}
