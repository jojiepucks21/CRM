namespace CRM
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Lbl_Status = new Label();
            Lbl_ConsumerName = new Label();
            Lbl_AcountNumber = new Label();
            label6 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btn_AddAmtPen = new Button();
            btnFind = new Button();
            Lbl_MeterNumber = new Label();
            DGridView_Amount = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Penalty = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Month = new DataGridViewTextBoxColumn();
            dGridView_Consumer = new DataGridView();
            AccountNo = new DataGridViewTextBoxColumn();
            MeterNo = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txt_search = new TextBox();
            btn_Areas = new Button();
            label5 = new Label();
            cb_area = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            lbl_OverAllTotal = new Label();
            panel1 = new Panel();
            btnAddConsumer = new Button();
            btn_SelectFile = new Button();
            textBox1 = new TextBox();
            btn_Export = new Button();
            button4 = new Button();
            button5 = new Button();
            btn_DeleteRecievable = new Button();
            btn_UpdateRecievable = new Button();
            ((System.ComponentModel.ISupportInitialize)DGridView_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridView_Consumer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Status
            // 
            Lbl_Status.AutoSize = true;
            Lbl_Status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_Status.Location = new Point(148, 374);
            Lbl_Status.Name = "Lbl_Status";
            Lbl_Status.Size = new Size(60, 21);
            Lbl_Status.TabIndex = 62;
            Lbl_Status.Text = "label18";
            // 
            // Lbl_ConsumerName
            // 
            Lbl_ConsumerName.AutoSize = true;
            Lbl_ConsumerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_ConsumerName.Location = new Point(148, 252);
            Lbl_ConsumerName.Name = "Lbl_ConsumerName";
            Lbl_ConsumerName.Size = new Size(60, 21);
            Lbl_ConsumerName.TabIndex = 60;
            Lbl_ConsumerName.Text = "label16";
            // 
            // Lbl_AcountNumber
            // 
            Lbl_AcountNumber.AutoSize = true;
            Lbl_AcountNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_AcountNumber.Location = new Point(148, 196);
            Lbl_AcountNumber.Name = "Lbl_AcountNumber";
            Lbl_AcountNumber.Size = new Size(60, 21);
            Lbl_AcountNumber.TabIndex = 59;
            Lbl_AcountNumber.Text = "label15";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(103, 353);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 58;
            label6.Text = "Status:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(38, 290);
            label12.Name = "label12";
            label12.Size = new Size(124, 21);
            label12.TabIndex = 57;
            label12.Text = "Meter Number:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(27, 231);
            label13.Name = "label13";
            label13.Size = new Size(135, 21);
            label13.TabIndex = 56;
            label13.Text = "Consumer Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(22, 173);
            label14.Name = "label14";
            label14.Size = new Size(140, 21);
            label14.TabIndex = 55;
            label14.Text = "Account Number:";
            // 
            // btn_AddAmtPen
            // 
            btn_AddAmtPen.BackColor = Color.DarkTurquoise;
            btn_AddAmtPen.Image = (Image)resources.GetObject("btn_AddAmtPen.Image");
            btn_AddAmtPen.ImageAlign = ContentAlignment.MiddleRight;
            btn_AddAmtPen.Location = new Point(1484, 217);
            btn_AddAmtPen.Name = "btn_AddAmtPen";
            btn_AddAmtPen.Size = new Size(119, 45);
            btn_AddAmtPen.TabIndex = 54;
            btn_AddAmtPen.Text = "ADD AMT. PEN.";
            btn_AddAmtPen.TextAlign = ContentAlignment.MiddleLeft;
            btn_AddAmtPen.UseVisualStyleBackColor = false;
            btn_AddAmtPen.Click += btn_AddAmtPen_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.DodgerBlue;
            btnFind.Location = new Point(747, 176);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(70, 27);
            btnFind.TabIndex = 53;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // Lbl_MeterNumber
            // 
            Lbl_MeterNumber.AutoSize = true;
            Lbl_MeterNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_MeterNumber.Location = new Point(148, 311);
            Lbl_MeterNumber.Name = "Lbl_MeterNumber";
            Lbl_MeterNumber.Size = new Size(60, 21);
            Lbl_MeterNumber.TabIndex = 61;
            Lbl_MeterNumber.Text = "label17";
            // 
            // DGridView_Amount
            // 
            DGridView_Amount.AllowUserToAddRows = false;
            DGridView_Amount.AllowUserToDeleteRows = false;
            DGridView_Amount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGridView_Amount.Columns.AddRange(new DataGridViewColumn[] { Column8, Penalty, Total, Month });
            DGridView_Amount.Location = new Point(1019, 217);
            DGridView_Amount.Name = "DGridView_Amount";
            DGridView_Amount.ReadOnly = true;
            DGridView_Amount.Size = new Size(443, 511);
            DGridView_Amount.TabIndex = 51;
            DGridView_Amount.CellContentClick += DGridView_Amount_CellContentClick;
            // 
            // Column8
            // 
            Column8.HeaderText = "AMOUNT";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Penalty
            // 
            Penalty.HeaderText = "PENALTY";
            Penalty.Name = "Penalty";
            Penalty.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "TOTAL";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Month
            // 
            Month.HeaderText = "MONTH";
            Month.Name = "Month";
            Month.ReadOnly = true;
            // 
            // dGridView_Consumer
            // 
            dGridView_Consumer.AllowUserToAddRows = false;
            dGridView_Consumer.AllowUserToDeleteRows = false;
            dGridView_Consumer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridView_Consumer.Columns.AddRange(new DataGridViewColumn[] { AccountNo, MeterNo, Name, Status });
            dGridView_Consumer.Location = new Point(373, 217);
            dGridView_Consumer.Name = "dGridView_Consumer";
            dGridView_Consumer.ReadOnly = true;
            dGridView_Consumer.Size = new Size(640, 511);
            dGridView_Consumer.TabIndex = 50;
            dGridView_Consumer.CellContentClick += dGridView_Consumer_CellContentClick;
            // 
            // AccountNo
            // 
            AccountNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AccountNo.HeaderText = "ACCT NO.";
            AccountNo.Name = "AccountNo";
            AccountNo.ReadOnly = true;
            // 
            // MeterNo
            // 
            MeterNo.HeaderText = "METER NO.";
            MeterNo.Name = "MeterNo";
            MeterNo.ReadOnly = true;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "NAME";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "STATUS";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 182);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 49;
            label7.Text = "Search by ID or Name:";
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.LemonChiffon;
            txt_search.Location = new Point(505, 179);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(236, 23);
            txt_search.TabIndex = 48;
            // 
            // btn_Areas
            // 
            btn_Areas.BackColor = Color.DodgerBlue;
            btn_Areas.Location = new Point(38, 101);
            btn_Areas.Name = "btn_Areas";
            btn_Areas.Size = new Size(112, 34);
            btn_Areas.TabIndex = 38;
            btn_Areas.Text = "AREA";
            btn_Areas.UseVisualStyleBackColor = false;
            btn_Areas.Click += btn_Areas_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(175, 109);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 29;
            label5.Text = "SELECT BY AREA:";
            label5.Click += label5_Click;
            // 
            // cb_area
            // 
            cb_area.BackColor = Color.LemonChiffon;
            cb_area.FormattingEnabled = true;
            cb_area.Location = new Point(310, 110);
            cb_area.Name = "cb_area";
            cb_area.Size = new Size(146, 23);
            cb_area.TabIndex = 28;
            cb_area.SelectedIndexChanged += cb_area_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(38, 9);
            label11.Name = "label11";
            label11.Size = new Size(486, 32);
            label11.TabIndex = 2;
            label11.Text = "SUMMARY ACCOUNTS RECIEVABLE BAPA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(1078, 101);
            label10.Name = "label10";
            label10.Size = new Size(203, 32);
            label10.TabIndex = 1;
            label10.Text = "OVERALL TOTAL:";
            // 
            // lbl_OverAllTotal
            // 
            lbl_OverAllTotal.AutoSize = true;
            lbl_OverAllTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_OverAllTotal.ForeColor = Color.Red;
            lbl_OverAllTotal.Location = new Point(1273, 96);
            lbl_OverAllTotal.Name = "lbl_OverAllTotal";
            lbl_OverAllTotal.Size = new Size(159, 37);
            lbl_OverAllTotal.TabIndex = 0;
            lbl_OverAllTotal.Text = "568,973.99";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cb_area);
            panel1.Controls.Add(btn_Areas);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lbl_OverAllTotal);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1633, 156);
            panel1.TabIndex = 47;
            panel1.Paint += panel1_Paint;
            // 
            // btnAddConsumer
            // 
            btnAddConsumer.BackColor = Color.DodgerBlue;
            btnAddConsumer.Image = (Image)resources.GetObject("btnAddConsumer.Image");
            btnAddConsumer.ImageAlign = ContentAlignment.MiddleRight;
            btnAddConsumer.Location = new Point(243, 580);
            btnAddConsumer.Name = "btnAddConsumer";
            btnAddConsumer.Size = new Size(105, 45);
            btnAddConsumer.TabIndex = 66;
            btnAddConsumer.Text = "ADD CONSUMER";
            btnAddConsumer.TextAlign = ContentAlignment.MiddleLeft;
            btnAddConsumer.UseVisualStyleBackColor = false;
            btnAddConsumer.Click += btnAddConsumer_Click_1;
            // 
            // btn_SelectFile
            // 
            btn_SelectFile.BackColor = Color.DodgerBlue;
            btn_SelectFile.Location = new Point(35, 460);
            btn_SelectFile.Name = "btn_SelectFile";
            btn_SelectFile.Size = new Size(87, 34);
            btn_SelectFile.TabIndex = 63;
            btn_SelectFile.Text = "IMPORT FILE";
            btn_SelectFile.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.Location = new Point(128, 467);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 64;
            // 
            // btn_Export
            // 
            btn_Export.BackColor = Color.DodgerBlue;
            btn_Export.Location = new Point(35, 509);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(87, 34);
            btn_Export.TabIndex = 67;
            btn_Export.Text = "EXPORT FILE";
            btn_Export.UseVisualStyleBackColor = false;
            btn_Export.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(243, 633);
            button4.Name = "button4";
            button4.Size = new Size(105, 45);
            button4.TabIndex = 68;
            button4.Text = "UPDATE CONSUMER";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(243, 684);
            button5.Name = "button5";
            button5.Size = new Size(105, 45);
            button5.TabIndex = 69;
            button5.Text = "DELETE CONSUMER";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteRecievable
            // 
            btn_DeleteRecievable.BackColor = Color.DarkTurquoise;
            btn_DeleteRecievable.Image = (Image)resources.GetObject("btn_DeleteRecievable.Image");
            btn_DeleteRecievable.ImageAlign = ContentAlignment.MiddleRight;
            btn_DeleteRecievable.Location = new Point(1484, 319);
            btn_DeleteRecievable.Name = "btn_DeleteRecievable";
            btn_DeleteRecievable.Size = new Size(119, 45);
            btn_DeleteRecievable.TabIndex = 70;
            btn_DeleteRecievable.Text = "DELETE";
            btn_DeleteRecievable.TextAlign = ContentAlignment.MiddleLeft;
            btn_DeleteRecievable.UseVisualStyleBackColor = false;
            // 
            // btn_UpdateRecievable
            // 
            btn_UpdateRecievable.BackColor = Color.DarkTurquoise;
            btn_UpdateRecievable.Image = (Image)resources.GetObject("btn_UpdateRecievable.Image");
            btn_UpdateRecievable.ImageAlign = ContentAlignment.MiddleRight;
            btn_UpdateRecievable.Location = new Point(1484, 268);
            btn_UpdateRecievable.Name = "btn_UpdateRecievable";
            btn_UpdateRecievable.Size = new Size(119, 45);
            btn_UpdateRecievable.TabIndex = 71;
            btn_UpdateRecievable.Text = "UPDATE";
            btn_UpdateRecievable.TextAlign = ContentAlignment.MiddleLeft;
            btn_UpdateRecievable.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 760);
            Controls.Add(btn_UpdateRecievable);
            Controls.Add(btn_DeleteRecievable);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btn_Export);
            Controls.Add(btnAddConsumer);
            Controls.Add(textBox1);
            Controls.Add(btn_SelectFile);
            Controls.Add(Lbl_Status);
            Controls.Add(Lbl_ConsumerName);
            Controls.Add(Lbl_AcountNumber);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(btn_AddAmtPen);
            Controls.Add(btnFind);
            Controls.Add(Lbl_MeterNumber);
            Controls.Add(DGridView_Amount);
            Controls.Add(dGridView_Consumer);
            Controls.Add(label7);
            Controls.Add(txt_search);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)DGridView_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridView_Consumer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Status;
        private Label Lbl_ConsumerName;
        private Label Lbl_AcountNumber;
        private Label label6;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btn_AddAmtPen;
        private Button btnFind;
        private Label Lbl_MeterNumber;
        private DataGridView DGridView_Amount;
        private DataGridView dGridView_Consumer;
        private Label label7;
        private TextBox txt_search;
        private Button btn_Areas;
        private Label label5;
        private ComboBox cb_area;
        private Label label11;
        private Label label10;
        private Label lbl_OverAllTotal;
        private Panel panel1;
        private Button btn_SelectFile;
        private TextBox textBox1;
        private Button btnAddConsumer;
        private Button btn_Export;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Penalty;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn AccountNo;
        private DataGridViewTextBoxColumn MeterNo;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Status;
        private Button btn_DeleteRecievable;
        private Button btn_UpdateRecievable;
    }
}