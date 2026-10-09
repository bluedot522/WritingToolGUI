namespace WritingToolGUI
{
    partial class infoForm
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
            lblInfoName = new Label();
            lblInfoDescription = new Label();
            btnInfoEdit = new Button();
            SuspendLayout();
            // 
            // lblInfoName
            // 
            lblInfoName.AutoSize = true;
            lblInfoName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoName.Location = new Point(38, 49);
            lblInfoName.Name = "lblInfoName";
            lblInfoName.Size = new Size(50, 18);
            lblInfoName.TabIndex = 0;
            lblInfoName.Text = "label1";
            // 
            // lblInfoDescription
            // 
            lblInfoDescription.AutoSize = true;
            lblInfoDescription.Location = new Point(38, 100);
            lblInfoDescription.Name = "lblInfoDescription";
            lblInfoDescription.Size = new Size(41, 15);
            lblInfoDescription.TabIndex = 1;
            lblInfoDescription.Text = "label1";
            // 
            // btnInfoEdit
            // 
            btnInfoEdit.Location = new Point(301, 390);
            btnInfoEdit.Name = "btnInfoEdit";
            btnInfoEdit.Size = new Size(75, 23);
            btnInfoEdit.TabIndex = 2;
            btnInfoEdit.Text = "Edit";
            btnInfoEdit.UseVisualStyleBackColor = true;
            btnInfoEdit.Click += btnInfoEdit_Click;
            // 
            // infoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 450);
            Controls.Add(btnInfoEdit);
            Controls.Add(lblInfoDescription);
            Controls.Add(lblInfoName);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "infoForm";
            Text = "Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoName;
        private Label lblInfoDescription;
        private Button btnInfoEdit;
    }
}