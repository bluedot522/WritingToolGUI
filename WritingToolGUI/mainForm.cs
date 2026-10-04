namespace WritingToolGUI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
        }

        public static string linkItem1Text;
        public static int ItemCount = 0;

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            //Opens a new form for the user to write in
            editForm editForm = new editForm();
            editForm.ShowDialog();
            lblWelcome.Visible = false;

            lnkItem1.Text = editForm.editName;
            lblDate1.Text = DateTime.Now.ToString("MM/dd/yy");
            lblTags1.Text = string.Join(", ", editForm.editTags);
            MakeLinkVisible(1);
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            //Opens a new form for the user to write in
            editForm editForm = new editForm();
            editForm.ShowDialog();
            lblWelcome.Visible = false;
        }

        public void MakeLinkVisible(int linkIndex)
        {
            switch (linkIndex)
            {
                case 1:
                    lnkItem1.Visible = true;
                    lblDate1.Visible = true;
                    lnkEdit1.Visible = true;
                    lblTags1.Visible = true;
                    break;
                case 2:
                    lnkItem2.Visible = true;
                    lblDate2.Visible = true;
                    lnkEdit2.Visible = true;
                    lblTags2.Visible = true;
                    break;
                case 3:
                    lnkItem3.Visible = true;
                    lblDate3.Visible = true;
                    lnkEdit3.Visible = true;
                    lblTags3.Visible = true;
                    break;
                case 4:
                    lnkItem4.Visible = true;
                    lblDate4.Visible = true;
                    lnkEdit4.Visible = true;
                    lblTags4.Visible = true;
                    break;
                case 5:
                    lnkItem5.Visible = true;
                    lblDate5.Visible = true;
                    lnkEdit5.Visible = true;
                    lblTags5.Visible = true;
                    break;
            }
        }

    }
}
