
namespace Pharmacy.AdminForms
{
    partial class SellersForm
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
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet1 = new Pharmacy.pharmacyDataSet();
            this.deleteSellerButton = new System.Windows.Forms.Button();
            this.addSellerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editSellerButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchString = new System.Windows.Forms.TextBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.patronFilterLabel = new System.Windows.Forms.Label();
            this.jobFilterComboBox = new System.Windows.Forms.ComboBox();
            this.jobFilterLabel = new System.Windows.Forms.Label();
            this.patronFilterTextBox = new System.Windows.Forms.TextBox();
            this.dismissdateFilterCheckbox = new System.Windows.Forms.CheckBox();
            this.dismissMaxPicker = new System.Windows.Forms.DateTimePicker();
            this.dismissMinPicker = new System.Windows.Forms.DateTimePicker();
            this.hiredateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.hiredateMaxPicker = new System.Windows.Forms.DateTimePicker();
            this.hiredateMinPicker = new System.Windows.Forms.DateTimePicker();
            this.birthdateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.birthdateMaxPicker = new System.Windows.Forms.DateTimePicker();
            this.birthdateMinPicker = new System.Windows.Forms.DateTimePicker();
            this.genderFilterComboBox = new System.Windows.Forms.ComboBox();
            this.genderFilterLabel = new System.Windows.Forms.Label();
            this.surnameFilterLabel = new System.Windows.Forms.Label();
            this.surnameFilterTextBox = new System.Windows.Forms.TextBox();
            this.nameFilterLabel = new System.Windows.Forms.Label();
            this.nameFilterTextBox = new System.Windows.Forms.TextBox();
            this.idFilterLabel = new System.Windows.Forms.Label();
            this.idFilterTextBox = new System.Windows.Forms.TextBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.descendingCheckBox = new System.Windows.Forms.CheckBox();
            this.sellersGridView = new System.Windows.Forms.DataGridView();
            this.selleridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellersurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerpatronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellergenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerhiringdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selleradminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sellerdismissaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sellersTableAdapter1 = new Pharmacy.pharmacyDataSetTableAdapters.sellersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellersGridView)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "sellers";
            this.sellersBindingSource.DataSource = this.pharmacyDataSet1;
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "pharmacyDataSet";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteSellerButton
            // 
            this.deleteSellerButton.Location = new System.Drawing.Point(235, 13);
            this.deleteSellerButton.Name = "deleteSellerButton";
            this.deleteSellerButton.Size = new System.Drawing.Size(96, 35);
            this.deleteSellerButton.TabIndex = 28;
            this.deleteSellerButton.Text = "Видалити працівника";
            this.deleteSellerButton.UseVisualStyleBackColor = true;
            this.deleteSellerButton.Click += new System.EventHandler(this.DeleteSellerButton_Click);
            // 
            // addSellerButton
            // 
            this.addSellerButton.Location = new System.Drawing.Point(3, 13);
            this.addSellerButton.Name = "addSellerButton";
            this.addSellerButton.Size = new System.Drawing.Size(96, 35);
            this.addSellerButton.TabIndex = 27;
            this.addSellerButton.Text = "Додати працівника";
            this.addSellerButton.UseVisualStyleBackColor = true;
            this.addSellerButton.Click += new System.EventHandler(this.AddSellerButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteSellerButton);
            this.panel1.Controls.Add(this.addSellerButton);
            this.panel1.Controls.Add(this.editSellerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 100);
            this.panel1.TabIndex = 24;
            // 
            // editSellerButton
            // 
            this.editSellerButton.Location = new System.Drawing.Point(119, 13);
            this.editSellerButton.Name = "editSellerButton";
            this.editSellerButton.Size = new System.Drawing.Size(96, 35);
            this.editSellerButton.TabIndex = 26;
            this.editSellerButton.Text = "Редагувати працівника";
            this.editSellerButton.UseVisualStyleBackColor = true;
            this.editSellerButton.Click += new System.EventHandler(this.EditSellerButton_Click);
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
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchString);
            this.searchGroupBox.Location = new System.Drawing.Point(3, 325);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(334, 92);
            this.searchGroupBox.TabIndex = 23;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Пошук";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(121, 278);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(84, 23);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Фільтрувати";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.filterGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.searchGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 545);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.patronFilterLabel);
            this.filterGroupBox.Controls.Add(this.jobFilterComboBox);
            this.filterGroupBox.Controls.Add(this.jobFilterLabel);
            this.filterGroupBox.Controls.Add(this.patronFilterTextBox);
            this.filterGroupBox.Controls.Add(this.dismissdateFilterCheckbox);
            this.filterGroupBox.Controls.Add(this.dismissMaxPicker);
            this.filterGroupBox.Controls.Add(this.dismissMinPicker);
            this.filterGroupBox.Controls.Add(this.hiredateFilterCheckBox);
            this.filterGroupBox.Controls.Add(this.hiredateMaxPicker);
            this.filterGroupBox.Controls.Add(this.hiredateMinPicker);
            this.filterGroupBox.Controls.Add(this.birthdateFilterCheckBox);
            this.filterGroupBox.Controls.Add(this.birthdateMaxPicker);
            this.filterGroupBox.Controls.Add(this.birthdateMinPicker);
            this.filterGroupBox.Controls.Add(this.genderFilterComboBox);
            this.filterGroupBox.Controls.Add(this.genderFilterLabel);
            this.filterGroupBox.Controls.Add(this.surnameFilterLabel);
            this.filterGroupBox.Controls.Add(this.surnameFilterTextBox);
            this.filterGroupBox.Controls.Add(this.nameFilterLabel);
            this.filterGroupBox.Controls.Add(this.nameFilterTextBox);
            this.filterGroupBox.Controls.Add(this.idFilterLabel);
            this.filterGroupBox.Controls.Add(this.idFilterTextBox);
            this.filterGroupBox.Controls.Add(this.filterButton);
            this.filterGroupBox.Location = new System.Drawing.Point(3, 3);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(335, 316);
            this.filterGroupBox.TabIndex = 22;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтрація";
            // 
            // patronFilterLabel
            // 
            this.patronFilterLabel.AutoSize = true;
            this.patronFilterLabel.Location = new System.Drawing.Point(14, 106);
            this.patronFilterLabel.Name = "patronFilterLabel";
            this.patronFilterLabel.Size = new System.Drawing.Size(67, 13);
            this.patronFilterLabel.TabIndex = 35;
            this.patronFilterLabel.Text = "По-батькові";
            // 
            // jobFilterComboBox
            // 
            this.jobFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobFilterComboBox.FormattingEnabled = true;
            this.jobFilterComboBox.Items.AddRange(new object[] {
            "-",
            "Адміністратор",
            "Продавець"});
            this.jobFilterComboBox.Location = new System.Drawing.Point(88, 237);
            this.jobFilterComboBox.Name = "jobFilterComboBox";
            this.jobFilterComboBox.Size = new System.Drawing.Size(91, 21);
            this.jobFilterComboBox.TabIndex = 34;
            // 
            // jobFilterLabel
            // 
            this.jobFilterLabel.AutoSize = true;
            this.jobFilterLabel.Location = new System.Drawing.Point(14, 240);
            this.jobFilterLabel.Name = "jobFilterLabel";
            this.jobFilterLabel.Size = new System.Drawing.Size(45, 13);
            this.jobFilterLabel.TabIndex = 33;
            this.jobFilterLabel.Text = "Посада";
            // 
            // patronFilterTextBox
            // 
            this.patronFilterTextBox.Location = new System.Drawing.Point(88, 103);
            this.patronFilterTextBox.Name = "patronFilterTextBox";
            this.patronFilterTextBox.Size = new System.Drawing.Size(230, 20);
            this.patronFilterTextBox.TabIndex = 36;
            // 
            // dismissdateFilterCheckbox
            // 
            this.dismissdateFilterCheckbox.AutoSize = true;
            this.dismissdateFilterCheckbox.Location = new System.Drawing.Point(6, 211);
            this.dismissdateFilterCheckbox.Name = "dismissdateFilterCheckbox";
            this.dismissdateFilterCheckbox.Size = new System.Drawing.Size(59, 17);
            this.dismissdateFilterCheckbox.TabIndex = 32;
            this.dismissdateFilterCheckbox.Text = "Звільн";
            this.dismissdateFilterCheckbox.UseVisualStyleBackColor = true;
            this.dismissdateFilterCheckbox.CheckedChanged += new System.EventHandler(this.DismissdateFilterCheckbox_CheckedChanged);
            // 
            // dismissMaxPicker
            // 
            this.dismissMaxPicker.Enabled = false;
            this.dismissMaxPicker.Location = new System.Drawing.Point(209, 211);
            this.dismissMaxPicker.Name = "dismissMaxPicker";
            this.dismissMaxPicker.Size = new System.Drawing.Size(109, 20);
            this.dismissMaxPicker.TabIndex = 31;
            // 
            // dismissMinPicker
            // 
            this.dismissMinPicker.Enabled = false;
            this.dismissMinPicker.Location = new System.Drawing.Point(88, 211);
            this.dismissMinPicker.Name = "dismissMinPicker";
            this.dismissMinPicker.Size = new System.Drawing.Size(109, 20);
            this.dismissMinPicker.TabIndex = 30;
            // 
            // hiredateFilterCheckBox
            // 
            this.hiredateFilterCheckBox.AutoSize = true;
            this.hiredateFilterCheckBox.Location = new System.Drawing.Point(6, 185);
            this.hiredateFilterCheckBox.Name = "hiredateFilterCheckBox";
            this.hiredateFilterCheckBox.Size = new System.Drawing.Size(54, 17);
            this.hiredateFilterCheckBox.TabIndex = 29;
            this.hiredateFilterCheckBox.Text = "Найм";
            this.hiredateFilterCheckBox.UseVisualStyleBackColor = true;
            this.hiredateFilterCheckBox.CheckedChanged += new System.EventHandler(this.HiredateFilterCheckBox_CheckedChanged);
            // 
            // hiredateMaxPicker
            // 
            this.hiredateMaxPicker.Enabled = false;
            this.hiredateMaxPicker.Location = new System.Drawing.Point(209, 185);
            this.hiredateMaxPicker.Name = "hiredateMaxPicker";
            this.hiredateMaxPicker.Size = new System.Drawing.Size(109, 20);
            this.hiredateMaxPicker.TabIndex = 28;
            // 
            // hiredateMinPicker
            // 
            this.hiredateMinPicker.Enabled = false;
            this.hiredateMinPicker.Location = new System.Drawing.Point(88, 185);
            this.hiredateMinPicker.Name = "hiredateMinPicker";
            this.hiredateMinPicker.Size = new System.Drawing.Size(109, 20);
            this.hiredateMinPicker.TabIndex = 27;
            // 
            // birthdateFilterCheckBox
            // 
            this.birthdateFilterCheckBox.AutoSize = true;
            this.birthdateFilterCheckBox.Location = new System.Drawing.Point(6, 159);
            this.birthdateFilterCheckBox.Name = "birthdateFilterCheckBox";
            this.birthdateFilterCheckBox.Size = new System.Drawing.Size(69, 17);
            this.birthdateFilterCheckBox.TabIndex = 26;
            this.birthdateFilterCheckBox.Text = "Народж.";
            this.birthdateFilterCheckBox.UseVisualStyleBackColor = true;
            this.birthdateFilterCheckBox.CheckedChanged += new System.EventHandler(this.BirthdateFilterCheckBox_CheckedChanged);
            // 
            // birthdateMaxPicker
            // 
            this.birthdateMaxPicker.Enabled = false;
            this.birthdateMaxPicker.Location = new System.Drawing.Point(209, 159);
            this.birthdateMaxPicker.Name = "birthdateMaxPicker";
            this.birthdateMaxPicker.Size = new System.Drawing.Size(109, 20);
            this.birthdateMaxPicker.TabIndex = 25;
            // 
            // birthdateMinPicker
            // 
            this.birthdateMinPicker.Enabled = false;
            this.birthdateMinPicker.Location = new System.Drawing.Point(88, 159);
            this.birthdateMinPicker.Name = "birthdateMinPicker";
            this.birthdateMinPicker.Size = new System.Drawing.Size(109, 20);
            this.birthdateMinPicker.TabIndex = 24;
            // 
            // genderFilterComboBox
            // 
            this.genderFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderFilterComboBox.FormattingEnabled = true;
            this.genderFilterComboBox.Items.AddRange(new object[] {
            "-",
            "Ч",
            "Ж"});
            this.genderFilterComboBox.Location = new System.Drawing.Point(88, 129);
            this.genderFilterComboBox.Name = "genderFilterComboBox";
            this.genderFilterComboBox.Size = new System.Drawing.Size(91, 21);
            this.genderFilterComboBox.TabIndex = 22;
            // 
            // genderFilterLabel
            // 
            this.genderFilterLabel.AutoSize = true;
            this.genderFilterLabel.Location = new System.Drawing.Point(14, 132);
            this.genderFilterLabel.Name = "genderFilterLabel";
            this.genderFilterLabel.Size = new System.Drawing.Size(36, 13);
            this.genderFilterLabel.TabIndex = 21;
            this.genderFilterLabel.Text = "Стать";
            // 
            // surnameFilterLabel
            // 
            this.surnameFilterLabel.AutoSize = true;
            this.surnameFilterLabel.Location = new System.Drawing.Point(14, 80);
            this.surnameFilterLabel.Name = "surnameFilterLabel";
            this.surnameFilterLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameFilterLabel.TabIndex = 19;
            this.surnameFilterLabel.Text = "Прізвище";
            // 
            // surnameFilterTextBox
            // 
            this.surnameFilterTextBox.Location = new System.Drawing.Point(88, 77);
            this.surnameFilterTextBox.Name = "surnameFilterTextBox";
            this.surnameFilterTextBox.Size = new System.Drawing.Size(230, 20);
            this.surnameFilterTextBox.TabIndex = 20;
            // 
            // nameFilterLabel
            // 
            this.nameFilterLabel.AutoSize = true;
            this.nameFilterLabel.Location = new System.Drawing.Point(14, 54);
            this.nameFilterLabel.Name = "nameFilterLabel";
            this.nameFilterLabel.Size = new System.Drawing.Size(26, 13);
            this.nameFilterLabel.TabIndex = 17;
            this.nameFilterLabel.Text = "Ім\'я";
            // 
            // nameFilterTextBox
            // 
            this.nameFilterTextBox.Location = new System.Drawing.Point(88, 51);
            this.nameFilterTextBox.Name = "nameFilterTextBox";
            this.nameFilterTextBox.Size = new System.Drawing.Size(230, 20);
            this.nameFilterTextBox.TabIndex = 18;
            // 
            // idFilterLabel
            // 
            this.idFilterLabel.AutoSize = true;
            this.idFilterLabel.Location = new System.Drawing.Point(14, 28);
            this.idFilterLabel.Name = "idFilterLabel";
            this.idFilterLabel.Size = new System.Drawing.Size(18, 13);
            this.idFilterLabel.TabIndex = 15;
            this.idFilterLabel.Text = "ID";
            // 
            // idFilterTextBox
            // 
            this.idFilterTextBox.Location = new System.Drawing.Point(88, 25);
            this.idFilterTextBox.Name = "idFilterTextBox";
            this.idFilterTextBox.Size = new System.Drawing.Size(91, 20);
            this.idFilterTextBox.TabIndex = 16;
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
            // sellersGridView
            // 
            this.sellersGridView.AllowUserToAddRows = false;
            this.sellersGridView.AllowUserToDeleteRows = false;
            this.sellersGridView.AutoGenerateColumns = false;
            this.sellersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selleridDataGridViewTextBoxColumn,
            this.sellernameDataGridViewTextBoxColumn,
            this.sellersurnameDataGridViewTextBoxColumn,
            this.sellerpatronymicDataGridViewTextBoxColumn,
            this.sellergenderDataGridViewTextBoxColumn,
            this.sellerdobDataGridViewTextBoxColumn,
            this.sellerhiringdateDataGridViewTextBoxColumn,
            this.sellerpasswordDataGridViewTextBoxColumn,
            this.selleradminDataGridViewCheckBoxColumn,
            this.sellerdismissaldateDataGridViewTextBoxColumn});
            this.sellersGridView.DataSource = this.sellersBindingSource;
            this.sellersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellersGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sellersGridView.Location = new System.Drawing.Point(353, 43);
            this.sellersGridView.MultiSelect = false;
            this.sellersGridView.Name = "sellersGridView";
            this.sellersGridView.ReadOnly = true;
            this.sellersGridView.RowHeadersVisible = false;
            this.sellersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellersGridView.Size = new System.Drawing.Size(476, 505);
            this.sellersGridView.TabIndex = 25;
            // 
            // selleridDataGridViewTextBoxColumn
            // 
            this.selleridDataGridViewTextBoxColumn.DataPropertyName = "seller_id";
            this.selleridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.selleridDataGridViewTextBoxColumn.Name = "selleridDataGridViewTextBoxColumn";
            this.selleridDataGridViewTextBoxColumn.ReadOnly = true;
            this.selleridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellernameDataGridViewTextBoxColumn
            // 
            this.sellernameDataGridViewTextBoxColumn.DataPropertyName = "seller_name";
            this.sellernameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.sellernameDataGridViewTextBoxColumn.Name = "sellernameDataGridViewTextBoxColumn";
            this.sellernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellernameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellersurnameDataGridViewTextBoxColumn
            // 
            this.sellersurnameDataGridViewTextBoxColumn.DataPropertyName = "seller_surname";
            this.sellersurnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.sellersurnameDataGridViewTextBoxColumn.Name = "sellersurnameDataGridViewTextBoxColumn";
            this.sellersurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellersurnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellerpatronymicDataGridViewTextBoxColumn
            // 
            this.sellerpatronymicDataGridViewTextBoxColumn.DataPropertyName = "seller_patronymic";
            this.sellerpatronymicDataGridViewTextBoxColumn.HeaderText = "По-батькові";
            this.sellerpatronymicDataGridViewTextBoxColumn.Name = "sellerpatronymicDataGridViewTextBoxColumn";
            this.sellerpatronymicDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerpatronymicDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellergenderDataGridViewTextBoxColumn
            // 
            this.sellergenderDataGridViewTextBoxColumn.DataPropertyName = "seller_gender";
            this.sellergenderDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.sellergenderDataGridViewTextBoxColumn.Name = "sellergenderDataGridViewTextBoxColumn";
            this.sellergenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellergenderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellerdobDataGridViewTextBoxColumn
            // 
            this.sellerdobDataGridViewTextBoxColumn.DataPropertyName = "seller_dob";
            this.sellerdobDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.sellerdobDataGridViewTextBoxColumn.Name = "sellerdobDataGridViewTextBoxColumn";
            this.sellerdobDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerdobDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellerhiringdateDataGridViewTextBoxColumn
            // 
            this.sellerhiringdateDataGridViewTextBoxColumn.DataPropertyName = "seller_hiring_date";
            this.sellerhiringdateDataGridViewTextBoxColumn.HeaderText = "Дата найму";
            this.sellerhiringdateDataGridViewTextBoxColumn.Name = "sellerhiringdateDataGridViewTextBoxColumn";
            this.sellerhiringdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerhiringdateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sellerpasswordDataGridViewTextBoxColumn
            // 
            this.sellerpasswordDataGridViewTextBoxColumn.DataPropertyName = "seller_password";
            this.sellerpasswordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.sellerpasswordDataGridViewTextBoxColumn.Name = "sellerpasswordDataGridViewTextBoxColumn";
            this.sellerpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerpasswordDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // selleradminDataGridViewCheckBoxColumn
            // 
            this.selleradminDataGridViewCheckBoxColumn.DataPropertyName = "seller_admin";
            this.selleradminDataGridViewCheckBoxColumn.HeaderText = "Адміністратор";
            this.selleradminDataGridViewCheckBoxColumn.Name = "selleradminDataGridViewCheckBoxColumn";
            this.selleradminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sellerdismissaldateDataGridViewTextBoxColumn
            // 
            this.sellerdismissaldateDataGridViewTextBoxColumn.DataPropertyName = "seller_dismissal_date";
            this.sellerdismissaldateDataGridViewTextBoxColumn.HeaderText = "Дата звільнення";
            this.sellerdismissaldateDataGridViewTextBoxColumn.Name = "sellerdismissaldateDataGridViewTextBoxColumn";
            this.sellerdismissaldateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerdismissaldateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.orderByLabel);
            this.flowLayoutPanel3.Controls.Add(this.orderByComboBox);
            this.flowLayoutPanel3.Controls.Add(this.descendingCheckBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(353, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(395, 34);
            this.flowLayoutPanel3.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.sellersGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 551);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // sellersTableAdapter1
            // 
            this.sellersTableAdapter1.ClearBeforeFill = true;
            // 
            // SellersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SellersForm";
            this.Text = "Персонал";
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellersGridView)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sellersBindingSource;
        private System.Windows.Forms.Button deleteSellerButton;
        private System.Windows.Forms.Button addSellerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editSellerButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchString;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView sellersGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.CheckBox descendingCheckBox;
        private System.Windows.Forms.Label idFilterLabel;
        private System.Windows.Forms.TextBox idFilterTextBox;
        private System.Windows.Forms.Label surnameFilterLabel;
        private System.Windows.Forms.TextBox surnameFilterTextBox;
        private System.Windows.Forms.Label nameFilterLabel;
        private System.Windows.Forms.TextBox nameFilterTextBox;
        private System.Windows.Forms.ComboBox genderFilterComboBox;
        private System.Windows.Forms.CheckBox birthdateFilterCheckBox;
        private System.Windows.Forms.DateTimePicker birthdateMaxPicker;
        private System.Windows.Forms.DateTimePicker birthdateMinPicker;
        private System.Windows.Forms.Label genderFilterLabel;
        private System.Windows.Forms.CheckBox hiredateFilterCheckBox;
        private System.Windows.Forms.DateTimePicker hiredateMaxPicker;
        private System.Windows.Forms.DateTimePicker hiredateMinPicker;
        private System.Windows.Forms.ComboBox jobFilterComboBox;
        private System.Windows.Forms.Label jobFilterLabel;
        private System.Windows.Forms.CheckBox dismissdateFilterCheckbox;
        private System.Windows.Forms.DateTimePicker dismissMaxPicker;
        private System.Windows.Forms.DateTimePicker dismissMinPicker;
        private System.Windows.Forms.Label patronFilterLabel;
        private System.Windows.Forms.TextBox patronFilterTextBox;
        private pharmacyDataSet pharmacyDataSet1;
        private pharmacyDataSetTableAdapters.sellersTableAdapter sellersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn selleridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellersurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerpatronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellergenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerhiringdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selleradminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerdismissaldateDataGridViewTextBoxColumn;
    }
}