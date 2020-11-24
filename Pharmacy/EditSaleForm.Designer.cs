namespace Pharmacy
{
    partial class EditSaleForm
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
            this.salesDrugsGridView = new System.Windows.Forms.DataGridView();
            this.salesdrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.salesDrugsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesdrugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDrugsGridView
            // 
            this.salesDrugsGridView.AllowUserToAddRows = false;
            this.salesDrugsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDrugsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesDrugsGridView.Location = new System.Drawing.Point(12, 38);
            this.salesDrugsGridView.Name = "salesDrugsGridView";
            this.salesDrugsGridView.ReadOnly = true;
            this.salesDrugsGridView.RowHeadersVisible = false;
            this.salesDrugsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDrugsGridView.Size = new System.Drawing.Size(776, 317);
            this.salesDrugsGridView.TabIndex = 0;
            this.salesDrugsGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.SalesDrugsGridView_UserDeletedRow);
            // 
            // EditSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salesDrugsGridView);
            this.Name = "EditSaleForm";
            this.Text = "Редагування продажі";
            ((System.ComponentModel.ISupportInitialize)(this.salesDrugsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesdrugsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView salesDrugsGridView;
        private System.Windows.Forms.BindingSource salesdrugsBindingSource;
    }
}