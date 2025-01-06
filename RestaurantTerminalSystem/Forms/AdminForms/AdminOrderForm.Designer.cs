namespace RestaurantTerminalSystem.UI.Forms.AdminForms
{
    partial class AdminOrderForm
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
            dgvOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(664, 148);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(483, 148);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(664, 13);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(483, 13);
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(3, 12);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.Size = new Size(439, 426);
            dgvOrder.TabIndex = 11;
            // 
            // AdminOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOrder);
            Name = "AdminOrderForm";
            Text = "AdminOrderForm";
            Load += AdminOrderForm_Load;
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnDelete, 0);
            Controls.SetChildIndex(btnUpdate, 0);
            Controls.SetChildIndex(btnList, 0);
            Controls.SetChildIndex(dgvOrder, 0);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrder;
    }
}