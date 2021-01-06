
namespace Pharmacy.AdminForms
{
    partial class SalesStatisticsForm
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
            this.drugsGridView = new System.Windows.Forms.DataGridView();
            this.salesGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createStatisticsButton = new System.Windows.Forms.Button();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.totalStatisticsPanel = new System.Windows.Forms.Panel();
            this.soldDrugsTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.totalStatisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.drugsGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalStatisticsPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 577);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // drugsGridView
            // 
            this.drugsGridView.AllowUserToAddRows = false;
            this.drugsGridView.AllowUserToDeleteRows = false;
            this.drugsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drugsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drugsGridView.Location = new System.Drawing.Point(469, 88);
            this.drugsGridView.Name = "drugsGridView";
            this.drugsGridView.ReadOnly = true;
            this.drugsGridView.RowHeadersVisible = false;
            this.drugsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drugsGridView.Size = new System.Drawing.Size(460, 371);
            this.drugsGridView.TabIndex = 3;
            // 
            // salesGridView
            // 
            this.salesGridView.AllowUserToAddRows = false;
            this.salesGridView.AllowUserToDeleteRows = false;
            this.salesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGridView.Location = new System.Drawing.Point(3, 88);
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.ReadOnly = true;
            this.salesGridView.RowHeadersVisible = false;
            this.salesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesGridView.Size = new System.Drawing.Size(460, 371);
            this.salesGridView.TabIndex = 2;
            this.salesGridView.SelectionChanged += new System.EventHandler(this.SalesGridView_SelectionChanged);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.createStatisticsButton);
            this.panel1.Controls.Add(this.fromDatePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.toDatePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 79);
            this.panel1.TabIndex = 0;
            // 
            // createStatisticsButton
            // 
            this.createStatisticsButton.Location = new System.Drawing.Point(420, 43);
            this.createStatisticsButton.Name = "createStatisticsButton";
            this.createStatisticsButton.Size = new System.Drawing.Size(75, 23);
            this.createStatisticsButton.TabIndex = 13;
            this.createStatisticsButton.Text = "Створити";
            this.createStatisticsButton.UseVisualStyleBackColor = true;
            this.createStatisticsButton.Click += new System.EventHandler(this.CreateStatisticsButton_Click);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(76, 9);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(191, 20);
            this.fromDatePicker.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кінець:";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(420, 7);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(191, 20);
            this.toDatePicker.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Початок:";
            // 
            // totalStatisticsPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.totalStatisticsPanel, 2);
            this.totalStatisticsPanel.Controls.Add(this.soldDrugsTextBox);
            this.totalStatisticsPanel.Controls.Add(this.incomeTextBox);
            this.totalStatisticsPanel.Controls.Add(this.label5);
            this.totalStatisticsPanel.Controls.Add(this.label2);
            this.totalStatisticsPanel.Controls.Add(this.label1);
            this.totalStatisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalStatisticsPanel.Location = new System.Drawing.Point(3, 465);
            this.totalStatisticsPanel.Name = "totalStatisticsPanel";
            this.totalStatisticsPanel.Size = new System.Drawing.Size(926, 109);
            this.totalStatisticsPanel.TabIndex = 4;
            this.totalStatisticsPanel.Visible = false;
            // 
            // soldDrugsTextBox
            // 
            this.soldDrugsTextBox.Location = new System.Drawing.Point(440, 48);
            this.soldDrugsTextBox.Name = "soldDrugsTextBox";
            this.soldDrugsTextBox.ReadOnly = true;
            this.soldDrugsTextBox.Size = new System.Drawing.Size(214, 20);
            this.soldDrugsTextBox.TabIndex = 5;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(85, 48);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.ReadOnly = true;
            this.incomeTextBox.Size = new System.Drawing.Size(214, 20);
            this.incomeTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Продано одиниць ліків:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прибуток:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результати за обраний проміжок часу";
            // 
            // SalesStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 577);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SalesStatisticsForm";
            this.Text = "Статистика продажів";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.totalStatisticsPanel.ResumeLayout(false);
            this.totalStatisticsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createStatisticsButton;
        private System.Windows.Forms.DataGridView drugsGridView;
        private System.Windows.Forms.DataGridView salesGridView;
        private System.Windows.Forms.Panel totalStatisticsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soldDrugsTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.BindingSource drugsBindingSource;
    }
}