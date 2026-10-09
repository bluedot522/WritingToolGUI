namespace WritingToolGUI
{
    partial class editForm
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
            lblEditName = new Label();
            txtEditName = new TextBox();
            lblEditDescription = new Label();
            txtEditDescription = new TextBox();
            lblEditInstr = new Label();
            btnEditSubmit = new Button();
            lblEditTags = new Label();
            txtEditTags = new TextBox();
            chkArchive = new CheckBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblEditName
            // 
            lblEditName.AutoSize = true;
            lblEditName.Location = new Point(52, 90);
            lblEditName.Name = "lblEditName";
            lblEditName.Size = new Size(41, 15);
            lblEditName.TabIndex = 0;
            lblEditName.Text = "Name";
            // 
            // txtEditName
            // 
            txtEditName.Location = new Point(96, 87);
            txtEditName.Name = "txtEditName";
            txtEditName.Size = new Size(100, 21);
            txtEditName.TabIndex = 1;
            txtEditName.TextChanged += txtEditName_TextChanged;
            txtEditName.Validating += txtEditName_Validating;
            // 
            // lblEditDescription
            // 
            lblEditDescription.AutoSize = true;
            lblEditDescription.Location = new Point(23, 144);
            lblEditDescription.Name = "lblEditDescription";
            lblEditDescription.Size = new Size(70, 15);
            lblEditDescription.TabIndex = 2;
            lblEditDescription.Text = "Description";
            // 
            // txtEditDescription
            // 
            txtEditDescription.Location = new Point(96, 141);
            txtEditDescription.Multiline = true;
            txtEditDescription.Name = "txtEditDescription";
            txtEditDescription.Size = new Size(340, 209);
            txtEditDescription.TabIndex = 3;
            // 
            // lblEditInstr
            // 
            lblEditInstr.AutoSize = true;
            lblEditInstr.Location = new Point(96, 36);
            lblEditInstr.Name = "lblEditInstr";
            lblEditInstr.Size = new Size(252, 15);
            lblEditInstr.TabIndex = 4;
            lblEditInstr.Text = "Enter information then submit when finished.";
            // 
            // btnEditSubmit
            // 
            btnEditSubmit.Location = new Point(360, 370);
            btnEditSubmit.Name = "btnEditSubmit";
            btnEditSubmit.Size = new Size(76, 30);
            btnEditSubmit.TabIndex = 5;
            btnEditSubmit.Text = "Submit";
            btnEditSubmit.UseVisualStyleBackColor = true;
            btnEditSubmit.Click += btnEditSubmit_Click;
            // 
            // lblEditTags
            // 
            lblEditTags.AutoSize = true;
            lblEditTags.Location = new Point(52, 378);
            lblEditTags.Name = "lblEditTags";
            lblEditTags.Size = new Size(34, 15);
            lblEditTags.TabIndex = 6;
            lblEditTags.Text = "Tags";
            // 
            // txtEditTags
            // 
            txtEditTags.Location = new Point(96, 375);
            txtEditTags.Name = "txtEditTags";
            txtEditTags.Size = new Size(252, 21);
            txtEditTags.TabIndex = 7;
            // 
            // chkArchive
            // 
            chkArchive.AutoSize = true;
            chkArchive.Location = new Point(220, 87);
            chkArchive.Name = "chkArchive";
            chkArchive.Size = new Size(65, 19);
            chkArchive.TabIndex = 8;
            chkArchive.Text = "Archive";
            chkArchive.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.System;
            btnClose.Location = new Point(377, 408);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(59, 30);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // editForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(btnClose);
            Controls.Add(chkArchive);
            Controls.Add(txtEditTags);
            Controls.Add(lblEditTags);
            Controls.Add(btnEditSubmit);
            Controls.Add(lblEditInstr);
            Controls.Add(txtEditDescription);
            Controls.Add(lblEditDescription);
            Controls.Add(txtEditName);
            Controls.Add(lblEditName);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "editForm";
            Text = "Editing";
            Load += editForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditName;
        private TextBox txtEditName;
        private Label lblEditDescription;
        private TextBox txtEditDescription;
        private Label lblEditInstr;
        private Button btnEditSubmit;
        private Label lblEditTags;
        private TextBox txtEditTags;
        private CheckBox chkArchive;
        private Button btnClose;
    }
}