namespace FileAccessControl
{
    partial class ACLView
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
            this.editButtom = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.permissionsList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // editButtom
            // 
            this.editButtom.Location = new System.Drawing.Point(12, 259);
            this.editButtom.Name = "editButtom";
            this.editButtom.Size = new System.Drawing.Size(140, 57);
            this.editButtom.TabIndex = 1;
            this.editButtom.Text = "Edit Permissions";
            this.editButtom.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(749, 259);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(140, 57);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "View Another File";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // permissionsList
            // 
            this.permissionsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.permissionsList.Location = new System.Drawing.Point(12, 13);
            this.permissionsList.Name = "permissionsList";
            this.permissionsList.Size = new System.Drawing.Size(877, 240);
            this.permissionsList.TabIndex = 3;
            this.permissionsList.UseCompatibleStateImageBehavior = false;
            // 
            // ACLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 330);
            this.Controls.Add(this.permissionsList);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editButtom);
            this.Name = "ACLView";
            this.Text = "ACLView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editButtom;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView permissionsList;
    }
}