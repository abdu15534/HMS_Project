﻿
namespace HMS.Module.Win.reports
{
    partial class PatientDayReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDayReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.detailTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.productDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorName2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.thankYouLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.invoiceInfoTable = new DevExpress.XtraReports.UI.XRTable();
            this.customerTable = new DevExpress.XtraReports.UI.XRTable();
            this.vendorTable = new DevExpress.XtraReports.UI.XRTable();
            this.invoiceNumberRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceDateRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceNumber = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceInfoTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerAddressRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerName = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorAddressRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorName = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.totalCaptionRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.totalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.totalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.total = new DevExpress.XtraReports.UI.XRTableCell();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.xpObjectSource1 = new DevExpress.Xpo.XPObjectSource(this.components);
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.simpleTextStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.captionsStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpObjectSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.detailTable});
            this.Detail.HeightF = 46F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.TopMargin.HeightF = 185.1667F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.vendorName2,
            this.xrLine3,
            this.thankYouLabel});
            this.BottomMargin.HeightF = 120F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.invoiceInfoTable,
            this.customerTable,
            this.vendorTable});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 210F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.totalTable,
            this.xrLine2});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 97F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.GroupFooter1.PrintAtBottom = true;
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.GroupHeader1.HeightF = 60F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // detailTable
            // 
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(10.0009F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow1,
            this.detailTableRow2});
            this.detailTable.SizeF = new System.Drawing.SizeF(628.9987F, 46F);
            this.detailTable.StylePriority.UseFont = false;
            this.detailTable.StylePriority.UsePadding = false;
            // 
            // detailTableRow1
            // 
            this.detailTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productName,
            this.quantity,
            this.unitPrice,
            this.lineTotal});
            this.detailTableRow1.Name = "detailTableRow1";
            this.detailTableRow1.Weight = 10.58D;
            // 
            // detailTableRow2
            // 
            this.detailTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productDescription,
            this.detailTableCell1,
            this.detailTableCell2,
            this.detailTableCell5});
            this.detailTableRow2.Name = "detailTableRow2";
            this.detailTableRow2.Weight = 10.58D;
            // 
            // productName
            // 
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 5, 0, 100F);
            this.productName.StyleName = "captionsStyle";
            this.productName.StylePriority.UsePadding = false;
            this.productName.Text = "ProductName";
            this.productName.Weight = 1.2413304070997198D;
            // 
            // quantity
            // 
            this.quantity.Name = "quantity";
            this.quantity.RowSpan = 2;
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.Text = "1";
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.quantity.Weight = 0.14886519910528495D;
            // 
            // unitPrice
            // 
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.RowSpan = 2;
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.Text = "ج.م‏000";
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.unitPrice.TextFormatString = "{0:$0.00}";
            this.unitPrice.Weight = 0.39020371536400655D;
            // 
            // lineTotal
            // 
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.RowSpan = 2;
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.Text = "ج.م‏000";
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lineTotal.TextFormatString = "{0:$0.00}";
            this.lineTotal.Weight = 0.55847802894367038D;
            // 
            // productDescription
            // 
            this.productDescription.CanShrink = true;
            this.productDescription.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.productDescription.Name = "productDescription";
            this.productDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 10, 100F);
            this.productDescription.StylePriority.UseFont = false;
            this.productDescription.StylePriority.UseForeColor = false;
            this.productDescription.StylePriority.UsePadding = false;
            this.productDescription.Text = "ProductDescription";
            this.productDescription.Weight = 1.5064990354212471D;
            // 
            // detailTableCell1
            // 
            this.detailTableCell1.Name = "detailTableCell1";
            this.detailTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 5, 0, 100F);
            this.detailTableCell1.StylePriority.UsePadding = false;
            this.detailTableCell1.Weight = 0.18066387034667344D;
            // 
            // detailTableCell2
            // 
            this.detailTableCell2.Name = "detailTableCell2";
            this.detailTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 5, 0, 100F);
            this.detailTableCell2.StylePriority.UsePadding = false;
            this.detailTableCell2.Weight = 0.47355771782990957D;
            // 
            // detailTableCell5
            // 
            this.detailTableCell5.Name = "detailTableCell5";
            this.detailTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 5, 0, 100F);
            this.detailTableCell5.StylePriority.UsePadding = false;
            this.detailTableCell5.Weight = 0.67777736954609358D;
            // 
            // vendorName2
            // 
            this.vendorName2.CanShrink = true;
            this.vendorName2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.vendorName2.LocationFloat = new DevExpress.Utils.PointFloat(9.999943F, 50F);
            this.vendorName2.Name = "vendorName2";
            this.vendorName2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.vendorName2.SizeF = new System.Drawing.SizeF(140.0104F, 24.99998F);
            this.vendorName2.StylePriority.UseFont = false;
            this.vendorName2.StylePriority.UseTextAlignment = false;
            this.vendorName2.Text = "VendorName";
            this.vendorName2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine3
            // 
            this.xrLine3.ForeColor = System.Drawing.Color.Silver;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(9.999943F, 9.999974F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(628.9996F, 9.999999F);
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.CanShrink = true;
            this.thankYouLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.thankYouLabel.LocationFloat = new DevExpress.Utils.PointFloat(10.01046F, 19.99995F);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.thankYouLabel.SizeF = new System.Drawing.SizeF(628.9996F, 17.79167F);
            this.thankYouLabel.StyleName = "simpleTextStyle";
            this.thankYouLabel.StylePriority.UseFont = false;
            this.thankYouLabel.Text = "Thank you for your confidence in our work.";
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.Silver;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(10F, 200F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(628.9996F, 10.00002F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // invoiceInfoTable
            // 
            this.invoiceInfoTable.LocationFloat = new DevExpress.Utils.PointFloat(10F, 70.00002F);
            this.invoiceInfoTable.Name = "invoiceInfoTable";
            this.invoiceInfoTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.invoiceNumberRow,
            this.invoiceDateRow});
            this.invoiceInfoTable.SizeF = new System.Drawing.SizeF(629.0016F, 50.00002F);
            this.invoiceInfoTable.StyleName = "simpleTextStyle";
            // 
            // customerTable
            // 
            this.customerTable.LocationFloat = new DevExpress.Utils.PointFloat(10F, 130F);
            this.customerTable.Name = "customerTable";
            this.customerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.customerNameRow,
            this.customerAddressRow});
            this.customerTable.SizeF = new System.Drawing.SizeF(628.9998F, 50.00002F);
            this.customerTable.StyleName = "simpleTextStyle";
            // 
            // vendorTable
            // 
            this.vendorTable.LocationFloat = new DevExpress.Utils.PointFloat(264.5F, 10F);
            this.vendorTable.Name = "vendorTable";
            this.vendorTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.vendorNameRow,
            this.vendorAddressRow});
            this.vendorTable.SizeF = new System.Drawing.SizeF(374.5064F, 49.99997F);
            this.vendorTable.StyleName = "simpleTextStyle";
            // 
            // invoiceNumberRow
            // 
            this.invoiceNumberRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceLabel,
            this.invoiceNumber});
            this.invoiceNumberRow.Name = "invoiceNumberRow";
            this.invoiceNumberRow.Weight = 1D;
            // 
            // invoiceDateRow
            // 
            this.invoiceDateRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceInfoTableCell1,
            this.invoiceDate});
            this.invoiceDateRow.Name = "invoiceDateRow";
            this.invoiceDateRow.Weight = 1D;
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.CanShrink = true;
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.invoiceLabel.StyleName = "captionsStyle";
            this.invoiceLabel.StylePriority.UseFont = false;
            this.invoiceLabel.StylePriority.UseForeColor = false;
            this.invoiceLabel.StylePriority.UsePadding = false;
            this.invoiceLabel.StylePriority.UseTextAlignment = false;
            this.invoiceLabel.Text = "Invoice";
            this.invoiceLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.invoiceLabel.Weight = 0.75545556692326243D;
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.CanShrink = true;
            this.invoiceNumber.Name = "invoiceNumber";
            this.invoiceNumber.StylePriority.UseFont = false;
            this.invoiceNumber.StylePriority.UsePadding = false;
            this.invoiceNumber.Text = "Number: 000001";
            this.invoiceNumber.TextFormatString = "Number: {0}";
            this.invoiceNumber.Weight = 1.1116672167162656D;
            // 
            // invoiceInfoTableCell1
            // 
            this.invoiceInfoTableCell1.CanShrink = true;
            this.invoiceInfoTableCell1.Name = "invoiceInfoTableCell1";
            this.invoiceInfoTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.invoiceInfoTableCell1.StylePriority.UseFont = false;
            this.invoiceInfoTableCell1.StylePriority.UsePadding = false;
            this.invoiceInfoTableCell1.StylePriority.UseTextAlignment = false;
            this.invoiceInfoTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.invoiceInfoTableCell1.Weight = 0.75545538574704085D;
            // 
            // invoiceDate
            // 
            this.invoiceDate.CanShrink = true;
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.StylePriority.UseFont = false;
            this.invoiceDate.StylePriority.UsePadding = false;
            this.invoiceDate.Text = "InvoiceDate";
            this.invoiceDate.TextFormatString = "Date: {0:d MMMM, yyyy}";
            this.invoiceDate.Weight = 1.1116673978924869D;
            // 
            // customerNameRow
            // 
            this.customerNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerLabel,
            this.customerName});
            this.customerNameRow.Name = "customerNameRow";
            this.customerNameRow.Weight = 1D;
            // 
            // customerAddressRow
            // 
            this.customerAddressRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerTableCell1,
            this.customerAddress});
            this.customerAddressRow.Name = "customerAddressRow";
            this.customerAddressRow.Weight = 1D;
            // 
            // customerLabel
            // 
            this.customerLabel.CanShrink = true;
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.customerLabel.StyleName = "captionsStyle";
            this.customerLabel.StylePriority.UseFont = false;
            this.customerLabel.StylePriority.UseForeColor = false;
            this.customerLabel.StylePriority.UsePadding = false;
            this.customerLabel.StylePriority.UseTextAlignment = false;
            this.customerLabel.Text = "Customer";
            this.customerLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.customerLabel.Weight = 0.75545770218987562D;
            // 
            // customerName
            // 
            this.customerName.CanShrink = true;
            this.customerName.Name = "customerName";
            this.customerName.StylePriority.UseFont = false;
            this.customerName.StylePriority.UsePadding = false;
            this.customerName.Text = "CustomerName";
            this.customerName.Weight = 1.111665081449652D;
            // 
            // customerTableCell1
            // 
            this.customerTableCell1.CanShrink = true;
            this.customerTableCell1.Name = "customerTableCell1";
            this.customerTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.customerTableCell1.StylePriority.UseFont = false;
            this.customerTableCell1.StylePriority.UsePadding = false;
            this.customerTableCell1.StylePriority.UseTextAlignment = false;
            this.customerTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.customerTableCell1.Weight = 0.75545770218987562D;
            // 
            // customerAddress
            // 
            this.customerAddress.CanShrink = true;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.StylePriority.UseFont = false;
            this.customerAddress.StylePriority.UsePadding = false;
            this.customerAddress.Text = "CustomerAddress";
            this.customerAddress.Weight = 1.111665081449652D;
            // 
            // vendorNameRow
            // 
            this.vendorNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorName});
            this.vendorNameRow.Name = "vendorNameRow";
            this.vendorNameRow.Weight = 1D;
            // 
            // vendorAddressRow
            // 
            this.vendorAddressRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorAddress});
            this.vendorAddressRow.Name = "vendorAddressRow";
            this.vendorAddressRow.Weight = 1D;
            // 
            // vendorName
            // 
            this.vendorName.CanShrink = true;
            this.vendorName.Name = "vendorName";
            this.vendorName.StylePriority.UseFont = false;
            this.vendorName.StylePriority.UsePadding = false;
            this.vendorName.Text = "VendorName";
            this.vendorName.Weight = 1D;
            // 
            // vendorAddress
            // 
            this.vendorAddress.CanShrink = true;
            this.vendorAddress.Name = "vendorAddress";
            this.vendorAddress.StylePriority.UseFont = false;
            this.vendorAddress.StylePriority.UsePadding = false;
            this.vendorAddress.Text = "VendorAddress";
            this.vendorAddress.Weight = 1D;
            // 
            // totalTable
            // 
            this.totalTable.LocationFloat = new DevExpress.Utils.PointFloat(10.0104F, 21.75007F);
            this.totalTable.Name = "totalTable";
            this.totalTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.totalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.totalCaptionRow,
            this.totalRow});
            this.totalTable.SizeF = new System.Drawing.SizeF(628.9996F, 75F);
            this.totalTable.StylePriority.UsePadding = false;
            // 
            // xrLine2
            // 
            this.xrLine2.ForeColor = System.Drawing.Color.Silver;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 6.357829E-05F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(628.9996F, 10F);
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // totalCaptionRow
            // 
            this.totalCaptionRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.totalCaption});
            this.totalCaptionRow.Name = "totalCaptionRow";
            this.totalCaptionRow.StyleName = "captionsStyle";
            this.totalCaptionRow.Weight = 11.5D;
            // 
            // totalRow
            // 
            this.totalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.total});
            this.totalRow.Name = "totalRow";
            this.totalRow.StyleName = "captionsStyle";
            this.totalRow.Weight = 23D;
            // 
            // totalCaption
            // 
            this.totalCaption.Name = "totalCaption";
            this.totalCaption.StylePriority.UseFont = false;
            this.totalCaption.StylePriority.UseTextAlignment = false;
            this.totalCaption.Text = "TOTAL";
            this.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.totalCaption.Weight = 3.7211418967813294D;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.total.Name = "total";
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UseTextAlignment = false;
            this.total.Text = "ج.م‏000";
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.total.TextFormatString = "{0:$0.00}";
            this.total.Weight = 3.7211418967813294D;
            // 
            // headerTable
            // 
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(10F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 15, 0, 100F);
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(628.9896F, 40F);
            this.headerTable.StyleName = "captionsStyle";
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productNameCaption,
            this.quantityCaption,
            this.unitPriceCaption,
            this.lineTotalCaption});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // productNameCaption
            // 
            this.productNameCaption.Name = "productNameCaption";
            this.productNameCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 15, 0, 100F);
            this.productNameCaption.StylePriority.UsePadding = false;
            this.productNameCaption.Text = "Description";
            this.productNameCaption.Weight = 1.2238347420907791D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.StylePriority.UsePadding = false;
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "Qty";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.quantityCaption.Weight = 0.14682011672444889D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "Price";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.unitPriceCaption.Weight = 0.38471762273724119D;
            // 
            // lineTotalCaption
            // 
            this.lineTotalCaption.Name = "lineTotalCaption";
            this.lineTotalCaption.StylePriority.UseTextAlignment = false;
            this.lineTotalCaption.Text = "Total";
            this.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lineTotalCaption.Weight = 0.55057837116473252D;
            // 
            // xpObjectSource1
            // 
            this.xpObjectSource1.ConnectionStringName = "ConnectionString";
            this.xpObjectSource1.EntityTypeString = "XafDataModel.Module.BusinessObjects.test2.ReceptionDesk, HMS.Module, Version=1.0." +
    "8232.16130, Culture=neutral, PublicKeyToken=null";
            this.xpObjectSource1.Name = "xpObjectSource1";
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // simpleTextStyle
            // 
            this.simpleTextStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.simpleTextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.simpleTextStyle.Name = "simpleTextStyle";
            this.simpleTextStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // captionsStyle
            // 
            this.captionsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.captionsStyle.ForeColor = System.Drawing.Color.Black;
            this.captionsStyle.Name = "captionsStyle";
            this.captionsStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(45.41652F, 10.00001F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(172.6295F, 160.5834F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            this.xrPictureBox1.StylePriority.UseBorderColor = false;
            this.xrPictureBox1.StylePriority.UseBorders = false;
            this.xrPictureBox1.StylePriority.UsePadding = false;
            // 
            // PatientDayReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.xpObjectSource1});
            this.DataSource = this.xpObjectSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(101, 100, 185, 120);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle,
            this.simpleTextStyle,
            this.captionsStyle});
            this.Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpObjectSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice;
        private DevExpress.XtraReports.UI.XRTableCell lineTotal;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell productDescription;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell5;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel vendorName2;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLabel thankYouLabel;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRTable invoiceInfoTable;
        private DevExpress.XtraReports.UI.XRTableRow invoiceNumberRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceLabel;
        private DevExpress.XtraReports.UI.XRTableCell invoiceNumber;
        private DevExpress.XtraReports.UI.XRTableRow invoiceDateRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceInfoTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDate;
        private DevExpress.XtraReports.UI.XRTable customerTable;
        private DevExpress.XtraReports.UI.XRTableRow customerNameRow;
        private DevExpress.XtraReports.UI.XRTableCell customerLabel;
        private DevExpress.XtraReports.UI.XRTableCell customerName;
        private DevExpress.XtraReports.UI.XRTableRow customerAddressRow;
        private DevExpress.XtraReports.UI.XRTableCell customerTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell customerAddress;
        private DevExpress.XtraReports.UI.XRTable vendorTable;
        private DevExpress.XtraReports.UI.XRTableRow vendorNameRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorName;
        private DevExpress.XtraReports.UI.XRTableRow vendorAddressRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorAddress;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable totalTable;
        private DevExpress.XtraReports.UI.XRTableRow totalCaptionRow;
        private DevExpress.XtraReports.UI.XRTableCell totalCaption;
        private DevExpress.XtraReports.UI.XRTableRow totalRow;
        private DevExpress.XtraReports.UI.XRTableCell total;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaption;
        private DevExpress.Xpo.XPObjectSource xpObjectSource1;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRControlStyle simpleTextStyle;
        private DevExpress.XtraReports.UI.XRControlStyle captionsStyle;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    }
}
