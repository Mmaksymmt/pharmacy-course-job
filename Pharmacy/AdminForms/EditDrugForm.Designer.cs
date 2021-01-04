
namespace Pharmacy.AdminForms
{
    partial class EditDrugForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.formTextBox = new System.Windows.Forms.TextBox();
            this.formLabel = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.shelfLifeTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.shelfLifeLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.prescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.substGridView = new System.Windows.Forms.DataGridView();
            this.addSubstButton = new System.Windows.Forms.Button();
            this.removeSubstButton = new System.Windows.Forms.Button();
            this.pharmacyDataSet1 = new Pharmacy.pharmacyDataSet();
            this.drugsTableAdapter1 = new Pharmacy.pharmacyDataSetTableAdapters.drugsTableAdapter();
            this.substancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugcategoriesTableAdapter1 = new Pharmacy.pharmacyDataSetTableAdapters.drugcategoriesTableAdapter();
            this.substAmountLabel = new System.Windows.Forms.Label();
            this.substAmountTextBox = new System.Windows.Forms.TextBox();
            this.saveAmountString = new System.Windows.Forms.Button();
            this.cancelChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(73, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID препарату";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Назва:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(131, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // formTextBox
            // 
            this.formTextBox.Location = new System.Drawing.Point(131, 74);
            this.formTextBox.Name = "formTextBox";
            this.formTextBox.Size = new System.Drawing.Size(100, 20);
            this.formTextBox.TabIndex = 4;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(12, 74);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(87, 13);
            this.formLabel.TabIndex = 3;
            this.formLabel.Text = "Форма випуску";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(131, 109);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTextBox.TabIndex = 6;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(12, 109);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(59, 13);
            this.manufacturerLabel.TabIndex = 5;
            this.manufacturerLabel.Text = "Виробник:";
            // 
            // shelfLifeTextBox
            // 
            this.shelfLifeTextBox.Location = new System.Drawing.Point(131, 171);
            this.shelfLifeTextBox.Name = "shelfLifeTextBox";
            this.shelfLifeTextBox.Size = new System.Drawing.Size(100, 20);
            this.shelfLifeTextBox.TabIndex = 8;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 147);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(59, 13);
            this.categoryLabel.TabIndex = 7;
            this.categoryLabel.Text = "Категорія:";
            // 
            // shelfLifeLabel
            // 
            this.shelfLifeLabel.AutoSize = true;
            this.shelfLifeLabel.Location = new System.Drawing.Point(12, 174);
            this.shelfLifeLabel.Name = "shelfLifeLabel";
            this.shelfLifeLabel.Size = new System.Drawing.Size(108, 13);
            this.shelfLifeLabel.TabIndex = 9;
            this.shelfLifeLabel.Text = "Термін придатності:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(131, 144);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 241);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(32, 13);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Ціна:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(12, 269);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(59, 13);
            this.amountLabel.TabIndex = 13;
            this.amountLabel.Text = "На складі:";
            // 
            // prescriptionCheckBox
            // 
            this.prescriptionCheckBox.AutoSize = true;
            this.prescriptionCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prescriptionCheckBox.Location = new System.Drawing.Point(15, 209);
            this.prescriptionCheckBox.Name = "prescriptionCheckBox";
            this.prescriptionCheckBox.Size = new System.Drawing.Size(91, 17);
            this.prescriptionCheckBox.TabIndex = 14;
            this.prescriptionCheckBox.Text = "За рецептом";
            this.prescriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceUpDown
            // 
            this.priceUpDown.DecimalPlaces = 2;
            this.priceUpDown.Location = new System.Drawing.Point(132, 234);
            this.priceUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.Size = new System.Drawing.Size(120, 20);
            this.priceUpDown.TabIndex = 15;
            // 
            // amountUpDown
            // 
            this.amountUpDown.Location = new System.Drawing.Point(132, 262);
            this.amountUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountUpDown.TabIndex = 16;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(92, 337);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesButton.TabIndex = 17;
            this.saveChangesButton.Text = "Зберегти";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // substGridView
            // 
            this.substGridView.AllowUserToAddRows = false;
            this.substGridView.AllowUserToDeleteRows = false;
            this.substGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.substGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.substGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.substGridView.Location = new System.Drawing.Point(320, 37);
            this.substGridView.Name = "substGridView";
            this.substGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.substGridView.Size = new System.Drawing.Size(458, 323);
            this.substGridView.TabIndex = 18;
            this.substGridView.SelectionChanged += new System.EventHandler(this.SubstGridView_SelectionChanged);
            // 
            // addSubstButton
            // 
            this.addSubstButton.Location = new System.Drawing.Point(398, 415);
            this.addSubstButton.Name = "addSubstButton";
            this.addSubstButton.Size = new System.Drawing.Size(75, 23);
            this.addSubstButton.TabIndex = 19;
            this.addSubstButton.Text = "Додати";
            this.addSubstButton.UseVisualStyleBackColor = true;
            this.addSubstButton.Click += new System.EventHandler(this.AddSubstButton_Click);
            // 
            // removeSubstButton
            // 
            this.removeSubstButton.Location = new System.Drawing.Point(649, 415);
            this.removeSubstButton.Name = "removeSubstButton";
            this.removeSubstButton.Size = new System.Drawing.Size(75, 23);
            this.removeSubstButton.TabIndex = 20;
            this.removeSubstButton.Text = "Видалити";
            this.removeSubstButton.UseVisualStyleBackColor = true;
            this.removeSubstButton.Click += new System.EventHandler(this.RemoveSubstButton_Click);
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "pharmacyDataSet";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugsTableAdapter1
            // 
            this.drugsTableAdapter1.ClearBeforeFill = true;
            // 
            // substancesBindingSource
            // 
            this.substancesBindingSource.DataMember = "drugssubstances";
            this.substancesBindingSource.DataSource = this.pharmacyDataSet1;
            // 
            // drugcategoriesTableAdapter1
            // 
            this.drugcategoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // substAmountLabel
            // 
            this.substAmountLabel.AutoSize = true;
            this.substAmountLabel.Location = new System.Drawing.Point(399, 378);
            this.substAmountLabel.Name = "substAmountLabel";
            this.substAmountLabel.Size = new System.Drawing.Size(106, 13);
            this.substAmountLabel.TabIndex = 21;
            this.substAmountLabel.Text = "Кількість речовини:";
            // 
            // substAmountTextBox
            // 
            this.substAmountTextBox.Location = new System.Drawing.Point(511, 375);
            this.substAmountTextBox.Name = "substAmountTextBox";
            this.substAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.substAmountTextBox.TabIndex = 22;
            // 
            // saveAmountString
            // 
            this.saveAmountString.Location = new System.Drawing.Point(617, 373);
            this.saveAmountString.Name = "saveAmountString";
            this.saveAmountString.Size = new System.Drawing.Size(36, 23);
            this.saveAmountString.TabIndex = 23;
            this.saveAmountString.Text = "ОК";
            this.saveAmountString.UseVisualStyleBackColor = true;
            this.saveAmountString.Click += new System.EventHandler(this.SaveAmountString_Click);
            // 
            // cancelChangesButton
            // 
            this.cancelChangesButton.Location = new System.Drawing.Point(177, 337);
            this.cancelChangesButton.Name = "cancelChangesButton";
            this.cancelChangesButton.Size = new System.Drawing.Size(75, 23);
            this.cancelChangesButton.TabIndex = 24;
            this.cancelChangesButton.Text = "Відмінити";
            this.cancelChangesButton.UseVisualStyleBackColor = true;
            this.cancelChangesButton.Click += new System.EventHandler(this.CancelChangesButton_Click);
            // 
            // EditDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.cancelChangesButton);
            this.Controls.Add(this.saveAmountString);
            this.Controls.Add(this.substAmountTextBox);
            this.Controls.Add(this.substAmountLabel);
            this.Controls.Add(this.removeSubstButton);
            this.Controls.Add(this.addSubstButton);
            this.Controls.Add(this.substGridView);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.amountUpDown);
            this.Controls.Add(this.priceUpDown);
            this.Controls.Add(this.prescriptionCheckBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.shelfLifeLabel);
            this.Controls.Add(this.shelfLifeTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.formTextBox);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "EditDrugForm";
            this.Text = "EditDrugForm";
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox formTextBox;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.TextBox shelfLifeTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label shelfLifeLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.CheckBox prescriptionCheckBox;
        private System.Windows.Forms.NumericUpDown priceUpDown;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private pharmacyDataSet pharmacyDataSet1;
        private pharmacyDataSetTableAdapters.drugsTableAdapter drugsTableAdapter1;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.DataGridView substGridView;
        private System.Windows.Forms.BindingSource substancesBindingSource;
        private pharmacyDataSetTableAdapters.drugcategoriesTableAdapter drugcategoriesTableAdapter1;
        private System.Windows.Forms.Button addSubstButton;
        private System.Windows.Forms.Button removeSubstButton;
        private System.Windows.Forms.Label substAmountLabel;
        private System.Windows.Forms.TextBox substAmountTextBox;
        private System.Windows.Forms.Button saveAmountString;
        private System.Windows.Forms.Button cancelChangesButton;
    }
}