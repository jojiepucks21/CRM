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
            Lbl_Status = new Label();
            Lbl_ConsumerName = new Label();
            Lbl_AcountNumber = new Label();
            label6 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            Lbl_MeterNumber = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Month, Amount, Penalty, Total });
            dataGridView1.Location = new Point(427, 78);
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
            btn_UpdateRecievable.Location = new Point(165, 446);
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
            btn_DeleteRecievable.Location = new Point(165, 511);
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
            btn_AddAmtPen.Location = new Point(165, 383);
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
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 18);
            label7.Name = "label7";
            label7.Size = new Size(158, 37);
            label7.TabIndex = 77;
            label7.Text = "Recievables";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(427, 18);
            label10.Name = "label10";
            label10.Size = new Size(258, 37);
            label10.TabIndex = 79;
            label10.Text = "OVERALL AMOUNT:";
            // 
            // lbl_OverAllTotal
            // 
            lbl_OverAllTotal.AutoSize = true;
            lbl_OverAllTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_OverAllTotal.ForeColor = Color.Red;
            lbl_OverAllTotal.Location = new Point(661, 9);
            lbl_OverAllTotal.Name = "lbl_OverAllTotal";
            lbl_OverAllTotal.Size = new Size(0, 37);
            lbl_OverAllTotal.TabIndex = 78;
            // 
            // Lbl_RecAmount
            // 
            Lbl_RecAmount.AutoSize = true;
            Lbl_RecAmount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Lbl_RecAmount.ForeColor = Color.Red;
            Lbl_RecAmount.Location = new Point(691, 18);
            Lbl_RecAmount.Name = "Lbl_RecAmount";
            Lbl_RecAmount.Size = new Size(159, 37);
            Lbl_RecAmount.TabIndex = 80;
            Lbl_RecAmount.Text = "568,973.99";
            Lbl_RecAmount.Click += Lbl_RecAmount_Click;
            // 
            // Lbl_Status
            // 
            Lbl_Status.AutoSize = true;
            Lbl_Status.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Lbl_Status.ForeColor = Color.WhiteSmoke;
            Lbl_Status.Location = new Point(165, 279);
            Lbl_Status.Name = "Lbl_Status";
            Lbl_Status.Size = new Size(72, 25);
            Lbl_Status.TabIndex = 88;
            Lbl_Status.Text = "label18";
            // 
            // Lbl_ConsumerName
            // 
            Lbl_ConsumerName.AutoSize = true;
            Lbl_ConsumerName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Lbl_ConsumerName.ForeColor = Color.WhiteSmoke;
            Lbl_ConsumerName.Location = new Point(165, 157);
            Lbl_ConsumerName.Name = "Lbl_ConsumerName";
            Lbl_ConsumerName.Size = new Size(72, 25);
            Lbl_ConsumerName.TabIndex = 86;
            Lbl_ConsumerName.Text = "label16";
            // 
            // Lbl_AcountNumber
            // 
            Lbl_AcountNumber.AutoSize = true;
            Lbl_AcountNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Lbl_AcountNumber.ForeColor = Color.WhiteSmoke;
            Lbl_AcountNumber.Location = new Point(165, 101);
            Lbl_AcountNumber.Name = "Lbl_AcountNumber";
            Lbl_AcountNumber.Size = new Size(72, 25);
            Lbl_AcountNumber.TabIndex = 85;
            Lbl_AcountNumber.Text = "label15";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(120, 258);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 84;
            label6.Text = "Status:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(55, 195);
            label12.Name = "label12";
            label12.Size = new Size(146, 25);
            label12.TabIndex = 83;
            label12.Text = "Meter Number:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(44, 136);
            label13.Name = "label13";
            label13.Size = new Size(161, 25);
            label13.TabIndex = 82;
            label13.Text = "Consumer Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(39, 78);
            label14.Name = "label14";
            label14.Size = new Size(165, 25);
            label14.TabIndex = 81;
            label14.Text = "Account Number:";
            // 
            // Lbl_MeterNumber
            // 
            Lbl_MeterNumber.AutoSize = true;
            Lbl_MeterNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Lbl_MeterNumber.ForeColor = Color.WhiteSmoke;
            Lbl_MeterNumber.Location = new Point(165, 216);
            Lbl_MeterNumber.Name = "Lbl_MeterNumber";
            Lbl_MeterNumber.Size = new Size(71, 25);
            Lbl_MeterNumber.TabIndex = 87;
            Lbl_MeterNumber.Text = "label17";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(712, 559);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 89;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(775, 559);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 90;
            label2.Text = "568,973.99";
            // 
            // Recievables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(935, 614);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lbl_Status);
            Controls.Add(Lbl_ConsumerName);
            Controls.Add(Lbl_AcountNumber);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(Lbl_MeterNumber);
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
        private Label Lbl_Status;
        private Label Lbl_ConsumerName;
        private Label Lbl_AcountNumber;
        private Label label6;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label Lbl_MeterNumber;
        private Label label1;
        private Label label2;
    }
}