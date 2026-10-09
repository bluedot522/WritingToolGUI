using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace WritingToolGUI
{
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();

        }

        public editForm(Item item, int itemIndex, string itemType)
        {
            InitializeComponent();
            txtEditName.Text = item.Name;
            txtEditDescription.Text = item.Description;
            txtEditTags.Text = string.Join(", ", item.Tags);
            
        }

        public static string editName;
        public static string editDescription;

        public static List<string> editTags = new List<string>();
        private void btnEditSubmit_Click(object sender, EventArgs e)
        {
            editName = txtEditName.Text;
            editDescription = txtEditDescription.Text;
            editTags = new List<string>(txtEditTags.Text.Split(','));

            Close();
        }

        private void editForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEditName_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtEditName_Validating(object sender, CancelEventArgs e)
        {
            btnEditSubmit.Enabled = !string.IsNullOrWhiteSpace(txtEditName.Text);
            if (string.IsNullOrWhiteSpace(txtEditName.Text))
            {
                MessageBox.Show("Name cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            

        }
    }
}
