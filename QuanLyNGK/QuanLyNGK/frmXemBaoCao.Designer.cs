namespace QuanLyNGK
{
    partial class frmXemBaoCao
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
            this.rpvBC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvBC
            // 
            this.rpvBC.Location = new System.Drawing.Point(12, 12);
            this.rpvBC.Name = "rpvBC";
            this.rpvBC.Size = new System.Drawing.Size(779, 410);
            this.rpvBC.TabIndex = 0;
            // 
            // frmXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 425);
            this.Controls.Add(this.rpvBC);
            this.Name = "frmXemBaoCao";
            this.Text = "frmXemBaoCao";
            this.Load += new System.EventHandler(this.frmXemBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBC;
    }
}