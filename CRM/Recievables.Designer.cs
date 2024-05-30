namespace CRM
{
    partial class Recievables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recievables));
            dataGridView1 = new DataGridView();
            Month = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Penalty = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btn_UpdateRecievable = new Button();
            btn_DeleteRecievable = new Button();
            btn_AddAmtPen = new Button();
            label7 = new Label();
            label10 = new Label();
            lbl_OverAllTotal = new Label();
            Lbl_RecAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Month, Amount, Penalty, Total });
            dataGridView1.Location = new Point(223, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(462, 478);
            dataGridView1.TabIndex = 70;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Month
            // 
            Month.HeaderText = "Month";
            Month.Name = "Month";
            Month.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Penalty
            // 
            Penalty.HeaderText = "Penalty";
            Penalty.Name = "Penalty";
            Penalty.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // btn_UpdateRecievable
            // 
            btn_UpdateRecievable.BackColor = Color.DarkTurquoise;
            btn_UpdateRecievable.Image = (Image)resources.GetObject("btn_UpdateRecievable.Image");
            btn_UpdateRecievable.ImageAlign = ContentAlignment.MiddleRight;
            btn_UpdateRecievable.Location = new Point(46, 249);
            btn_UpdateRecievable.Name = "btn_UpdateRecievable";
            btn_UpdateRecievable.Size = new Size(102, 45);
            btn_UpdateRecievable.TabIndex = 76;
            btn_UpdateRecievable.Text = "UPDATE";
            btn_UpdateRecievable.TextAlign = ContentAlignment.MiddleLeft;
            btn_UpdateRecievable.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteRecievable
            // 
            btn_DeleteRecievable.BackColor = Color.DarkTurquoise;
            btn_DeleteRecievable.Image = (Image)resources.GetObject("btn_DeleteRecievable.Image");
            btn_DeleteRecievable.ImageAlign = ContentAlignment.MiddleRight;
            btn_DeleteRecievable.Location = new Point(46, 300);
            btn_DeleteRecievable.Name = "btn_DeleteRecievable";
            btn_DeleteRecievable.Size = new Size(102, 45);
            btn_DeleteRecievable.TabIndex = 75;
            btn_DeleteRecievable.Text = "DELETE";
            btn_DeleteRecievable.TextAlign = ContentAlignment.MiddleLeft;
            btn_DeleteRecievable.UseVisualStyleBackColor = false;
            btn_DeleteRecievable.Click += btn_DeleteRecievable_Click;
            // 
            // btn_AddAmtPen
            // 
            btn_AddAmtPen.BackColor = Color.DarkTurquoise;
            btn_AddAmtPen.Image = (Image)resources.GetObject("btn_AddAmtPen.Image");
            btn_AddAmtPen.ImageAlign = ContentAlignment.MiddleRight;
            btn_AddAmtPen.Location = new Point(46, 198);
            btn_AddAmtPen.Name = "btn_AddAmtPen";
            btn_AddAmtPen.Size = new Size(102, 45);
            btn_AddAmtPen.TabIndex = 74;
            btn_AddAmtPen.Text = "ADD RECIEVABLE AMT.";
            btn_AddAmtPen.TextAlign = ContentAlignment.MiddleLeft;
            btn_AddAmtPen.UseVisualStyleBackColor = false;
            btn_AddAmtPen.Click += btn_AddAmtPen_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 18);
            label7.Name = "label7";
            label7.Size = new Size(167, 37);
            label7.TabIndex = 77;
            label7.Text = "Recievables";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(267, 28);
            label10.Name = "label10";
            label10.Size = new Size(228, 37);
            label10.TabIndex = 79;
            label10.Text = "TOTAL AMOUNT:";
            // 
            // lbl_OverAllTotal
            // 
            lbl_OverAllTotal.AutoSize = true;
            lbl_OverAllTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_OverAllTotal.ForeColor = Color.Red;
            lbl_OverAllTotal.Location = new Point(471, 19);
            lbl_OverAllTotal.Name = "lbl_OverAllTotal";
            lbl_OverAllTotal.Size = new Size(0, 37);
            lbl_OverAllTotal.TabIndex = 78;
            // 
            // Lbl_RecAmount
            // 
            Lbl_RecAmount.AutoSize = true;
            Lbl_RecAmount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Lbl_RecAmount.ForeColor = Color.Red;
            Lbl_RecAmount.Location = new Point(501, 28);
            Lbl_RecAmount.Name = "Lbl_RecAmount";
            Lbl_RecAmount.Size = new Size(159, 37);
            Lbl_RecAmount.TabIndex = 80;
            Lbl_RecAmount.Text = "568,973.99";
            Lbl_RecAmount.Click += Lbl_RecAmount_Click;
            // 
            // Recievables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(735, 579);
            Controls.Add(Lbl_RecAmount);
            Controls.Add(label10);
            Controls.Add(lbl_OverAllTotal);
            Controls.Add(label7);
            Controls.Add(btn_UpdateRecievable);
            Controls.Add(btn_DeleteRecievable);
            Controls.Add(btn_AddAmtPen);
            Controls.Add(dataGridView1);
            Name = "Recievables";
            Text = "Recievables";
            Load += Recievables_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Penalty;
        private DataGridViewTextBoxColumn Total;
        private Button btn_UpdateRecievable;
        private Button btn_DeleteRecievable;
        private Button btn_AddAmtPen;
        private Label label7;
        private Label label10;
        private Label lbl_OverAllTotal;
        private Label Lbl_RecAmount;
    }
}