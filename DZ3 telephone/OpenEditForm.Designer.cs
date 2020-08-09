namespace DZ3_telephone
{
    partial class OpenEditForm
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.work_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.contactPictureBox = new System.Windows.Forms.PictureBox();
            this.editButton = new System.Windows.Forms.Button();
            this.openImageFile = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.category_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(330, 228);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 21;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(168, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(167, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Work:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(168, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // address_textBox
            // 
            this.address_textBox.Enabled = false;
            this.address_textBox.Location = new System.Drawing.Point(259, 142);
            this.address_textBox.MaxLength = 40;
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(146, 20);
            this.address_textBox.TabIndex = 15;
            // 
            // work_textBox
            // 
            this.work_textBox.Enabled = false;
            this.work_textBox.Location = new System.Drawing.Point(259, 97);
            this.work_textBox.MaxLength = 40;
            this.work_textBox.Name = "work_textBox";
            this.work_textBox.Size = new System.Drawing.Size(146, 20);
            this.work_textBox.TabIndex = 14;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Enabled = false;
            this.phone_textBox.Location = new System.Drawing.Point(259, 54);
            this.phone_textBox.MaxLength = 30;
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(146, 20);
            this.phone_textBox.TabIndex = 13;
            this.phone_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_textBox_KeyPress);
            // 
            // name_textBox
            // 
            this.name_textBox.Enabled = false;
            this.name_textBox.Location = new System.Drawing.Point(259, 11);
            this.name_textBox.MaxLength = 20;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(146, 20);
            this.name_textBox.TabIndex = 12;
            // 
            // contactPictureBox
            // 
            this.contactPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactPictureBox.Enabled = false;
            this.contactPictureBox.Location = new System.Drawing.Point(12, 12);
            this.contactPictureBox.MaximumSize = new System.Drawing.Size(150, 150);
            this.contactPictureBox.Name = "contactPictureBox";
            this.contactPictureBox.Size = new System.Drawing.Size(150, 150);
            this.contactPictureBox.TabIndex = 11;
            this.contactPictureBox.TabStop = false;
            this.contactPictureBox.Click += new System.EventHandler(this.contactPictureBox_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(249, 228);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // openImageFile
            // 
            this.openImageFile.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(168, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Category:";
            // 
            // category_textBox
            // 
            this.category_textBox.Enabled = false;
            this.category_textBox.Location = new System.Drawing.Point(259, 184);
            this.category_textBox.MaxLength = 40;
            this.category_textBox.Name = "category_textBox";
            this.category_textBox.Size = new System.Drawing.Size(146, 20);
            this.category_textBox.TabIndex = 23;
            // 
            // OpenEditForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(417, 259);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.category_textBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.work_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.contactPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OpenEditForm";
            this.Text = "OpenEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox work_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.PictureBox contactPictureBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.OpenFileDialog openImageFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox category_textBox;
    }
}