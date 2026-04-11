namespace Academy
{
    partial class TeacherForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Size = new System.Drawing.Size(212, 279);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(566, 341);
            this.buttonPhoto.Size = new System.Drawing.Size(212, 38);
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(19, 437);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(453, 429);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(153, 37);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCansel.Location = new System.Drawing.Point(625, 429);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(153, 37);
            this.buttonCansel.TabIndex = 16;
            this.buttonCansel.Text = "Cansel";
            this.buttonCansel.UseVisualStyleBackColor = true;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 475);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonOK);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Controls.SetChildIndex(this.labelID, 0);
            this.Controls.SetChildIndex(this.labelBirthDate, 0);
            this.Controls.SetChildIndex(this.rtbLastName, 0);
            this.Controls.SetChildIndex(this.rtbFirstName, 0);
            this.Controls.SetChildIndex(this.rtbMiddleName, 0);
            this.Controls.SetChildIndex(this.dtpBirthDate, 0);
            this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.buttonPhoto, 0);
            this.Controls.SetChildIndex(this.rtbPhone, 0);
            this.Controls.SetChildIndex(this.rtbEmail, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonCansel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCansel;
    }
}