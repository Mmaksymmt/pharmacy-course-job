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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drugsGridView = new System.Windows.Forms.DataGridView();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.substTextBox = new System.Windows.Forms.TextBox();
            this.substLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.substancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.substancesGridView = new System.Windows.Forms.DataGridView();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.purchaseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.лекарстваToolStripMenuItem});
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
            this.purchaseListToolStripMenuItem});
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
            this.drugsGridView.Location = new System.Drawing.Point(353, 27);
            this.drugsGridView.MultiSelect = false;
            this.drugsGridView.Name = "drugsGridView";
            this.drugsGridView.ReadOnly = true;
            this.drugsGridView.RowHeadersVisible = false;
            this.drugsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drugsGridView.Size = new System.Drawing.Size(593, 317);
            this.drugsGridView.TabIndex = 2;
            this.drugsGridView.SelectionChanged += new System.EventHandler(this.DrugsGridView_SelectionChanged);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.substTextBox);
            this.searchGroupBox.Controls.Add(this.substLabel);
            this.searchGroupBox.Controls.Add(this.nameLabel);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.nameTextBox);
            this.searchGroupBox.Controls.Add(this.categoryLabel);
            this.searchGroupBox.Controls.Add(this.categoryComboBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 27);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(335, 199);
            this.searchGroupBox.TabIndex = 16;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Пошук";
            // 
            // substTextBox
            // 
            this.substTextBox.Location = new System.Drawing.Point(88, 127);
            this.substTextBox.Name = "substTextBox";
            this.substTextBox.Size = new System.Drawing.Size(230, 20);
            this.substTextBox.TabIndex = 16;
            // 
            // substLabel
            // 
            this.substLabel.AutoSize = true;
            this.substLabel.Location = new System.Drawing.Point(14, 130);
            this.substLabel.Name = "substLabel";
            this.substLabel.Size = new System.Drawing.Size(55, 13);
            this.substLabel.TabIndex = 15;
            this.substLabel.Text = "Речовина";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Назва ліків";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(122, 170);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Шукати";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(88, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(14, 84);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(56, 13);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Категорія";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(88, 81);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(230, 21);
            this.categoryComboBox.TabIndex = 3;
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
            this.purchaseListToolStripMenuItem.Click += new System.EventHandler(this.purchaseListToolStripMenuItem_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 549);
            this.Controls.Add(this.substancesGridView);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.drugsGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMainForm";
            this.Text = "Аптека (адміністратор)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.ToolStripMenuItem лекарстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDrugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDrugToolStripMenuItem;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label substLabel;
        private System.Windows.Forms.BindingSource substancesBindingSource;
        private System.Windows.Forms.DataGridView substancesGridView;
        private System.Windows.Forms.TextBox substTextBox;
        private System.Windows.Forms.ToolStripMenuItem deleteDrugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem purchaseListToolStripMenuItem;
    }
}