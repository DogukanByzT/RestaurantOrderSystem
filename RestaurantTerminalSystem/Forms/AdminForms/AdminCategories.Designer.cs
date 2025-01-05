namespace RestaurantTerminalSystem.UI.Forms.AdminForms
{
    partial class AdminCategories : BaseForm
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
            txtCategoryName = new TextBox();
            lstList = new ListBox();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(250, 288);
            btnList.Click += btnList_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(69, 288);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(250, 153);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(69, 153);
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 83);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Yeni Kategori Ekle";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(69, 101);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(281, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 15;
            lstList.Location = new Point(391, 101);
            lstList.Name = "lstList";
            lstList.Size = new Size(295, 244);
            lstList.TabIndex = 2;
            // 
            // AdminCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 245, 219);
            ClientSize = new Size(800, 450);
            Controls.Add(lstList);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Name = "AdminCategories";
            Text = "AdminCategories";
            Load += AdminCategories_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCategoryName, 0);
            Controls.SetChildIndex(lstList, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnDelete, 0);
            Controls.SetChildIndex(btnUpdate, 0);
            Controls.SetChildIndex(btnList, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryName;
        private ListBox lstList;
    }
}