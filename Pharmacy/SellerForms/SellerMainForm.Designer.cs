namespace Pharmacy
{
    partial class SellerMainForm
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
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datatableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesGridView = new System.Windows.Forms.DataGridView();
            this.addSaleButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.продажиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSaleToolStripMenuItem});
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.продажиToolStripMenuItem.Text = "Продажи";
            // 
            // addSaleToolStripMenuItem
            // 
            this.addSaleToolStripMenuItem.Name = "addSaleToolStripMenuItem";
            this.addSaleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addSaleToolStripMenuItem.Text = "Додати продаж";
            this.addSaleToolStripMenuItem.Click += new System.EventHandler(this.AddSaleToolStripMenuItem_Click);
            // 
            // salesGridView
            // 
            this.salesGridView.AllowUserToAddRows = false;
            this.salesGridView.AllowUserToDeleteRows = false;
            this.salesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesGridView.Location = new System.Drawing.Point(12, 67);
            this.salesGridView.MultiSelect = false;
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.ReadOnly = true;
            this.salesGridView.RowHeadersVisible = false;
            this.salesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesGridView.Size = new System.Drawing.Size(776, 317);
            this.salesGridView.TabIndex = 1;
            // 
            // addSaleButton
            // 
            this.addSaleButton.Location = new System.Drawing.Point(54, 406);
            this.addSaleButton.Name = "addSaleButton";
            this.addSaleButton.Size = new System.Drawing.Size(75, 23);
            this.addSaleButton.TabIndex = 2;
            this.addSaleButton.Text = "Додати";
            this.addSaleButton.UseVisualStyleBackColor = true;
            this.addSaleButton.Click += new System.EventHandler(this.AddSaleToolStripMenuItem_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(157, 406);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Змінити";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SellerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addSaleButton);
            this.Controls.Add(this.salesGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SellerMainForm";
            this.Text = "Аптека (продавець)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource datatableBindingSource;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSaleToolStripMenuItem;
        private System.Windows.Forms.DataGridView salesGridView;
        private System.Windows.Forms.Button addSaleButton;
        private System.Windows.Forms.Button editButton;
    }
}