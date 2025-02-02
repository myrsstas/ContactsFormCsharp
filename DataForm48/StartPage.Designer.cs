//Application development in popular integrated development environments © 2023 by Myrsini Stasinou is licensed under CC-BY-4.0 
namespace DataForm48
{
    partial class StartPage
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
            this.letsStartButton = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.uploadButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.filepathTextBox = new System.Windows.Forms.TextBox();
            this.uploadLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // letsStartButton
            // 
            this.letsStartButton.Location = new System.Drawing.Point(158, 89);
            this.letsStartButton.Name = "letsStartButton";
            this.letsStartButton.Size = new System.Drawing.Size(110, 23);
            this.letsStartButton.TabIndex = 1;
            this.letsStartButton.Text = "Let\'s Start";
            this.letsStartButton.UseVisualStyleBackColor = true;
            this.letsStartButton.Click += new System.EventHandler(this.letsStartButton_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(112, 50);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(193, 13);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "To start a new list, click on \"Let\'s Start\"";
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.letsStartButton);
            this.splitContainer.Panel1.Controls.Add(this.startLabel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.uploadButton);
            this.splitContainer.Panel2.Controls.Add(this.browseButton);
            this.splitContainer.Panel2.Controls.Add(this.filepathTextBox);
            this.splitContainer.Panel2.Controls.Add(this.uploadLabel);
            this.splitContainer.Size = new System.Drawing.Size(439, 403);
            this.splitContainer.SplitterDistance = 184;
            this.splitContainer.TabIndex = 2;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(285, 97);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(217, 97);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(33, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filepathTextBox
            // 
            this.filepathTextBox.Location = new System.Drawing.Point(23, 97);
            this.filepathTextBox.Multiline = true;
            this.filepathTextBox.Name = "filepathTextBox";
            this.filepathTextBox.ReadOnly = true;
            this.filepathTextBox.Size = new System.Drawing.Size(188, 46);
            this.filepathTextBox.TabIndex = 1;
            // 
            // uploadLabel
            // 
            this.uploadLabel.AutoSize = true;
            this.uploadLabel.Location = new System.Drawing.Point(69, 54);
            this.uploadLabel.Name = "uploadLabel";
            this.uploadLabel.Size = new System.Drawing.Size(291, 13);
            this.uploadLabel.TabIndex = 0;
            this.uploadLabel.Text = "If you used this app before, and have a file, please upload it.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "TexT|*.txt";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 403);
            this.Controls.Add(this.splitContainer);
            this.Name = "StartPage";
            this.Text = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button letsStartButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filepathTextBox;
        private System.Windows.Forms.Label uploadLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

