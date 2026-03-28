namespace Academy
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lbGroup = new System.Windows.Forms.Label();
            this.cbGroupSelect = new System.Windows.Forms.ComboBox();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.msktbPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(13, 13);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(66, 16);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Фамилия";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(86, 13);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(234, 22);
            this.tbLastName.TabIndex = 1;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(13, 43);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(33, 16);
            this.lbFirstName.TabIndex = 2;
            this.lbFirstName.Text = "Имя";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(86, 43);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(234, 22);
            this.tbFirstName.TabIndex = 3;
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Location = new System.Drawing.Point(9, 75);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(70, 16);
            this.lbMiddleName.TabIndex = 4;
            this.lbMiddleName.Text = "Отчество";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(86, 72);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(234, 22);
            this.tbMiddleName.TabIndex = 5;
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Location = new System.Drawing.Point(9, 295);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(57, 16);
            this.lbGroup.TabIndex = 6;
            this.lbGroup.Text = " Группа";
            // 
            // cbGroupSelect
            // 
            this.cbGroupSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupSelect.FormattingEnabled = true;
            this.cbGroupSelect.Location = new System.Drawing.Point(86, 292);
            this.cbGroupSelect.Name = "cbGroupSelect";
            this.cbGroupSelect.Size = new System.Drawing.Size(234, 24);
            this.cbGroupSelect.TabIndex = 7;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(9, 169);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(106, 16);
            this.lbBirthDate.TabIndex = 8;
            this.lbBirthDate.Text = "Дата рождения";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(12, 216);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(67, 16);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Телефон";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 33);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(188, 391);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(142, 33);
            this.btnCansel.TabIndex = 13;
            this.btnCansel.Text = "Отмена";
            this.btnCansel.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(122, 169);
            this.dtpBirthDate.MaxDate = new System.DateTime(2026, 3, 28, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthDate.TabIndex = 14;
            this.dtpBirthDate.Value = new System.DateTime(2026, 3, 28, 0, 0, 0, 0);
            // 
            // msktbPhone
            // 
            this.msktbPhone.Location = new System.Drawing.Point(86, 210);
            this.msktbPhone.Mask = "+7 (999) 000-0000";
            this.msktbPhone.Name = "msktbPhone";
            this.msktbPhone.Size = new System.Drawing.Size(236, 22);
            this.msktbPhone.TabIndex = 15;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 453);
            this.Controls.Add(this.msktbPhone);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.cbGroupSelect);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.ComboBox cbGroupSelect;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.MaskedTextBox msktbPhone;
    }
}