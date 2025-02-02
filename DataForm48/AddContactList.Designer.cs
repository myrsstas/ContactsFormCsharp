//Application development in popular integrated development environments © 2023 by Myrsini Stasinou is licensed under CC-BY-4.0 
namespace DataForm48
{
    partial class AddContactList
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
            this.cityTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backToListButton = new System.Windows.Forms.Button();
            this.nextEntryButton = new System.Windows.Forms.Button();
            this.notesTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOfBirthTB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(122, 318);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(212, 20);
            this.cityTB.TabIndex = 51;
            this.cityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTB_KeyPress);
            this.cityTB.Leave += new System.EventHandler(this.cityTB_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Phone Number : ";
            // 
            // backToListButton
            // 
            this.backToListButton.Location = new System.Drawing.Point(236, 518);
            this.backToListButton.Name = "backToListButton";
            this.backToListButton.Size = new System.Drawing.Size(100, 23);
            this.backToListButton.TabIndex = 55;
            this.backToListButton.Text = "Back To List";
            this.backToListButton.UseVisualStyleBackColor = true;
            this.backToListButton.Click += new System.EventHandler(this.backToListButton_Click);
            // 
            // nextEntryButton
            // 
            this.nextEntryButton.Location = new System.Drawing.Point(32, 518);
            this.nextEntryButton.Name = "nextEntryButton";
            this.nextEntryButton.Size = new System.Drawing.Size(75, 23);
            this.nextEntryButton.TabIndex = 54;
            this.nextEntryButton.Text = "Next Entry";
            this.nextEntryButton.UseVisualStyleBackColor = true;
            this.nextEntryButton.Click += new System.EventHandler(this.nextEntryButton_Click);
            // 
            // notesTB
            // 
            this.notesTB.Location = new System.Drawing.Point(122, 360);
            this.notesTB.Multiline = true;
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(212, 104);
            this.notesTB.TabIndex = 53;
            this.notesTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTB_KeyPress);
            this.notesTB.Leave += new System.EventHandler(this.notesTB_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Notes :";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(122, 269);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(212, 20);
            this.addressTB.TabIndex = 49;
            this.addressTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTB_KeyPress);
            this.addressTB.Leave += new System.EventHandler(this.addressTB_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "City :";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(122, 217);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(212, 20);
            this.emailTB.TabIndex = 47;
            this.emailTB.Leave += new System.EventHandler(this.emailTB_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Address :";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(122, 171);
            this.phoneTB.MaxLength = 10;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(212, 20);
            this.phoneTB.TabIndex = 45;
            this.phoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Email :";
            // 
            // dateOfBirthTB
            // 
            this.dateOfBirthTB.CustomFormat = "yyyy-MM-dd";
            this.dateOfBirthTB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateOfBirthTB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthTB.Location = new System.Drawing.Point(124, 130);
            this.dateOfBirthTB.Name = "dateOfBirthTB";
            this.dateOfBirthTB.Size = new System.Drawing.Size(212, 20);
            this.dateOfBirthTB.TabIndex = 43;
            this.dateOfBirthTB.Value = new System.DateTime(2023, 2, 26, 1, 27, 18, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Date Of Birth :";
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(122, 88);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(212, 20);
            this.surnameTB.TabIndex = 41;
            this.surnameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTB_KeyPress);
            this.surnameTB.Leave += new System.EventHandler(this.surnameTB_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name :";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(122, 37);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(212, 20);
            this.nameTB.TabIndex = 39;
            this.nameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTB_KeyPress);
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // AddContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 591);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backToListButton);
            this.Controls.Add(this.nextEntryButton);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOfBirthTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddContactList";
            this.Text = "AddContactList";
            this.Load += new System.EventHandler(this.AddContactList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox notesTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateOfBirthTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToListButton;
        private System.Windows.Forms.Button nextEntryButton;
        private System.Windows.Forms.TextBox nameTB;
    }
}