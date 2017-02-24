namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.identityReferenceLabel = new System.Windows.Forms.Label();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.accessControlLabel = new System.Windows.Forms.Label();
            this.fileSystemRightsLabel = new System.Windows.Forms.Label();
            this.accessControlList = new System.Windows.Forms.ListBox();
            this.fileSystemRightsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // identityReferenceLabel
            // 
            this.identityReferenceLabel.AutoSize = true;
            this.identityReferenceLabel.Location = new System.Drawing.Point(13, 13);
            this.identityReferenceLabel.Name = "identityReferenceLabel";
            this.identityReferenceLabel.Size = new System.Drawing.Size(46, 17);
            this.identityReferenceLabel.TabIndex = 0;
            this.identityReferenceLabel.Text = "label1";
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Location = new System.Drawing.Point(12, 206);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(74, 50);
            this.saveAndExitButton.TabIndex = 3;
            this.saveAndExitButton.Text = "Save and Exit";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(442, 206);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 50);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // accessControlLabel
            // 
            this.accessControlLabel.AutoSize = true;
            this.accessControlLabel.Location = new System.Drawing.Point(162, 13);
            this.accessControlLabel.Name = "accessControlLabel";
            this.accessControlLabel.Size = new System.Drawing.Size(46, 17);
            this.accessControlLabel.TabIndex = 6;
            this.accessControlLabel.Text = "label1";
            // 
            // fileSystemRightsLabel
            // 
            this.fileSystemRightsLabel.AutoSize = true;
            this.fileSystemRightsLabel.Location = new System.Drawing.Point(321, 13);
            this.fileSystemRightsLabel.Name = "fileSystemRightsLabel";
            this.fileSystemRightsLabel.Size = new System.Drawing.Size(46, 17);
            this.fileSystemRightsLabel.TabIndex = 7;
            this.fileSystemRightsLabel.Text = "label2";
            // 
            // accessControlList
            // 
            this.accessControlList.FormattingEnabled = true;
            this.accessControlList.ItemHeight = 16;
            this.accessControlList.Location = new System.Drawing.Point(165, 51);
            this.accessControlList.Name = "accessControlList";
            this.accessControlList.Size = new System.Drawing.Size(120, 84);
            this.accessControlList.TabIndex = 8;
            // 
            // fileSystemRightsList
            // 
            this.fileSystemRightsList.FormattingEnabled = true;
            this.fileSystemRightsList.ItemHeight = 16;
            this.fileSystemRightsList.Location = new System.Drawing.Point(324, 51);
            this.fileSystemRightsList.Name = "fileSystemRightsList";
            this.fileSystemRightsList.Size = new System.Drawing.Size(120, 84);
            this.fileSystemRightsList.TabIndex = 9;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(529, 268);
            this.Controls.Add(this.fileSystemRightsList);
            this.Controls.Add(this.accessControlList);
            this.Controls.Add(this.fileSystemRightsLabel);
            this.Controls.Add(this.accessControlLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.identityReferenceLabel);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIdentity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label identityReferenceLabel;
        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label accessControlLabel;
        private System.Windows.Forms.Label fileSystemRightsLabel;
        private System.Windows.Forms.ListBox accessControlList;
        private System.Windows.Forms.ListBox fileSystemRightsList;
    }
}