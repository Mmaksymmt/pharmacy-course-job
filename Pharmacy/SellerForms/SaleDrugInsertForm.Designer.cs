namespace Pharmacy
{
    partial class SaleDrugInsertForm
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
            this.nameFilterLabel = new System.Windows.Forms.Label();
            this.categoryFilterLabel = new System.Windows.Forms.Label();
            this.categoryFilterComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inStockValueLabel = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.drugsGridView = new System.Windows.Forms.DataGridView();
            this.drugsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterButton = new System.Windows.Forms.Button();
            this.nameFilterTextBox = new System.Windows.Forms.TextBox();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.substLabel = new System.Windows.Forms.Label();
            this.substTextBox = new System.Windows.Forms.TextBox();
            this.leftInStockFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.prescriptionFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.maxPriceFilterTextBox = new System.Windows.Forms.TextBox();
            this.minPriceFilterTextBox = new System.Windows.Forms.TextBox();
            this.priceFilterLabel = new System.Windows.Forms.Label();
            this.manufFilterLabel = new System.Windows.Forms.Label();
            this.manufFilterTextBox = new System.Windows.Forms.TextBox();
            this.paramsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.descendingCheckBox = new System.Windows.Forms.CheckBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchString = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.substancesGridView = new System.Windows.Forms.DataGridView();
            this.substTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsTableBindingSource)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            this.paramsGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.substancesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFilterLabel
            // 
            this.nameFilterLabel.AutoSize = true;
            this.nameFilterLabel.Location = new System.Drawing.Point(14, 39);
            this.nameFilterLabel.Name = "nameFilterLabel";
            this.nameFilterLabel.Size = new System.Drawing.Size(64, 13);
            this.nameFilterLabel.TabIndex = 0;
            this.nameFilterLabel.Text = "Назва ліків";
            // 
            // categoryFilterLabel
            // 
            this.categoryFilterLabel.AutoSize = true;
            this.categoryFilterLabel.Location = new System.Drawing.Point(14, 65);
            this.categoryFilterLabel.Name = "categoryFilterLabel";
            this.categoryFilterLabel.Size = new System.Drawing.Size(56, 13);
            this.categoryFilterLabel.TabIndex = 2;
            this.categoryFilterLabel.Text = "Категорія";
            // 
            // categoryFilterComboBox
            // 
            this.categoryFilterComboBox.FormattingEnabled = true;
            this.categoryFilterComboBox.Location = new System.Drawing.Point(88, 62);
            this.categoryFilterComboBox.Name = "categoryFilterComboBox";
            this.categoryFilterComboBox.Size = new System.Drawing.Size(230, 21);
            this.categoryFilterComboBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(31, 31);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(29, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Ціна";
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceValueLabel.Location = new System.Drawing.Point(118, 26);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(125, 20);
            this.priceValueLabel.TabIndex = 5;
            this.priceValueLabel.Text = "amount * price";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(31, 76);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(53, 13);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Кількість";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(122, 74);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountNumericUpDown.TabIndex = 7;
            this.amountNumericUpDown.ValueChanged += new System.EventHandler(this.AmountNumericUpDown_ValueChanged);
            // 
            // inStockValueLabel
            // 
            this.inStockValueLabel.AutoSize = true;
            this.inStockValueLabel.Location = new System.Drawing.Point(265, 76);
            this.inStockValueLabel.Name = "inStockValueLabel";
            this.inStockValueLabel.Size = new System.Drawing.Size(53, 13);
            this.inStockValueLabel.TabIndex = 8;
            this.inStockValueLabel.Text = "Кількість";
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Location = new System.Drawing.Point(248, 76);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(12, 13);
            this.slashLabel.TabIndex = 9;
            this.slashLabel.Text = "/";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(49, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Додати";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(204, 8);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // drugsGridView
            // 
            this.drugsGridView.AllowUserToAddRows = false;
            this.drugsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drugsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drugsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.drugsGridView.Location = new System.Drawing.Point(351, 43);
            this.drugsGridView.MultiSelect = false;
            this.drugsGridView.Name = "drugsGridView";
            this.drugsGridView.ReadOnly = true;
            this.drugsGridView.RowHeadersVisible = false;
            this.drugsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drugsGridView.Size = new System.Drawing.Size(830, 338);
            this.drugsGridView.TabIndex = 12;
            this.drugsGridView.SelectionChanged += new System.EventHandler(this.DrugsGridView_SelectionChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(121, 196);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(84, 23);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Фільтрувати";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // nameFilterTextBox
            // 
            this.nameFilterTextBox.Location = new System.Drawing.Point(88, 36);
            this.nameFilterTextBox.Name = "nameFilterTextBox";
            this.nameFilterTextBox.Size = new System.Drawing.Size(230, 20);
            this.nameFilterTextBox.TabIndex = 14;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.substLabel);
            this.filterGroupBox.Controls.Add(this.substTextBox);
            this.filterGroupBox.Controls.Add(this.leftInStockFilterCheckBox);
            this.filterGroupBox.Controls.Add(this.prescriptionFilterCheckBox);
            this.filterGroupBox.Controls.Add(this.maxPriceFilterTextBox);
            this.filterGroupBox.Controls.Add(this.minPriceFilterTextBox);
            this.filterGroupBox.Controls.Add(this.priceFilterLabel);
            this.filterGroupBox.Controls.Add(this.manufFilterLabel);
            this.filterGroupBox.Controls.Add(this.nameFilterLabel);
            this.filterGroupBox.Controls.Add(this.manufFilterTextBox);
            this.filterGroupBox.Controls.Add(this.filterButton);
            this.filterGroupBox.Controls.Add(this.nameFilterTextBox);
            this.filterGroupBox.Controls.Add(this.categoryFilterLabel);
            this.filterGroupBox.Controls.Add(this.categoryFilterComboBox);
            this.filterGroupBox.Location = new System.Drawing.Point(3, 3);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(335, 225);
            this.filterGroupBox.TabIndex = 15;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтрація";
            // 
            // substLabel
            // 
            this.substLabel.AutoSize = true;
            this.substLabel.Location = new System.Drawing.Point(14, 146);
            this.substLabel.Name = "substLabel";
            this.substLabel.Size = new System.Drawing.Size(55, 13);
            this.substLabel.TabIndex = 26;
            this.substLabel.Text = "Речовина";
            // 
            // substTextBox
            // 
            this.substTextBox.Location = new System.Drawing.Point(88, 143);
            this.substTextBox.Name = "substTextBox";
            this.substTextBox.Size = new System.Drawing.Size(230, 20);
            this.substTextBox.TabIndex = 27;
            // 
            // leftInStockFilterCheckBox
            // 
            this.leftInStockFilterCheckBox.AutoSize = true;
            this.leftInStockFilterCheckBox.Location = new System.Drawing.Point(169, 167);
            this.leftInStockFilterCheckBox.Name = "leftInStockFilterCheckBox";
            this.leftInStockFilterCheckBox.Size = new System.Drawing.Size(83, 17);
            this.leftInStockFilterCheckBox.TabIndex = 25;
            this.leftInStockFilterCheckBox.Text = "Є на складі";
            this.leftInStockFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // prescriptionFilterCheckBox
            // 
            this.prescriptionFilterCheckBox.AutoSize = true;
            this.prescriptionFilterCheckBox.Location = new System.Drawing.Point(17, 169);
            this.prescriptionFilterCheckBox.Name = "prescriptionFilterCheckBox";
            this.prescriptionFilterCheckBox.Size = new System.Drawing.Size(124, 17);
            this.prescriptionFilterCheckBox.TabIndex = 24;
            this.prescriptionFilterCheckBox.Text = "Тільки без рецепта";
            this.prescriptionFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxPriceFilterTextBox
            // 
            this.maxPriceFilterTextBox.Location = new System.Drawing.Point(218, 117);
            this.maxPriceFilterTextBox.Name = "maxPriceFilterTextBox";
            this.maxPriceFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxPriceFilterTextBox.TabIndex = 23;
            // 
            // minPriceFilterTextBox
            // 
            this.minPriceFilterTextBox.Location = new System.Drawing.Point(88, 117);
            this.minPriceFilterTextBox.Name = "minPriceFilterTextBox";
            this.minPriceFilterTextBox.Size = new System.Drawing.Size(97, 20);
            this.minPriceFilterTextBox.TabIndex = 22;
            // 
            // priceFilterLabel
            // 
            this.priceFilterLabel.AutoSize = true;
            this.priceFilterLabel.Location = new System.Drawing.Point(14, 120);
            this.priceFilterLabel.Name = "priceFilterLabel";
            this.priceFilterLabel.Size = new System.Drawing.Size(29, 13);
            this.priceFilterLabel.TabIndex = 21;
            this.priceFilterLabel.Text = "Ціна";
            // 
            // manufFilterLabel
            // 
            this.manufFilterLabel.AutoSize = true;
            this.manufFilterLabel.Location = new System.Drawing.Point(14, 92);
            this.manufFilterLabel.Name = "manufFilterLabel";
            this.manufFilterLabel.Size = new System.Drawing.Size(56, 13);
            this.manufFilterLabel.TabIndex = 20;
            this.manufFilterLabel.Text = "Виробник";
            // 
            // manufFilterTextBox
            // 
            this.manufFilterTextBox.Location = new System.Drawing.Point(88, 89);
            this.manufFilterTextBox.Name = "manufFilterTextBox";
            this.manufFilterTextBox.Size = new System.Drawing.Size(230, 20);
            this.manufFilterTextBox.TabIndex = 21;
            // 
            // paramsGroupBox
            // 
            this.paramsGroupBox.Controls.Add(this.amountNumericUpDown);
            this.paramsGroupBox.Controls.Add(this.priceLabel);
            this.paramsGroupBox.Controls.Add(this.priceValueLabel);
            this.paramsGroupBox.Controls.Add(this.amountLabel);
            this.paramsGroupBox.Controls.Add(this.inStockValueLabel);
            this.paramsGroupBox.Controls.Add(this.slashLabel);
            this.paramsGroupBox.Location = new System.Drawing.Point(3, 332);
            this.paramsGroupBox.Name = "paramsGroupBox";
            this.paramsGroupBox.Size = new System.Drawing.Size(335, 100);
            this.paramsGroupBox.TabIndex = 16;
            this.paramsGroupBox.TabStop = false;
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(3, 0);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(93, 13);
            this.orderByLabel.TabIndex = 17;
            this.orderByLabel.Text = "Впорядкувати за";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Location = new System.Drawing.Point(102, 3);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderByComboBox.TabIndex = 18;
            this.orderByComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderByComboBox_SelectedIndexChanged);
            // 
            // descendingCheckBox
            // 
            this.descendingCheckBox.AutoSize = true;
            this.descendingCheckBox.Location = new System.Drawing.Point(229, 3);
            this.descendingCheckBox.Name = "descendingCheckBox";
            this.descendingCheckBox.Size = new System.Drawing.Size(152, 17);
            this.descendingCheckBox.TabIndex = 19;
            this.descendingCheckBox.Text = "Від більшого до меншого";
            this.descendingCheckBox.UseVisualStyleBackColor = true;
            this.descendingCheckBox.CheckedChanged += new System.EventHandler(this.DescendingCheckBox_CheckedChanged);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchString);
            this.searchGroupBox.Location = new System.Drawing.Point(3, 234);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(334, 92);
            this.searchGroupBox.TabIndex = 20;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Пошук";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(121, 57);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Шукати";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchString
            // 
            this.searchString.Location = new System.Drawing.Point(17, 19);
            this.searchString.Name = "searchString";
            this.searchString.Size = new System.Drawing.Size(301, 20);
            this.searchString.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.drugsGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.substancesGridView, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.18996F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.81004F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 594);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.filterGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.searchGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.paramsGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(342, 588);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Location = new System.Drawing.Point(3, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 40);
            this.panel1.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.orderByLabel);
            this.flowLayoutPanel2.Controls.Add(this.orderByComboBox);
            this.flowLayoutPanel2.Controls.Add(this.descendingCheckBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(351, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(830, 34);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // substancesGridView
            // 
            this.substancesGridView.AllowUserToAddRows = false;
            this.substancesGridView.AllowUserToDeleteRows = false;
            this.substancesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.substancesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.substancesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.substancesGridView.Location = new System.Drawing.Point(351, 387);
            this.substancesGridView.MultiSelect = false;
            this.substancesGridView.Name = "substancesGridView";
            this.substancesGridView.ReadOnly = true;
            this.substancesGridView.RowHeadersVisible = false;
            this.substancesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.substancesGridView.Size = new System.Drawing.Size(830, 204);
            this.substancesGridView.TabIndex = 18;
            // 
            // SaleDrugInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SaleDrugInsertForm";
            this.Text = "SaleDrugEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsTableBindingSource)).EndInit();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.paramsGroupBox.ResumeLayout(false);
            this.paramsGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.substancesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameFilterLabel;
        private System.Windows.Forms.Label categoryFilterLabel;
        private System.Windows.Forms.ComboBox categoryFilterComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label priceValueLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Label inStockValueLabel;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView drugsGridView;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox nameFilterTextBox;
        private System.Windows.Forms.BindingSource drugsTableBindingSource;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.GroupBox paramsGroupBox;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.CheckBox descendingCheckBox;
        private System.Windows.Forms.Label manufFilterLabel;
        private System.Windows.Forms.TextBox manufFilterTextBox;
        private System.Windows.Forms.TextBox maxPriceFilterTextBox;
        private System.Windows.Forms.TextBox minPriceFilterTextBox;
        private System.Windows.Forms.Label priceFilterLabel;
        private System.Windows.Forms.CheckBox prescriptionFilterCheckBox;
        private System.Windows.Forms.CheckBox leftInStockFilterCheckBox;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView substancesGridView;
        private System.Windows.Forms.Label substLabel;
        private System.Windows.Forms.TextBox substTextBox;
        private System.Windows.Forms.BindingSource substTableBindingSource;
    }
}