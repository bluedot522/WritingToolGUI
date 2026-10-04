namespace WritingToolGUI
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnAddCharacter = new Button();
            btnAddProject = new Button();
            chkLatest = new CheckBox();
            chkCharacter = new CheckBox();
            chkProject = new CheckBox();
            chkArchive = new CheckBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            grpCollection = new GroupBox();
            grpItemsDates = new GroupBox();
            btnNext = new Button();
            btnBack = new Button();
            lblTags5 = new Label();
            lblTags4 = new Label();
            lblTags3 = new Label();
            lblTags2 = new Label();
            lblTags1 = new Label();
            lnkEdit5 = new LinkLabel();
            lnkEdit4 = new LinkLabel();
            lnkEdit3 = new LinkLabel();
            lnkEdit2 = new LinkLabel();
            lnkEdit1 = new LinkLabel();
            lblDate5 = new Label();
            lblDate4 = new Label();
            lblDate3 = new Label();
            lblDate2 = new Label();
            lblDate1 = new Label();
            lnkItem1 = new LinkLabel();
            lnkItem5 = new LinkLabel();
            lnkItem2 = new LinkLabel();
            lnkItem4 = new LinkLabel();
            lnkItem3 = new LinkLabel();
            lblCollection = new Label();
            btnQuit = new Button();
            grpCollection.SuspendLayout();
            grpItemsDates.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(6, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(261, 15);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome! Add Characters or Projects to begin.";
            // 
            // btnAddCharacter
            // 
            btnAddCharacter.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCharacter.Location = new Point(399, 330);
            btnAddCharacter.Name = "btnAddCharacter";
            btnAddCharacter.Size = new Size(109, 37);
            btnAddCharacter.TabIndex = 2;
            btnAddCharacter.Text = "Add Character";
            btnAddCharacter.UseVisualStyleBackColor = true;
            btnAddCharacter.Click += btnAddCharacter_Click;
            // 
            // btnAddProject
            // 
            btnAddProject.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProject.Location = new Point(399, 381);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(109, 35);
            btnAddProject.TabIndex = 3;
            btnAddProject.Text = "Add Project";
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // chkLatest
            // 
            chkLatest.AutoSize = true;
            chkLatest.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLatest.Location = new Point(64, 348);
            chkLatest.Name = "chkLatest";
            chkLatest.Size = new Size(60, 19);
            chkLatest.TabIndex = 5;
            chkLatest.Text = "Latest";
            chkLatest.UseVisualStyleBackColor = true;
            // 
            // chkCharacter
            // 
            chkCharacter.AutoSize = true;
            chkCharacter.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkCharacter.Location = new Point(127, 348);
            chkCharacter.Name = "chkCharacter";
            chkCharacter.Size = new Size(80, 19);
            chkCharacter.TabIndex = 6;
            chkCharacter.Text = "Character";
            chkCharacter.UseVisualStyleBackColor = true;
            // 
            // chkProject
            // 
            chkProject.AutoSize = true;
            chkProject.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkProject.Location = new Point(210, 348);
            chkProject.Name = "chkProject";
            chkProject.Size = new Size(64, 19);
            chkProject.TabIndex = 7;
            chkProject.Text = "Project";
            chkProject.UseVisualStyleBackColor = true;
            // 
            // chkArchive
            // 
            chkArchive.AutoSize = true;
            chkArchive.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkArchive.Location = new Point(279, 348);
            chkArchive.Name = "chkArchive";
            chkArchive.Size = new Size(65, 19);
            chkArchive.TabIndex = 8;
            chkArchive.Text = "Archive";
            chkArchive.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(64, 388);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 21);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(221, 384);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 35);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(291, 385);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(62, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // grpCollection
            // 
            grpCollection.Controls.Add(grpItemsDates);
            grpCollection.Controls.Add(lblCollection);
            grpCollection.Location = new Point(64, 12);
            grpCollection.Name = "grpCollection";
            grpCollection.Size = new Size(444, 302);
            grpCollection.TabIndex = 10;
            grpCollection.TabStop = false;
            // 
            // grpItemsDates
            // 
            grpItemsDates.Controls.Add(btnNext);
            grpItemsDates.Controls.Add(btnBack);
            grpItemsDates.Controls.Add(lblTags5);
            grpItemsDates.Controls.Add(lblTags4);
            grpItemsDates.Controls.Add(lblWelcome);
            grpItemsDates.Controls.Add(lblTags3);
            grpItemsDates.Controls.Add(lblTags2);
            grpItemsDates.Controls.Add(lblTags1);
            grpItemsDates.Controls.Add(lnkEdit5);
            grpItemsDates.Controls.Add(lnkEdit4);
            grpItemsDates.Controls.Add(lnkEdit3);
            grpItemsDates.Controls.Add(lnkEdit2);
            grpItemsDates.Controls.Add(lnkEdit1);
            grpItemsDates.Controls.Add(lblDate5);
            grpItemsDates.Controls.Add(lblDate4);
            grpItemsDates.Controls.Add(lblDate3);
            grpItemsDates.Controls.Add(lblDate2);
            grpItemsDates.Controls.Add(lblDate1);
            grpItemsDates.Controls.Add(lnkItem1);
            grpItemsDates.Controls.Add(lnkItem5);
            grpItemsDates.Controls.Add(lnkItem2);
            grpItemsDates.Controls.Add(lnkItem4);
            grpItemsDates.Controls.Add(lnkItem3);
            grpItemsDates.Location = new Point(15, 37);
            grpItemsDates.Name = "grpItemsDates";
            grpItemsDates.Size = new Size(411, 250);
            grpItemsDates.TabIndex = 11;
            grpItemsDates.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(343, 209);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(62, 23);
            btnNext.TabIndex = 32;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(6, 209);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(62, 23);
            btnBack.TabIndex = 33;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblTags5
            // 
            lblTags5.AutoSize = true;
            lblTags5.Location = new Point(196, 175);
            lblTags5.Name = "lblTags5";
            lblTags5.Size = new Size(41, 15);
            lblTags5.TabIndex = 31;
            lblTags5.Text = "label1";
            lblTags5.Visible = false;
            // 
            // lblTags4
            // 
            lblTags4.AutoSize = true;
            lblTags4.Location = new Point(196, 144);
            lblTags4.Name = "lblTags4";
            lblTags4.Size = new Size(41, 15);
            lblTags4.TabIndex = 27;
            lblTags4.Text = "label1";
            lblTags4.Visible = false;
            // 
            // lblTags3
            // 
            lblTags3.AutoSize = true;
            lblTags3.Location = new Point(196, 112);
            lblTags3.Name = "lblTags3";
            lblTags3.Size = new Size(41, 15);
            lblTags3.TabIndex = 23;
            lblTags3.Text = "label1";
            lblTags3.Visible = false;
            // 
            // lblTags2
            // 
            lblTags2.AutoSize = true;
            lblTags2.Location = new Point(196, 81);
            lblTags2.Name = "lblTags2";
            lblTags2.Size = new Size(41, 15);
            lblTags2.TabIndex = 19;
            lblTags2.Text = "label1";
            lblTags2.Visible = false;
            // 
            // lblTags1
            // 
            lblTags1.AutoSize = true;
            lblTags1.Location = new Point(196, 54);
            lblTags1.Name = "lblTags1";
            lblTags1.Size = new Size(41, 15);
            lblTags1.TabIndex = 15;
            lblTags1.Text = "label1";
            lblTags1.Visible = false;
            // 
            // lnkEdit5
            // 
            lnkEdit5.AutoSize = true;
            lnkEdit5.Location = new Point(142, 175);
            lnkEdit5.Name = "lnkEdit5";
            lnkEdit5.Size = new Size(28, 15);
            lnkEdit5.TabIndex = 30;
            lnkEdit5.TabStop = true;
            lnkEdit5.Text = "Edit";
            lnkEdit5.Visible = false;
            // 
            // lnkEdit4
            // 
            lnkEdit4.AutoSize = true;
            lnkEdit4.Location = new Point(142, 144);
            lnkEdit4.Name = "lnkEdit4";
            lnkEdit4.Size = new Size(28, 15);
            lnkEdit4.TabIndex = 26;
            lnkEdit4.TabStop = true;
            lnkEdit4.Text = "Edit";
            lnkEdit4.Visible = false;
            // 
            // lnkEdit3
            // 
            lnkEdit3.AutoSize = true;
            lnkEdit3.Location = new Point(142, 112);
            lnkEdit3.Name = "lnkEdit3";
            lnkEdit3.Size = new Size(28, 15);
            lnkEdit3.TabIndex = 22;
            lnkEdit3.TabStop = true;
            lnkEdit3.Text = "Edit";
            lnkEdit3.Visible = false;
            // 
            // lnkEdit2
            // 
            lnkEdit2.AutoSize = true;
            lnkEdit2.Location = new Point(142, 81);
            lnkEdit2.Name = "lnkEdit2";
            lnkEdit2.Size = new Size(28, 15);
            lnkEdit2.TabIndex = 18;
            lnkEdit2.TabStop = true;
            lnkEdit2.Text = "Edit";
            lnkEdit2.Visible = false;
            // 
            // lnkEdit1
            // 
            lnkEdit1.AutoSize = true;
            lnkEdit1.Location = new Point(142, 54);
            lnkEdit1.Name = "lnkEdit1";
            lnkEdit1.Size = new Size(28, 15);
            lnkEdit1.TabIndex = 14;
            lnkEdit1.TabStop = true;
            lnkEdit1.Text = "Edit";
            lnkEdit1.Visible = false;
            // 
            // lblDate5
            // 
            lblDate5.AutoSize = true;
            lblDate5.Location = new Point(70, 175);
            lblDate5.Name = "lblDate5";
            lblDate5.Size = new Size(41, 15);
            lblDate5.TabIndex = 29;
            lblDate5.Text = "label1";
            lblDate5.Visible = false;
            // 
            // lblDate4
            // 
            lblDate4.AutoSize = true;
            lblDate4.Location = new Point(70, 144);
            lblDate4.Name = "lblDate4";
            lblDate4.Size = new Size(41, 15);
            lblDate4.TabIndex = 25;
            lblDate4.Text = "label1";
            lblDate4.Visible = false;
            // 
            // lblDate3
            // 
            lblDate3.AutoSize = true;
            lblDate3.Location = new Point(70, 112);
            lblDate3.Name = "lblDate3";
            lblDate3.Size = new Size(41, 15);
            lblDate3.TabIndex = 21;
            lblDate3.Text = "label1";
            lblDate3.Visible = false;
            // 
            // lblDate2
            // 
            lblDate2.AutoSize = true;
            lblDate2.Location = new Point(70, 81);
            lblDate2.Name = "lblDate2";
            lblDate2.Size = new Size(41, 15);
            lblDate2.TabIndex = 17;
            lblDate2.Text = "label1";
            lblDate2.Visible = false;
            // 
            // lblDate1
            // 
            lblDate1.AutoSize = true;
            lblDate1.Location = new Point(70, 54);
            lblDate1.Name = "lblDate1";
            lblDate1.Size = new Size(41, 15);
            lblDate1.TabIndex = 13;
            lblDate1.Text = "label1";
            lblDate1.Visible = false;
            // 
            // lnkItem1
            // 
            lnkItem1.AutoSize = true;
            lnkItem1.Location = new Point(4, 54);
            lnkItem1.Name = "lnkItem1";
            lnkItem1.Size = new Size(64, 15);
            lnkItem1.TabIndex = 12;
            lnkItem1.TabStop = true;
            lnkItem1.Text = "linkLabel1";
            lnkItem1.Visible = false;
            // 
            // lnkItem5
            // 
            lnkItem5.AutoSize = true;
            lnkItem5.Location = new Point(4, 175);
            lnkItem5.Name = "lnkItem5";
            lnkItem5.Size = new Size(64, 15);
            lnkItem5.TabIndex = 28;
            lnkItem5.TabStop = true;
            lnkItem5.Text = "linkLabel1";
            lnkItem5.Visible = false;
            // 
            // lnkItem2
            // 
            lnkItem2.AutoSize = true;
            lnkItem2.Location = new Point(4, 81);
            lnkItem2.Name = "lnkItem2";
            lnkItem2.Size = new Size(64, 15);
            lnkItem2.TabIndex = 16;
            lnkItem2.TabStop = true;
            lnkItem2.Text = "linkLabel1";
            lnkItem2.Visible = false;
            // 
            // lnkItem4
            // 
            lnkItem4.AutoSize = true;
            lnkItem4.Location = new Point(4, 144);
            lnkItem4.Name = "lnkItem4";
            lnkItem4.Size = new Size(64, 15);
            lnkItem4.TabIndex = 24;
            lnkItem4.TabStop = true;
            lnkItem4.Text = "linkLabel1";
            lnkItem4.Visible = false;
            // 
            // lnkItem3
            // 
            lnkItem3.AutoSize = true;
            lnkItem3.Location = new Point(4, 112);
            lnkItem3.Name = "lnkItem3";
            lnkItem3.Size = new Size(64, 15);
            lnkItem3.TabIndex = 20;
            lnkItem3.TabStop = true;
            lnkItem3.Text = "linkLabel1";
            lnkItem3.Visible = false;
            // 
            // lblCollection
            // 
            lblCollection.AutoSize = true;
            lblCollection.Location = new Point(190, 19);
            lblCollection.Name = "lblCollection";
            lblCollection.Size = new Size(62, 15);
            lblCollection.TabIndex = 0;
            lblCollection.Text = "Collection";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(433, 430);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 34);
            btnQuit.TabIndex = 34;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 476);
            Controls.Add(btnQuit);
            Controls.Add(grpCollection);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(chkArchive);
            Controls.Add(chkProject);
            Controls.Add(chkCharacter);
            Controls.Add(chkLatest);
            Controls.Add(btnAddProject);
            Controls.Add(btnAddCharacter);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "mainForm";
            Text = "Writing Project Manager";
            grpCollection.ResumeLayout(false);
            grpCollection.PerformLayout();
            grpItemsDates.ResumeLayout(false);
            grpItemsDates.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnAddCharacter;
        private Button btnAddProject;
        private CheckBox chkLatest;
        private CheckBox chkCharacter;
        private CheckBox chkProject;
        private CheckBox chkArchive;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private GroupBox grpCollection;
        private Label lblCollection;
        private GroupBox grpItemsDates;
        private Label lblDate1;
        private LinkLabel lnkItem1;
        private LinkLabel lnkItem5;
        private LinkLabel lnkItem2;
        private LinkLabel lnkItem4;
        private LinkLabel lnkItem3;
        private LinkLabel lnkEdit5;
        private LinkLabel lnkEdit4;
        private LinkLabel lnkEdit3;
        private LinkLabel lnkEdit2;
        private LinkLabel lnkEdit1;
        private Label lblDate5;
        private Label lblDate4;
        private Label lblDate3;
        private Label lblDate2;
        private Label lblTags5;
        private Label lblTags4;
        private Label lblTags3;
        private Label lblTags2;
        private Label lblTags1;
        private Button btnNext;
        private Button btnBack;
        private Button btnQuit;
    }
}
