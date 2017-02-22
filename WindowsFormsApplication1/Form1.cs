using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAccessControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewInformation_Click(object sender, EventArgs e)
        {
            string filename = filenameTextBox.Text;
            if(string.IsNullOrEmpty(filename) || !validateFilename(filename))
            {
                MessageBox.Show("Please enter a valid file path.");
            }
            else
            {
                filename.Replace(@"\", "\\\\");
                ACLView view = new ACLView(filename);
                view.Show();
                this.Hide();
            }
        }

        public bool validateFilename(string filename)
        {
            try
            {
                FileInfo testInfo = new FileInfo(filename);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
