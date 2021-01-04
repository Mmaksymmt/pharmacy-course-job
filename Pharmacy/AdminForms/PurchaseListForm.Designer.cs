
namespace Pharmacy.AdminForms
{
    partial class PurchaseListForm
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
            this.drugsGridView = new System.Windows.Forms.DataGridView();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            this.createListButton = new System.Windows.Forms.Button();
            this.stockUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.makeDocumentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // drugsGridView
            // 
            this.drugsGridView.AllowUserToAddRows = false;
            this.drugsGridView.AllowUserToDeleteRows = false;
            this.drugsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drugsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.drugsGridView.Location = new System.Drawing.Point(104, 105);
            this.drugsGridView.MultiSelect = false;
            this.drugsGridView.Name = "drugsGridView";
            this.drugsGridView.ReadOnly = true;
            this.drugsGridView.RowHeadersVisible = false;
            this.drugsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drugsGridView.Size = new System.Drawing.Size(593, 317);
            this.drugsGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сума для закупки:";
            // 
            // priceUpDown
            // 
            this.priceUpDown.DecimalPlaces = 2;
            this.priceUpDown.Location = new System.Drawing.Point(232, 24);
            this.priceUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.Size = new System.Drawing.Size(120, 20);
            this.priceUpDown.TabIndex = 5;
            // 
            // createListButton
            // 
            this.createListButton.Location = new System.Drawing.Point(515, 63);
            this.createListButton.Name = "createListButton";
            this.createListButton.Size = new System.Drawing.Size(155, 23);
            this.createListButton.TabIndex = 6;
            this.createListButton.Text = "Сформувати список";
            this.createListButton.UseVisualStyleBackColor = true;
            this.createListButton.Click += new System.EventHandler(this.CreateListButton_Click);
            // 
            // stockUpDown
            // 
            this.stockUpDown.Location = new System.Drawing.Point(232, 61);
            this.stockUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.stockUpDown.Name = "stockUpDown";
            this.stockUpDown.Size = new System.Drawing.Size(120, 20);
            this.stockUpDown.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Запас:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(512, 26);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.totalPriceLabel.TabIndex = 9;
            this.totalPriceLabel.Text = "Total";
            // 
            // makeDocumentButton
            // 
            this.makeDocumentButton.Location = new System.Drawing.Point(337, 444);
            this.makeDocumentButton.Name = "makeDocumentButton";
            this.makeDocumentButton.Size = new System.Drawing.Size(155, 23);
            this.makeDocumentButton.TabIndex = 10;
            this.makeDocumentButton.Text = "Створити документ";
            this.makeDocumentButton.UseVisualStyleBackColor = true;
            this.makeDocumentButton.Click += new System.EventHandler(this.MakeDocumentButton_Click);
            // 
            // PurchaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.makeDocumentButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.stockUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createListButton);
            this.Controls.Add(this.priceUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drugsGridView);
            this.Name = "PurchaseListForm";
            this.Text = "Список до закупки";
            ((System.ComponentModel.ISupportInitialize)(this.drugsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drugsGridView;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown priceUpDown;
        private System.Windows.Forms.Button createListButton;
        private System.Windows.Forms.NumericUpDown stockUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button makeDocumentButton;
    }
}