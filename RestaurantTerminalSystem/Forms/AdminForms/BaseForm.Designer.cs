namespace RestaurantTerminalSystem.UI.Forms.AdminForms
{
    partial class BaseForm
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
            btnList = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(193, 381);
            btnList.Name = "btnList";
            btnList.Size = new Size(100, 57);
            btnList.TabIndex = 10;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 57);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(193, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 57);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 57);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnList);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "BaseForm";
            Text = "BaseForm";
            ResumeLayout(false);
        }

        #endregion

        protected Button btnList;
        protected Button btnUpdate;
        protected Button btnDelete;
        protected Button btnAdd;
    }
}