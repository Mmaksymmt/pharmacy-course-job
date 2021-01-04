
namespace Pharmacy.AdminForms
{
    partial class AddSubstanceToDrugForm
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
            this.pharmacyDataSet1 = new Pharmacy.pharmacyDataSet();
            this.substancesTableAdapter1 = new Pharmacy.pharmacyDataSetTableAdapters.substancesTableAdapter();
            this.substBindingSouce = new System.Windows.Forms.BindingSource(this.components);
            this.substGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.substidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.substnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.substdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substBindingSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "pharmacyDataSet";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // substancesTableAdapter1
            // 
            this.substancesTableAdapter1.ClearBeforeFill = true;
            // 
            // substBindingSouce
            // 
            this.substBindingSouce.DataMember = "substances";
            this.substBindingSouce.DataSource = this.pharmacyDataSet1;
            // 
            // substGridView
            // 
            this.substGridView.AllowUserToAddRows = false;
            this.substGridView.AllowUserToDeleteRows = false;
            this.substGridView.AutoGenerateColumns = false;
            this.substGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.substGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.substGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.substidDataGridViewTextBoxColumn,
            this.substnameDataGridViewTextBoxColumn,
            this.substdescriptionDataGridViewTextBoxColumn});
            this.substGridView.DataSource = this.substBindingSouce;
            this.substGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.substGridView.Location = new System.Drawing.Point(25, 12);
            this.substGridView.MultiSelect = false;
            this.substGridView.Name = "substGridView";
            this.substGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.substGridView.Size = new System.Drawing.Size(494, 323);
            this.substGridView.TabIndex = 19;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(115, 341);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(330, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // substidDataGridViewTextBoxColumn
            // 
            this.substidDataGridViewTextBoxColumn.DataPropertyName = "subst_id";
            this.substidDataGridViewTextBoxColumn.HeaderText = "ID речовини";
            this.substidDataGridViewTextBoxColumn.Name = "substidDataGridViewTextBoxColumn";
            // 
            // substnameDataGridViewTextBoxColumn
            // 
            this.substnameDataGridViewTextBoxColumn.DataPropertyName = "subst_name";
            this.substnameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.substnameDataGridViewTextBoxColumn.Name = "substnameDataGridViewTextBoxColumn";
            // 
            // substdescriptionDataGridViewTextBoxColumn
            // 
            this.substdescriptionDataGridViewTextBoxColumn.DataPropertyName = "subst_description";
            this.substdescriptionDataGridViewTextBoxColumn.HeaderText = "Опис";
            this.substdescriptionDataGridViewTextBoxColumn.Name = "substdescriptionDataGridViewTextBoxColumn";
            // 
            // AddSubstanceToDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 373);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.substGridView);
            this.Name = "AddSubstanceToDrugForm";
            this.Text = "Додавання речовини до ліків";
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substBindingSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private pharmacyDataSet pharmacyDataSet1;
        private pharmacyDataSetTableAdapters.substancesTableAdapter substancesTableAdapter1;
        private System.Windows.Forms.BindingSource substBindingSouce;
        private System.Windows.Forms.DataGridView substGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn substidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn substnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn substdescriptionDataGridViewTextBoxColumn;
    }
}