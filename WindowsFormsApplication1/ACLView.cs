﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAccessControl
{
    public partial class ACLView : Form
    {
        public ACLView(String filename)
        {
            InitializeComponent();
            using (FileStream stream = File.Open(filename, FileMode.Open))
            {
                FileSecurity securityDescriptor = stream.GetAccessControl();
                AuthorizationRuleCollection rules = securityDescriptor.GetAccessRules(true, true, typeof(NTAccount));
                BindingSource fileSource = new BindingSource();
                fileSource.DataSource = rules;
                permissionsList.AutoArrange = true;


                ColumnHeader nameHeader = new ColumnHeader("Name");
                nameHeader.Width = 100;
                ColumnHeader accessControlHeader = new ColumnHeader("Access Control");
                accessControlHeader.Width = 150;
                accessControlHeader.Text = "Access Control Type";
                ColumnHeader systemRightsHeader = new ColumnHeader("System Rights");
                systemRightsHeader.Width = 150;
                systemRightsHeader.Text = "File System Rights";
                ColumnHeader identityReferenceHeader = new ColumnHeader("Identity Reference");
                identityReferenceHeader.Width = 150;
                identityReferenceHeader.Text = "Identity Reference";
                ColumnHeader inheritedRulesHeader = new ColumnHeader("Inherited Rules");
                inheritedRulesHeader.Width = 150;
                inheritedRulesHeader.Text = "Inherited Rules";


                permissionsList.Columns.Add(nameHeader);
                permissionsList.Columns.Add(accessControlHeader);
                permissionsList.Columns.Add(systemRightsHeader);
                permissionsList.Columns.Add(identityReferenceHeader);
                permissionsList.Columns.Add(inheritedRulesHeader);
                permissionsList.View = View.Details;
                foreach (AuthorizationRule rule in rules)
                {
                    var fileRule = rule as FileSystemAccessRule;
                    ListViewItem file = new ListViewItem(filename.Substring(filename.LastIndexOf('\\')+1));

                    string accessControlString = "" + fileRule.AccessControlType;
                    string systemRightsString = "" + fileRule.FileSystemRights;
                    string identityReferenceString = "" + fileRule.IdentityReference.Value;
                    string inheritedRulesString = "" + fileRule.IsInherited;

                    file.SubItems.Add(accessControlString);
                    file.SubItems.Add(systemRightsString);
                    file.SubItems.Add(identityReferenceString);
                    file.SubItems.Add(inheritedRulesString);

                    permissionsList.Items.Add(file);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}