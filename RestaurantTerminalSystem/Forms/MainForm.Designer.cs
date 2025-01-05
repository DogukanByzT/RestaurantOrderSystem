
namespace RestaurantTerminalSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            btnAdmin = new Button();
            pnlBasket = new Panel();
            pnlHeader = new Panel();
            button2 = new Button();
            lblTotal = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlBasket.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 55, 69);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 563);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(0, 100);
            button1.Name = "button1";
            button1.Size = new Size(161, 52);
            button1.TabIndex = 1;
            button1.Text = "İçecekler";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdmin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 100);
            panel2.TabIndex = 0;
            // 
            // btnAdmin
            // 
            btnAdmin.BackgroundImage = (Image)resources.GetObject("btnAdmin.BackgroundImage");
            btnAdmin.BackgroundImageLayout = ImageLayout.Center;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(43, 39);
            btnAdmin.TabIndex = 0;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pnlBasket
            // 
            pnlBasket.AutoScroll = true;
            pnlBasket.BackColor = Color.FromArgb(254, 95, 85);
            pnlBasket.Controls.Add(pnlHeader);
            pnlBasket.Dock = DockStyle.Right;
            pnlBasket.Location = new Point(705, 0);
            pnlBasket.Name = "pnlBasket";
            pnlBasket.Size = new Size(200, 563);
            pnlBasket.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(button2);
            pnlHeader.Controls.Add(lblTotal);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(200, 76);
            pnlHeader.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(60, 36);
            button2.Name = "button2";
            button2.Size = new Size(74, 22);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(60, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(74, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Toplam tutar";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(161, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(544, 563);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(905, 563);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlBasket);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlBasket.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel pnlBasket;
        private Panel pnlHeader;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Label lblTotal;
        private Button btnAdmin;
    }
}
