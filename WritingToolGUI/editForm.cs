using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

    }
}
