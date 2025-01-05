

namespace RestaurantTerminalSystem.UI.Forms
{
    partial class AdminForm
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnAdminCategories = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pnlForm = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(199, 239, 207);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAdminCategories);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(0, 350);
            button5.Name = "button5";
            button5.Size = new Size(200, 50);
            button5.TabIndex = 7;
            button5.Text = "Masaları Yönet";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(0, 300);
            button4.Name = "button4";
            button4.Size = new Size(200, 50);
            button4.TabIndex = 6;
            button4.Text = "Sipariş Detayları";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(0, 250);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 5;
            button3.Text = "Siparişleri Yönet";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(0, 200);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 4;
            button2.Text = "Çalışanları Yönet";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(0, 150);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 3;
            button1.Text = "Ürünleri Yönet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAdminCategories
            // 
            btnAdminCategories.Dock = DockStyle.Top;
            btnAdminCategories.FlatStyle = FlatStyle.Flat;
            btnAdminCategories.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdminCategories.Location = new Point(0, 100);
            btnAdminCategories.Name = "btnAdminCategories";
            btnAdminCategories.Size = new Size(200, 50);
            btnAdminCategories.TabIndex = 2;
            btnAdminCategories.Text = "Kategorileri Yönet";
            btnAdminCategories.UseVisualStyleBackColor = true;
            btnAdminCategories.Click += btnAdminCategories_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 74);
            label1.TabIndex = 0;
            label1.Text = "Restoran Sipariş Sistemi Admin Paneli";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlForm
            // 
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(200, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(600, 450);
            pnlForm.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlForm);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }




        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnAdminCategories;
        private Label label1;
        private Panel pnlForm;
    }
}