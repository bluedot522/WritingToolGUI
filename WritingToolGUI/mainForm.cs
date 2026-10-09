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

        public static int currentPageIndex = 1;
        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            //Opens a new form for the user to write in
            lblWelcome.Visible = false;
            editForm editForm = new editForm();
            Character.AddCharacter(editForm.editName, editForm.editDescription, editForm.editTags);
            editForm.ShowDialog();
            Item.itemsTotal.Add(new Character { Name = editForm.editName, Description = editForm.editDescription, Tags = editForm.editTags, Date = DateTime.Now.ToString("MM/dd/yy") });
            Item.itemType.Add("Character");
            UpdateText(Item.itemsTotal.Count);
            MakeLinkVisible(Item.itemsTotal.Count);

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            //Opens a new form for the user to write in
            lblWelcome.Visible = false;
            editForm editForm = new editForm();
            Project.AddProject(editForm.editName, editForm.editDescription, editForm.editTags);
            editForm.ShowDialog();
            Item.itemsTotal.Add(new Project { Name = editForm.editName, Description = editForm.editDescription, Tags = editForm.editTags, Date = DateTime.Now.ToString("MM/dd/yy") });
            Item.itemType.Add("Project");
            UpdateText(Item.itemsTotal.Count);
            MakeLinkVisible(Item.itemsTotal.Count);

        }

        // Pagination does not work
        private void btnNext_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            currentPageIndex++;
            for (int i = 1; i <= 5; i++)
            {

                ClearLinkText(i);
                MakeLinkInvisible(i);
            }
            AddItemsToNewPage(currentPageIndex);
        }



        public void AddItemsToNewPage(int pageIndex)
        {
            int arrayStart = (pageIndex - 1) * 5;
            int endIndex = Math.Min(arrayStart + 5, Item.itemsTotal.Count);
            int totalSteps = endIndex - arrayStart;
            for (int i = arrayStart; i < endIndex; i++)
            {
                DisplayNewPageText(arrayStart, totalSteps);
            }

        }

        //Can't get pagination to work. Considering removing this and having a scrollbar 
        public void UpdateText(int linkIndex)
        {
            switch (linkIndex)
            {
                case 1:
                    lnkItem1.Text = Item.itemsTotal[linkIndex - 1].Name;
                    lblDate1.Text = Item.itemsTotal[linkIndex - 1].Date;
                    lblTags1.Text = string.Join(", ", Item.itemsTotal[linkIndex - 1].Tags);
                    break;
                case 2:
                    lnkItem2.Text = Item.itemsTotal[linkIndex - 1].Name;
                    lblDate2.Text = Item.itemsTotal[linkIndex - 1].Date;
                    lblTags2.Text = string.Join(", ", Item.itemsTotal[linkIndex - 1].Tags);
                    break;
                case 3:
                    lnkItem3.Text = Item.itemsTotal[linkIndex - 1].Name;
                    lblDate3.Text = Item.itemsTotal[linkIndex - 1].Date;
                    lblTags3.Text = string.Join(", ", Item.itemsTotal[linkIndex - 1].Tags);
                    break;
                case 4:
                    lnkItem4.Text = Item.itemsTotal[linkIndex - 1].Name;
                    lblDate4.Text = Item.itemsTotal[linkIndex - 1].Date;
                    lblTags4.Text = string.Join(", ", Item.itemsTotal[linkIndex - 1].Tags);
                    break;
                case 5:
                    lnkItem5.Text = Item.itemsTotal[linkIndex - 1].Name;
                    lblDate5.Text = Item.itemsTotal[linkIndex - 1].Date;
                    lblTags5.Text = string.Join(", ", Item.itemsTotal[linkIndex - 1].Tags);
                    break;
            }
        }
        public void DisplayNewPageText(int arrayStart, int totalSteps)
        {
            int linkIndex = arrayStart + totalSteps - 1;
            switch (totalSteps)
            {
                case 0:
                    lnkItem1.Text = Item.itemsTotal[linkIndex].Name;
                    lblDate1.Text = Item.itemsTotal[linkIndex].Date;
                    lblTags1.Text = string.Join(", ", editForm.editTags);
                    lnkItem1.Visible = true;
                    lblDate1.Visible = true;
                    lnkEdit1.Visible = true;
                    lblTags1.Visible = true;

                    break;
                case 1:
                    lnkItem2.Text = Item.itemsTotal[linkIndex].Name;
                    lblDate2.Text = Item.itemsTotal[linkIndex].Date;
                    lblTags2.Text = string.Join(", ", editForm.editTags);
                    lnkItem2.Visible = true;
                    lblDate2.Visible = true;
                    lnkEdit2.Visible = true;
                    lblTags2.Visible = true;

                    break;
                case 2:
                    lnkItem3.Text = Item.itemsTotal[linkIndex].Name;
                    lblDate3.Text = Item.itemsTotal[linkIndex].Date;
                    lblTags3.Text = string.Join(", ", editForm.editTags);
                    lnkItem3.Visible = true;
                    lblDate3.Visible = true;
                    lnkEdit3.Visible = true;
                    lblTags3.Visible = true;

                    break;
                case 3:
                    lnkItem4.Text = Item.itemsTotal[linkIndex].Name;
                    lblDate4.Text = Item.itemsTotal[linkIndex].Date;
                    lblTags4.Text = string.Join(", ", editForm.editTags);
                    lnkItem1.Visible = true;
                    lblDate4.Visible = true;
                    lnkEdit4.Visible = true;
                    lblTags4.Visible = true;

                    break;
                case 4:
                    lnkItem5.Text = Item.itemsTotal[linkIndex].Name;
                    lblDate5.Text = Item.itemsTotal[linkIndex].Date;
                    lblTags5.Text = string.Join(", ", editForm.editTags);
                    lnkItem1.Visible = true;
                    lblDate5.Visible = true;
                    lnkEdit5.Visible = true;
                    lblTags5.Visible = true;

                    break;
            }
        }

        public void ClearLinkText(int linkIndex)
        {
            switch (linkIndex)
            {
                case 1:
                    lnkItem1.Text = "";
                    lblDate1.Text = "";
                    lblTags1.Text = "";
                    break;
                case 2:
                    lnkItem2.Text = "";
                    lblDate2.Text = "";
                    lblTags2.Text = "";
                    break;
                case 3:
                    lnkItem3.Text = "";
                    lblDate3.Text = "";
                    lblTags3.Text = "";
                    break;
                case 4:
                    lnkItem4.Text = "";
                    lblDate4.Text = "";
                    lblTags4.Text = "";
                    break;
                case 5:
                    lnkItem5.Text = "";
                    lblDate5.Text = "";
                    lblTags5.Text = "";
                    break;
            }
        }

        public void MakeLinkInvisible(int linkIndex)
        {
            switch (linkIndex)
            {
                case 1:
                    lnkItem1.Visible = false;
                    lblDate1.Visible = false;
                    lnkEdit1.Visible = false;
                    lblTags1.Visible = false;
                    break;
                case 2:
                    lnkItem2.Visible = false;
                    lblDate2.Visible = false;
                    lnkEdit2.Visible = false;
                    lblTags2.Visible = false;
                    break;
                case 3:
                    lnkItem3.Visible = false;
                    lblDate3.Visible = false;
                    lnkEdit3.Visible = false;
                    lblTags3.Visible = false;
                    break;
                case 4:
                    lnkItem4.Visible = false;
                    lblDate4.Visible = false;
                    lnkEdit4.Visible = false;
                    lblTags4.Visible = false;
                    break;
                case 5:
                    lnkItem5.Visible = false;
                    lblDate5.Visible = false;
                    lnkEdit5.Visible = false;
                    lblTags5.Visible = false;
                    break;
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            currentPageIndex--;
            if (currentPageIndex < 1)
            {
                currentPageIndex = 1;
            }
            for (int i = 1; i <= 5; i++)
            {
                ClearLinkText(i);
                MakeLinkInvisible(i);
            }
            AddItemsToNewPage(currentPageIndex);
        }
        
        private void makeEditForm(int editIndex)
        {
            editForm editForm = new editForm(Item.itemsTotal[editIndex], editIndex, Item.itemType[editIndex]);

           
            editForm.Text = $"Edit {Item.itemType[editIndex]}: {Item.itemsTotal[editIndex].Name}";
            editForm.ShowDialog();
            Item.Edit(Item.itemsTotal[editIndex], editForm.editName, editForm.editDescription, editForm.editTags);
            
        }

        private void lnkEdit1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int editIndex = ((currentPageIndex - 1) * 5);
            makeEditForm(editIndex);
            UpdateText(editIndex + 1);
        }

        private void lnkEdit2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int editIndex = ((currentPageIndex - 1) * 5) + 1;
            makeEditForm(editIndex);
            UpdateText(editIndex + 1);
        }

        private void lnkEdit3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int editIndex = ((currentPageIndex - 1) * 5) + 2;
            makeEditForm(editIndex);
            UpdateText(editIndex + 1);
        }

        private void lnkEdit4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int editIndex = ((currentPageIndex - 1) * 5) + 3;
            makeEditForm(editIndex);
            UpdateText(editIndex + 1);

        }

        private void lnkEdit5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int editIndex = ((currentPageIndex - 1) * 5) + 4;
            makeEditForm(editIndex);
            UpdateText(editIndex + 1);

        }
    }
}
