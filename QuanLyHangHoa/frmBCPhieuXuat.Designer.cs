namespace QuanLyHangHoa
{
    partial class frmBCPhieuXuat
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
            this.crystalReportViewerPhieuXuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerPhieuXuat
            // 
            this.crystalReportViewerPhieuXuat.ActiveViewIndex = -1;
            this.crystalReportViewerPhieuXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerPhieuXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerPhieuXuat.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerPhieuXuat.Name = "crystalReportViewerPhieuXuat";
            this.crystalReportViewerPhieuXuat.Size = new System.Drawing.Size(657, 498);
            this.crystalReportViewerPhieuXuat.TabIndex = 0;
            // 
            // frmBCPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 498);
            this.Controls.Add(this.crystalReportViewerPhieuXuat);
            this.DoubleBuffered = true;
            this.Name = "frmBCPhieuXuat";
            this.Text = "Phiếu xuất hàng";
            this.Load += new System.EventHandler(this.frmBCPhieuXuat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerPhieuXuat;
    }
}