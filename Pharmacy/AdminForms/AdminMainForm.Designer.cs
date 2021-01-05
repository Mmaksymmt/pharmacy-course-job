namespace Pharmacy.AdminForms
{
    partial class AdminMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лекарстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDrugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDrugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDrugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.purchaseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.речовиниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSubstListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категоріїЛіківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drugsGridView = new System.Windows.Forms.DataGridView();
            this.drugsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.substTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.substancesGridView = new System.Windows.Forms.DataGridView();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.substLabel = new System.Windows.Forms.Label();
            this.substTextBox = new System.Windows.Forms.TextBox();
            this.leftInStockFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.prescriptionFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.maxPriceFilterTextBox = new System.Windows.Forms.TextBox();
            this.minPriceFilterTextBox = new System.Windows.Forms.TextBox();
            this.priceFilterLabel = new System.Windows.Forms.Label();
            this.manufFilterLabel = new System.Windows.Forms.Label();
            this.nameFilterLabel = new System.Windows.Forms.Label();
            this.manufFilterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.nameFilterTextBox = new System.Windows.Forms.TextBox();
            this.categoryFilterLabel = new System.Windows.Forms.Label();
            this.categoryFilterComboBox = new System.Windows.Forms.ComboBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchString = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.descendingCheckBox = new System.Windows.Forms.CheckBox();
            this.editDrugButton = new System.Windows.Forms.Button();
            this.addDrugButton = new System.Windows.Forms.Button();
            this.deleteDrugButton = new System.Windows.Forms.Button();
            this.drugsStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesGridView)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.лекарстваToolStripMenuItem,
            this.речовиниToolStripMenuItem,
            this.категоріїЛіківToolStripMenuItem,
            this.персоналToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // лекарстваToolStripMenuItem
            // 
            this.лекарстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDrugToolStripMenuItem,
            this.editDrugToolStripMenuItem,
            this.deleteDrugsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.purchaseListToolStripMenuItem,
            this.drugsStatisticsToolStripMenuItem});
            this.лекарстваToolStripMenuItem.Name = "лекарстваToolStripMenuItem";
            this.лекарстваToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.лекарстваToolStripMenuItem.Text = "Ліки";
            // 
            // addDrugToolStripMenuItem
            // 
            this.addDrugToolStripMenuItem.Name = "addDrugToolStripMenuItem";
            this.addDrugToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDrugToolStripMenuItem.Text = "Додати";
            this.addDrugToolStripMenuItem.Click += new System.EventHandler(this.AddDrugToolStripMenuItem_Click);
            // 
            // editDrugToolStripMenuItem
            // 
            this.editDrugToolStripMenuItem.Name = "editDrugToolStripMenuItem";
            this.editDrugToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editDrugToolStripMenuItem.Text = "Редагувати";
            this.editDrugToolStripMenuItem.Click += new System.EventHandler(this.EditDrugToolStripMenuItem_Click);
            // 
            // deleteDrugsToolStripMenuItem
            // 
            this.deleteDrugsToolStripMenuItem.Name = "deleteDrugsToolStripMenuItem";
            this.deleteDrugsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteDrugsToolStripMenuItem.Text = "Видалити";
            this.deleteDrugsToolStripMenuItem.Click += new System.EventHandler(this.DeleteDrugsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // purchaseListToolStripMenuItem
            // 
            this.purchaseListToolStripMenuItem.Name = "purchaseListToolStripMenuItem";
            this.purchaseListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.purchaseListToolStripMenuItem.Text = "Список закупки";
            this.purchaseListToolStripMenuItem.Click += new System.EventHandler(this.PurchaseListToolStripMenuItem_Click);
            // 
            // речовиниToolStripMenuItem
            // 
            this.речовиниToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSubstListToolStripMenuItem});
            this.речовиниToolStripMenuItem.Name = "речовиниToolStripMenuItem";
            this.речовиниToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.речовиниToolStripMenuItem.Text = "Речовини";
            // 
            // openSubstListToolStripMenuItem
            // 
            this.openSubstListToolStripMenuItem.Name = "openSubstListToolStripMenuItem";
            this.openSubstListToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openSubstListToolStripMenuItem.Text = "Список речовин";
            this.openSubstListToolStripMenuItem.Click += new System.EventHandler(this.OpenSubstListToolStripMenuItem_Click);
            // 
            // категоріїЛіківToolStripMenuItem
            // 
            this.категоріїЛіківToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesListToolStripMenuItem});
            this.категоріїЛіківToolStripMenuItem.Name = "категоріїЛіківToolStripMenuItem";
            this.категоріїЛіківToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.категоріїЛіківToolStripMenuItem.Text = "Категорії ліків";
            // 
            // categoriesListToolStripMenuItem
            // 
            this.categoriesListToolStripMenuItem.Name = "categoriesListToolStripMenuItem";
            this.categoriesListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.categoriesListToolStripMenuItem.Text = "Список категорій";
            this.categoriesListToolStripMenuItem.Click += new System.EventHandler(this.CategoriesListToolStripMenuItem_Click);
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellersListToolStripMenuItem});
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.персоналToolStripMenuItem.Text = "Персонал";
            // 
            // sellersListToolStripMenuItem
            // 
            this.sellersListToolStripMenuItem.Name = "sellersListToolStripMenuItem";
            this.sellersListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.sellersListToolStripMenuItem.Text = "Список персоналу";
            this.sellersListToolStripMenuItem.Click += new System.EventHandler(this.SellersListToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // drugsGridView
            // 
            this.drugsGridView.AllowUserToAddRows = false;
            this.drugsGridView.AllowUserToDeleteRows = false;
            this.drugsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drugsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.drugsGridView.Location = new System.Drawing.Point(353, 66);
            this.drugsGridView.MultiSelect = false;
            this.drugsGridView.Name = "drugsGridView";
            this.drugsGridView.ReadOnly = true;
            this.drugsGridView.RowHeadersVisible = false;
            this.drugsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drugsGridView.Size = new System.Drawing.Size(593, 317);
            this.drugsGridView.TabIndex = 2;
            this.drugsGridView.SelectionChanged += new System.EventHandler(this.DrugsGridView_SelectionChanged);
            // 
            // substancesGridView
            // 
            this.substancesGridView.AllowUserToAddRows = false;
            this.substancesGridView.AllowUserToDeleteRows = false;
            this.substancesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.substancesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.substancesGridView.Location = new System.Drawing.Point(353, 402);
            this.substancesGridView.MultiSelect = false;
            this.substancesGridView.Name = "substancesGridView";
            this.substancesGridView.ReadOnly = true;
            this.substancesGridView.RowHeadersVisible = false;
            this.substancesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.substancesGridView.Size = new System.Drawing.Size(593, 135);
            this.substancesGridView.TabIndex = 17;
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
            this.filterGroupBox.Location = new System.Drawing.Point(12, 27);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(335, 225);
            this.filterGroupBox.TabIndex = 18;
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
            // nameFilterLabel
            // 
            this.nameFilterLabel.AutoSize = true;
            this.nameFilterLabel.Location = new System.Drawing.Point(14, 39);
            this.nameFilterLabel.Name = "nameFilterLabel";
            this.nameFilterLabel.Size = new System.Drawing.Size(64, 13);
            this.nameFilterLabel.TabIndex = 0;
            this.nameFilterLabel.Text = "Назва ліків";
            // 
            // manufFilterTextBox
            // 
            this.manufFilterTextBox.Location = new System.Drawing.Point(88, 89);
            this.manufFilterTextBox.Name = "manufFilterTextBox";
            this.manufFilterTextBox.Size = new System.Drawing.Size(230, 20);
            this.manufFilterTextBox.TabIndex = 21;
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
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchString);
            this.searchGroupBox.Location = new System.Drawing.Point(13, 258);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(334, 92);
            this.searchGroupBox.TabIndex = 21;
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.orderByLabel);
            this.flowLayoutPanel2.Controls.Add(this.orderByComboBox);
            this.flowLayoutPanel2.Controls.Add(this.descendingCheckBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(353, 27);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(469, 34);
            this.flowLayoutPanel2.TabIndex = 22;
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
            // editDrugButton
            // 
            this.editDrugButton.Location = new System.Drawing.Point(134, 356);
            this.editDrugButton.Name = "editDrugButton";
            this.editDrugButton.Size = new System.Drawing.Size(96, 23);
            this.editDrugButton.TabIndex = 23;
            this.editDrugButton.Text = "Редагувати ліки";
            this.editDrugButton.UseVisualStyleBackColor = true;
            this.editDrugButton.Click += new System.EventHandler(this.EditDrugToolStripMenuItem_Click);
            // 
            // addDrugButton
            // 
            this.addDrugButton.Location = new System.Drawing.Point(13, 356);
            this.addDrugButton.Name = "addDrugButton";
            this.addDrugButton.Size = new System.Drawing.Size(96, 23);
            this.addDrugButton.TabIndex = 24;
            this.addDrugButton.Text = "Додати ліки";
            this.addDrugButton.UseVisualStyleBackColor = true;
            this.addDrugButton.Click += new System.EventHandler(this.AddDrugToolStripMenuItem_Click);
            // 
            // deleteDrugButton
            // 
            this.deleteDrugButton.Location = new System.Drawing.Point(251, 356);
            this.deleteDrugButton.Name = "deleteDrugButton";
            this.deleteDrugButton.Size = new System.Drawing.Size(96, 23);
            this.deleteDrugButton.TabIndex = 25;
            this.deleteDrugButton.Text = "Видалити ліки";
            this.deleteDrugButton.UseVisualStyleBackColor = true;
            this.deleteDrugButton.Click += new System.EventHandler(this.DeleteDrugsToolStripMenuItem_Click);
            // 
            // drugsStatisticsToolStripMenuItem
            // 
            this.drugsStatisticsToolStripMenuItem.Name = "drugsStatisticsToolStripMenuItem";
            this.drugsStatisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drugsStatisticsToolStripMenuItem.Text = "Статистика";
            this.drugsStatisticsToolStripMenuItem.Click += new System.EventHandler(this.DrugsStatisticsToolStripMenuItem_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 549);
            this.Controls.Add(this.deleteDrugButton);
            this.Controls.Add(this.addDrugButton);
            this.Controls.Add(this.editDrugButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.substancesGridView);
            this.Controls.Add(this.drugsGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMainForm";
            this.Text = "Аптека (адміністратор)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesGridView)).EndInit();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView drugsGridView;
        private System.Windows.Forms.BindingSource drugsTableBindingSource;
        private System.Windows.Forms.ToolStripMenuItem лекарстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDrugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDrugToolStripMenuItem;
        private System.Windows.Forms.BindingSource substTableBindingSource;
        private System.Windows.Forms.DataGridView substancesGridView;
        private System.Windows.Forms.ToolStripMenuItem deleteDrugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem purchaseListToolStripMenuItem;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label substLabel;
        private System.Windows.Forms.TextBox substTextBox;
        private System.Windows.Forms.CheckBox leftInStockFilterCheckBox;
        private System.Windows.Forms.CheckBox prescriptionFilterCheckBox;
        private System.Windows.Forms.TextBox maxPriceFilterTextBox;
        private System.Windows.Forms.TextBox minPriceFilterTextBox;
        private System.Windows.Forms.Label priceFilterLabel;
        private System.Windows.Forms.Label manufFilterLabel;
        private System.Windows.Forms.Label nameFilterLabel;
        private System.Windows.Forms.TextBox manufFilterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox nameFilterTextBox;
        private System.Windows.Forms.Label categoryFilterLabel;
        private System.Windows.Forms.ComboBox categoryFilterComboBox;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchString;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.CheckBox descendingCheckBox;
        private System.Windows.Forms.Button editDrugButton;
        private System.Windows.Forms.Button addDrugButton;
        private System.Windows.Forms.Button deleteDrugButton;
        private System.Windows.Forms.ToolStripMenuItem речовиниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSubstListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категоріїЛіківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugsStatisticsToolStripMenuItem;
    }
}