namespace DataForm48
{
    partial class ContactList
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
            this.exitButton = new System.Windows.Forms.Button();
            this.exportDataButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.contactsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(545, 463);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exportDataButton
            // 
            this.exportDataButton.Location = new System.Drawing.Point(536, 24);
            this.exportDataButton.Name = "exportDataButton";
            this.exportDataButton.Size = new System.Drawing.Size(84, 23);
            this.exportDataButton.TabIndex = 10;
            this.exportDataButton.Text = "Export Data";
            this.exportDataButton.UseVisualStyleBackColor = true;
            this.exportDataButton.Click += new System.EventHandler(this.exportDataButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(15, 24);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(113, 23);
            this.addContactButton.TabIndex = 9;
            this.addContactButton.Text = "Add New Contact";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // contactsDataGridView
            // 
            this.contactsDataGridView.AllowUserToAddRows = false;
            this.contactsDataGridView.AllowUserToDeleteRows = false;
            this.contactsDataGridView.AllowUserToOrderColumns = true;
            this.contactsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.contactsDataGridView.Location = new System.Drawing.Point(14, 56);
            this.contactsDataGridView.Name = "contactsDataGridView";
            this.contactsDataGridView.ReadOnly = true;
            this.contactsDataGridView.Size = new System.Drawing.Size(606, 397);
            this.contactsDataGridView.TabIndex = 8;
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exportDataButton);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.contactsDataGridView);
            this.Name = "ContactList";
            this.Text = "ContactList";
            this.VisibleChanged += new System.EventHandler(this.ContactList_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button exportDataButton;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.DataGridView contactsDataGridView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}