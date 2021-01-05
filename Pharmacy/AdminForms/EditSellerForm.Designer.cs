
namespace Pharmacy.AdminForms
{
    partial class EditSellerForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.patronymTextBox = new System.Windows.Forms.TextBox();
            this.patronymLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.hiredatePicker = new System.Windows.Forms.DateTimePicker();
            this.hiredateLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.dismissalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dismissalCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sellersTableAdapter1 = new Pharmacy.pharmacyDataSetTableAdapters.sellersTableAdapter();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(26, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Ім\'я";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(97, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(97, 46);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.surnameTextBox.TabIndex = 3;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 49);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Прізвище";
            // 
            // patronymTextBox
            // 
            this.patronymTextBox.Location = new System.Drawing.Point(97, 72);
            this.patronymTextBox.Name = "patronymTextBox";
            this.patronymTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronymTextBox.TabIndex = 5;
            // 
            // patronymLabel
            // 
            this.patronymLabel.AutoSize = true;
            this.patronymLabel.Location = new System.Drawing.Point(12, 75);
            this.patronymLabel.Name = "patronymLabel";
            this.patronymLabel.Size = new System.Drawing.Size(67, 13);
            this.patronymLabel.TabIndex = 4;
            this.patronymLabel.Text = "По-батькові";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 98);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(36, 13);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Стать";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Ч",
            "Ж"});
            this.genderComboBox.Location = new System.Drawing.Point(227, 98);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(70, 21);
            this.genderComboBox.TabIndex = 7;
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Location = new System.Drawing.Point(116, 125);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(181, 20);
            this.birthdatePicker.TabIndex = 8;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(12, 131);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(98, 13);
            this.birthdateLabel.TabIndex = 9;
            this.birthdateLabel.Text = "Дата народження";
            // 
            // hiredatePicker
            // 
            this.hiredatePicker.Location = new System.Drawing.Point(116, 151);
            this.hiredatePicker.Name = "hiredatePicker";
            this.hiredatePicker.Size = new System.Drawing.Size(181, 20);
            this.hiredatePicker.TabIndex = 10;
            // 
            // hiredateLabel
            // 
            this.hiredateLabel.AutoSize = true;
            this.hiredateLabel.Location = new System.Drawing.Point(12, 158);
            this.hiredateLabel.Name = "hiredateLabel";
            this.hiredateLabel.Size = new System.Drawing.Size(67, 13);
            this.hiredateLabel.TabIndex = 11;
            this.hiredateLabel.Text = "Дата найму";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 177);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 180);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Пароль";
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(200, 203);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(97, 17);
            this.adminCheckBox.TabIndex = 15;
            this.adminCheckBox.Text = "Адміністратор";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // dismissalDatePicker
            // 
            this.dismissalDatePicker.Location = new System.Drawing.Point(116, 226);
            this.dismissalDatePicker.Name = "dismissalDatePicker";
            this.dismissalDatePicker.Size = new System.Drawing.Size(181, 20);
            this.dismissalDatePicker.TabIndex = 17;
            // 
            // dismissalCheckBox
            // 
            this.dismissalCheckBox.AutoSize = true;
            this.dismissalCheckBox.Location = new System.Drawing.Point(15, 226);
            this.dismissalCheckBox.Name = "dismissalCheckBox";
            this.dismissalCheckBox.Size = new System.Drawing.Size(77, 17);
            this.dismissalCheckBox.TabIndex = 18;
            this.dismissalCheckBox.Text = "Звільнено";
            this.dismissalCheckBox.UseVisualStyleBackColor = true;
            this.dismissalCheckBox.CheckedChanged += new System.EventHandler(this.DismissalCheckBox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(54, 292);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(182, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // sellersTableAdapter1
            // 
            this.sellersTableAdapter1.ClearBeforeFill = true;
            // 
            // EditSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 327);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dismissalCheckBox);
            this.Controls.Add(this.dismissalDatePicker);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.hiredateLabel);
            this.Controls.Add(this.hiredatePicker);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.birthdatePicker);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.patronymTextBox);
            this.Controls.Add(this.patronymLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "EditSellerForm";
            this.Text = "Редагування працівника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox patronymTextBox;
        private System.Windows.Forms.Label patronymLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.DateTimePicker hiredatePicker;
        private System.Windows.Forms.Label hiredateLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.DateTimePicker dismissalDatePicker;
        private System.Windows.Forms.CheckBox dismissalCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private pharmacyDataSetTableAdapters.sellersTableAdapter sellersTableAdapter1;
    }
}