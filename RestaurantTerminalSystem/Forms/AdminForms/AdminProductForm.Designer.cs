namespace RestaurantTerminalSystem.UI.Forms.AdminForms
{
    partial class AdminProductForm
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
            openFileDialog1 = new OpenFileDialog();
            cmbCategories = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnPicture = new Button();
            txtPicture = new TextBox();
            label4 = new Label();
            lstList = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(460, 115);
            btnList.Click += btnList_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(279, 115);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(460, 45);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(279, 45);
            btnAdd.Click += btnAdd_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(40, 149);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(221, 23);
            cmbCategories.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 131);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 12;
            label1.Text = "Ürünün Kategorisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 35);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 13;
            label2.Text = "Ürün Adı";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(40, 53);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(221, 23);
            txtProductName.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(40, 99);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(221, 23);
            txtPrice.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 81);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 15;
            label3.Text = "Fiyatı";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnPicture
            // 
            btnPicture.Location = new Point(40, 356);
            btnPicture.Name = "btnPicture";
            btnPicture.Size = new Size(102, 73);
            btnPicture.TabIndex = 18;
            btnPicture.Text = "Resim Seç";
            btnPicture.UseVisualStyleBackColor = true;
            btnPicture.Click += btnPicture_Click;
            // 
            // txtPicture
            // 
            txtPicture.Location = new Point(40, 311);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new Size(221, 23);
            txtPicture.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 293);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 19;
            label4.Text = "Ürün Resimi";
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 15;
            lstList.Location = new Point(279, 178);
            lstList.Name = "lstList";
            lstList.Size = new Size(281, 244);
            lstList.TabIndex = 21;
            // 
            // AdminProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstList);
            Controls.Add(txtPicture);
            Controls.Add(label4);
            Controls.Add(btnPicture);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategories);
            Name = "AdminProductForm";
            Text = "AdminProductForm";
            Load += AdminProductForm_Load;
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnDelete, 0);
            Controls.SetChildIndex(btnUpdate, 0);
            Controls.SetChildIndex(btnList, 0);
            Controls.SetChildIndex(cmbCategories, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtProductName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtPrice, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(btnPicture, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtPicture, 0);
            Controls.SetChildIndex(lstList, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ComboBox cmbCategories;
        private Label label1;
        private Label label2;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnPicture;
        private TextBox txtPicture;
        private Label label4;
        private ListBox lstList;
    }
}