namespace RestaurantTerminalSystem.UI.Forms.AdminForms
{
    partial class AdminEmployeeForm
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
            label1 = new Label();
            txtEmployeeName = new TextBox();
            txtEmployeeSurname = new TextBox();
            label2 = new Label();
            txtPosition = new TextBox();
            label3 = new Label();
            lstList = new ListBox();
            txtPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(210, 370);
            btnList.Click += btnList_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(29, 370);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(210, 235);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 235);
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 11;
            label1.Text = "Çalışan Adı";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(29, 41);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(281, 23);
            txtEmployeeName.TabIndex = 12;
            // 
            // txtEmployeeSurname
            // 
            txtEmployeeSurname.Location = new Point(29, 91);
            txtEmployeeSurname.Name = "txtEmployeeSurname";
            txtEmployeeSurname.Size = new Size(281, 23);
            txtEmployeeSurname.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 13;
            label2.Text = "Çalışan Soyadı";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(29, 145);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(281, 23);
            txtPosition.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 127);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 15;
            label3.Text = "Pozisyonu";
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 15;
            lstList.Location = new Point(328, 41);
            lstList.Name = "lstList";
            lstList.Size = new Size(308, 379);
            lstList.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(281, 23);
            txtPassword.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 173);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 18;
            label4.Text = "Personel Şifresi";
            // 
            // AdminEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 498);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(lstList);
            Controls.Add(txtPosition);
            Controls.Add(label3);
            Controls.Add(txtEmployeeSurname);
            Controls.Add(label2);
            Controls.Add(txtEmployeeName);
            Controls.Add(label1);
            Name = "AdminEmployeeForm";
            Text = "AdminEmployeeForm";
            Load += AdminEmployeeForm_Load;
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnDelete, 0);
            Controls.SetChildIndex(btnUpdate, 0);
            Controls.SetChildIndex(btnList, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtEmployeeName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtEmployeeSurname, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtPosition, 0);
            Controls.SetChildIndex(lstList, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtPassword, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmployeeName;
        private TextBox txtEmployeeSurname;
        private Label label2;
        private TextBox txtPosition;
        private Label label3;
        private ListBox lstList;
        private TextBox txtPassword;
        private Label label4;
    }
}