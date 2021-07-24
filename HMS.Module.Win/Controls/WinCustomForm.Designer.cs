
namespace HMS.Win.Controls
{
    partial class WinCustomForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator2 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.SuspendLayout();
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Location = new System.Drawing.Point(304, 57);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(325, 98);
            this.barCodeControl1.Symbology = code128Generator2;
            this.barCodeControl1.TabIndex = 0;
            // 
            // WinCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::HMS.Module.Win.Properties.Resources._56d0f8e9_13fa_457b_a7f8_814156ba5330;
            this.ClientSize = new System.Drawing.Size(792, 449);
            this.Controls.Add(this.barCodeControl1);
            this.Name = "WinCustomForm";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
    }
}