namespace Pharmacy
{
    partial class ReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checktableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.pharmacyDataSet();
            this.checktableTableAdapter1 = new Pharmacy.pharmacyDataSetTableAdapters.checktableTableAdapter();
            this.pharmacyDataSet1 = new Pharmacy.pharmacyDataSet();
            this.checktableTableAdapter = new Pharmacy.pharmacyDataSetTableAdapters.checktableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checktableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.checktableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pharmacy.CustomerCheckReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // checktableBindingSource
            // 
            this.checktableBindingSource.DataMember = "checktable";
            this.checktableBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "pharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checktableTableAdapter1
            // 
            this.checktableTableAdapter1.ClearBeforeFill = true;
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "pharmacyDataSet";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checktableTableAdapter
            // 
            this.checktableTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "Чек покупця";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checktableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private pharmacyDataSetTableAdapters.checktableTableAdapter checktableTableAdapter1;
        private pharmacyDataSet pharmacyDataSet1;
        private System.Windows.Forms.BindingSource checktableBindingSource;
        private pharmacyDataSet pharmacyDataSet;
        private pharmacyDataSetTableAdapters.checktableTableAdapter checktableTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}