
namespace Pharmacy.AdminForms
{
    partial class CategoriesForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoriesGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.descendingCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.nameFilterLabel = new System.Windows.Forms.Label();
            this.idFilterLabel = new System.Windows.Forms.Label();
            this.nameFilterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.idFilterTextBox = new System.Windows.Forms.TextBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchString = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.categoriesGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 518);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.AllowUserToAddRows = false;
            this.categoriesGridView.AllowUserToDeleteRows = false;
            this.categoriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.categoriesGridView.Location = new System.Drawing.Point(353, 43);
            this.categoriesGridView.MultiSelect = false;
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.ReadOnly = true;
            this.categoriesGridView.RowHeadersVisible = false;
            this.categoriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriesGridView.Size = new System.Drawing.Size(566, 472);
            this.categoriesGridView.TabIndex = 25;
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
            this.orderByComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterButton_Click);
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
            this.descendingCheckBox.CheckedChanged += new System.EventHandler(this.FilterButton_Click);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 512);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.nameFilterLabel);
            this.filterGroupBox.Controls.Add(this.idFilterLabel);
            this.filterGroupBox.Controls.Add(this.nameFilterTextBox);
            this.filterGroupBox.Controls.Add(this.filterButton);
            this.filterGroupBox.Controls.Add(this.idFilterTextBox);
            this.filterGroupBox.Location = new System.Drawing.Point(3, 3);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(335, 146);
            this.filterGroupBox.TabIndex = 22;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтрація";
            // 
            // nameFilterLabel
            // 
            this.nameFilterLabel.AutoSize = true;
            this.nameFilterLabel.Location = new System.Drawing.Point(14, 65);
            this.nameFilterLabel.Name = "nameFilterLabel";
            this.nameFilterLabel.Size = new System.Drawing.Size(39, 13);
            this.nameFilterLabel.TabIndex = 20;
            this.nameFilterLabel.Text = "Назва";
            // 
            // idFilterLabel
            // 
            this.idFilterLabel.AutoSize = true;
            this.idFilterLabel.Location = new System.Drawing.Point(14, 39);
            this.idFilterLabel.Name = "idFilterLabel";
            this.idFilterLabel.Size = new System.Drawing.Size(18, 13);
            this.idFilterLabel.TabIndex = 0;
            this.idFilterLabel.Text = "ID";
            // 
            // nameFilterTextBox
            // 
            this.nameFilterTextBox.Location = new System.Drawing.Point(88, 62);
            this.nameFilterTextBox.Name = "nameFilterTextBox";
            this.nameFilterTextBox.Size = new System.Drawing.Size(230, 20);
            this.nameFilterTextBox.TabIndex = 21;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(121, 88);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(84, 23);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Фільтрувати";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // idFilterTextBox
            // 
            this.idFilterTextBox.Location = new System.Drawing.Point(88, 36);
            this.idFilterTextBox.Name = "idFilterTextBox";
            this.idFilterTextBox.Size = new System.Drawing.Size(230, 20);
            this.idFilterTextBox.TabIndex = 14;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchString);
            this.searchGroupBox.Location = new System.Drawing.Point(3, 155);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(334, 92);
            this.searchGroupBox.TabIndex = 23;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteCategoryButton);
            this.panel1.Controls.Add(this.addCategoryButton);
            this.panel1.Controls.Add(this.editCategoryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 100);
            this.panel1.TabIndex = 24;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(235, 13);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(96, 35);
            this.deleteCategoryButton.TabIndex = 28;
            this.deleteCategoryButton.Text = "Видалити категорію";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.DeletecategoriesButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(3, 13);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(96, 35);
            this.addCategoryButton.TabIndex = 27;
            this.addCategoryButton.Text = "Додати категорію";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.AddcategoriesButton_Click);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.Location = new System.Drawing.Point(119, 13);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(96, 35);
            this.editCategoryButton.TabIndex = 26;
            this.editCategoryButton.Text = "Редагувати категорію";
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Click += new System.EventHandler(this.EditcategoriesButton_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CategoriesForm";
            this.Text = "Категорії ліків";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView categoriesGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.CheckBox descendingCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label nameFilterLabel;
        private System.Windows.Forms.Label idFilterLabel;
        private System.Windows.Forms.TextBox nameFilterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox idFilterTextBox;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchString;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button editCategoryButton;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
    }
}