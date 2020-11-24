namespace Pharmacy
{
    partial class EditSaleForm
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
            this.salesDrugsGridView = new System.Windows.Forms.DataGridView();
            this.salesdrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesDrugsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesdrugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDrugsGridView
            // 
            this.salesDrugsGridView.AllowUserToAddRows = false;
            this.salesDrugsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDrugsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesDrugsGridView.Location = new System.Drawing.Point(12, 38);
            this.salesDrugsGridView.Name = "salesDrugsGridView";
            this.salesDrugsGridView.ReadOnly = true;
            this.salesDrugsGridView.RowHeadersVisible = false;
            this.salesDrugsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDrugsGridView.Size = new System.Drawing.Size(776, 317);
            this.salesDrugsGridView.TabIndex = 0;
            this.salesDrugsGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.SalesDrugsGridView_UserDeletedRow);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(12, 392);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Додати";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(93, 392);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(483, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "OK";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(617, 392);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(132, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Відмінити продаж";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(175, 392);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Змінити";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.salesDrugsGridView);
            this.Name = "EditSaleForm";
            this.Text = "Редагування продажі";
            ((System.ComponentModel.ISupportInitialize)(this.salesDrugsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesdrugsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView salesDrugsGridView;
        private System.Windows.Forms.BindingSource salesdrugsBindingSource;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
    }
}