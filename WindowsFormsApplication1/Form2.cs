using FileAccessControl;
using System;
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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        FileSystemAccessRule rule;
        string filename;
        public Form2(FileSystemAccessRule rule, string filename)
        {
            this.rule = rule;
            this.filename = filename;
            InitializeComponent();
            addLists();

            identityReferenceLabel.Text = "" + rule.IdentityReference.Value;
            accessControlLabel.Text = "" + rule.AccessControlType;
            fileSystemRightsLabel.Text = "" + rule.FileSystemRights;
        }

        public void addLists()
        {
            accessControlList.Update();
            accessControlList.Items.Add("Allow");
            accessControlList.Items.Add("Deny");
            accessControlList.EndUpdate();

            fileSystemRightsList.Update();
            fileSystemRightsList.Items.Add("Full Control");
            fileSystemRightsList.Items.Add("Modify");
            fileSystemRightsList.Items.Add("Read snd Execute");
            fileSystemRightsList.Items.Add("Write");
            fileSystemRightsList.Items.Add("Execute");
            fileSystemRightsList.Items.Add("Read");
            fileSystemRightsList.Items.Add("Delete");
            fileSystemRightsList.EndUpdate();
        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            AccessControlType ACT;
            switch(accessControlList.SelectedItem.ToString())
            {
                case "Allow":
                    ACT = AccessControlType.Allow;
                    break;
                case "Deny":
                    ACT = AccessControlType.Deny;
                    break;
                default:
                    ACT = rule.AccessControlType;
                    break;
            }

            FileSystemRights FSR;
            switch(fileSystemRightsList.SelectedItem.ToString())
            {
                case "Full Control":
                    FSR = FileSystemRights.FullControl;
                    break;
                case "Modify":
                    FSR = FileSystemRights.Modify;
                    break;
                case "Read and Execute":
                    FSR = FileSystemRights.ReadAndExecute;
                    break;
                case "Write":
                    FSR = FileSystemRights.Write;
                    break;
                case "Execute":
                    FSR = FileSystemRights.ExecuteFile;
                    break;
                case "Read":
                    FSR = FileSystemRights.Read;
                    break;
                case "Delete":
                    FSR = FileSystemRights.Delete;
                    break;
                default:
                    FSR = rule.FileSystemRights;
                    break;
            }

            FileSystemAccessRule FSAR = new FileSystemAccessRule(rule.IdentityReference.Value, FSR, ACT);
            bool modified;
            using (FileStream stream = File.Open(filename, FileMode.Open))
            {
                FileSecurity securityDescriptor = stream.GetAccessControl();
                AuthorizationRuleCollection rules = securityDescriptor.GetAccessRules(true, true, typeof(NTAccount));
                securityDescriptor.ModifyAccessRule(AccessControlModification.Reset, FSAR, out modified);
                File.SetAccessControl(filename, securityDescriptor);
            }

            ACLView frm = new ACLView(filename);
            frm.Show();
            this.Hide();
        }
    }
}
