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
            Lbl_Status = new Label();
            Lbl_ConsumerName = new Label();
            Lbl_AcountNumber = new Label();
            label6 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnAddAmtPen = new Button();
            btnFind = new Button();
            btnAddConsumer = new Button();
            Lbl_MeterNumber = new Label();
            DGridView_Amount = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Penalty = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Month = new DataGridViewTextBoxColumn();
            Action_Amount = new DataGridViewTextBoxColumn();
            dGridView_Consumer = new DataGridView();
            AccountNo = new DataGridViewTextBoxColumn();
            MeterNo = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ACTIONS = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txt_search = new TextBox();
            btnArea = new Button();
            label5 = new Label();
            cb_area = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            lbl_OverAllTotal = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGridView_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridView_Consumer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Status
            // 
            Lbl_Status.AutoSize = true;
            Lbl_Status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_Status.Location = new Point(149, 360);
            Lbl_Status.Name = "Lbl_Status";
            Lbl_Status.Size = new Size(60, 21);
            Lbl_Status.TabIndex = 62;
            Lbl_Status.Text = "label18";
            // 
            // Lbl_ConsumerName
            // 
            Lbl_ConsumerName.AutoSize = true;
            Lbl_ConsumerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_ConsumerName.Location = new Point(149, 238);
            Lbl_ConsumerName.Name = "Lbl_ConsumerName";
            Lbl_ConsumerName.Size = new Size(60, 21);
            Lbl_ConsumerName.TabIndex = 60;
            Lbl_ConsumerName.Text = "label16";
            // 
            // Lbl_AcountNumber
            // 
            Lbl_AcountNumber.AutoSize = true;
            Lbl_AcountNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_AcountNumber.Location = new Point(149, 182);
            Lbl_AcountNumber.Name = "Lbl_AcountNumber";
            Lbl_AcountNumber.Size = new Size(60, 21);
            Lbl_AcountNumber.TabIndex = 59;
            Lbl_AcountNumber.Text = "label15";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(104, 339);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 58;
            label6.Text = "Status:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(39, 276);
            label12.Name = "label12";
            label12.Size = new Size(124, 21);
            label12.TabIndex = 57;
            label12.Text = "Meter Number:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(28, 217);
            label13.Name = "label13";
            label13.Size = new Size(135, 21);
            label13.TabIndex = 56;
            label13.Text = "Consumer Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(23, 159);
            label14.Name = "label14";
            label14.Size = new Size(140, 21);
            label14.TabIndex = 55;
            label14.Text = "Account Number:";
            // 
            // btnAddAmtPen
            // 
            btnAddAmtPen.BackColor = Color.DodgerBlue;
            btnAddAmtPen.Location = new Point(1309, 168);
            btnAddAmtPen.Name = "btnAddAmtPen";
            btnAddAmtPen.Size = new Size(115, 45);
            btnAddAmtPen.TabIndex = 54;
            btnAddAmtPen.Text = "ADD amt. pen.";
            btnAddAmtPen.UseVisualStyleBackColor = false;
            btnAddAmtPen.Click += btnAddAmtPen_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.DodgerBlue;
            btnFind.Location = new Point(767, 171);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(83, 39);
            btnFind.TabIndex = 53;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnAddConsumer
            // 
            btnAddConsumer.BackColor = Color.DodgerBlue;
            btnAddConsumer.Location = new Point(104, 438);
            btnAddConsumer.Name = "btnAddConsumer";
            btnAddConsumer.Size = new Size(160, 66);
            btnAddConsumer.TabIndex = 52;
            btnAddConsumer.Text = "ADD CONSUMER";
            btnAddConsumer.UseVisualStyleBackColor = false;
            btnAddConsumer.Click += btnAddConsumer_Click;
            // 
            // Lbl_MeterNumber
            // 
            Lbl_MeterNumber.AutoSize = true;
            Lbl_MeterNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_MeterNumber.Location = new Point(149, 297);
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
            DGridView_Amount.Columns.AddRange(new DataGridViewColumn[] { Column8, Penalty, Total, Month, Action_Amount });
            DGridView_Amount.Location = new Point(1019, 217);
            DGridView_Amount.Name = "DGridView_Amount";
            DGridView_Amount.ReadOnly = true;
            DGridView_Amount.Size = new Size(416, 427);
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
            // Action_Amount
            // 
            Action_Amount.HeaderText = "ACTIONS";
            Action_Amount.Name = "Action_Amount";
            Action_Amount.ReadOnly = true;
            // 
            // dGridView_Consumer
            // 
            dGridView_Consumer.AllowUserToAddRows = false;
            dGridView_Consumer.AllowUserToDeleteRows = false;
            dGridView_Consumer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridView_Consumer.Columns.AddRange(new DataGridViewColumn[] { AccountNo, MeterNo, Name, Status, ACTIONS });
            dGridView_Consumer.Location = new Point(373, 217);
            dGridView_Consumer.Name = "dGridView_Consumer";
            dGridView_Consumer.ReadOnly = true;
            dGridView_Consumer.Size = new Size(640, 427);
            dGridView_Consumer.TabIndex = 50;
            dGridView_Consumer.CellContentClick += dGridView_Consumer_CellContentClick;
            // 
            // AccountNo
            // 
            AccountNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // ACTIONS
            // 
            ACTIONS.HeaderText = "ACTIONS";
            ACTIONS.Name = "ACTIONS";
            ACTIONS.ReadOnly = true;
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
            txt_search.Location = new Point(525, 179);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(236, 23);
            txt_search.TabIndex = 48;
            // 
            // btnArea
            // 
            btnArea.BackColor = Color.DodgerBlue;
            btnArea.Location = new Point(375, 71);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(115, 45);
            btnArea.TabIndex = 38;
            btnArea.Text = "ADD AREA";
            btnArea.UseVisualStyleBackColor = false;
            btnArea.Click += btnArea_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(35, 83);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 29;
            label5.Text = "SELECT AREA:";
            // 
            // cb_area
            // 
            cb_area.BackColor = Color.LemonChiffon;
            cb_area.FormattingEnabled = true;
            cb_area.Location = new Point(149, 83);
            cb_area.Name = "cb_area";
            cb_area.Size = new Size(146, 23);
            cb_area.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(48, 9);
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
            label10.Location = new Point(1070, 63);
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
            lbl_OverAllTotal.Location = new Point(1265, 58);
            lbl_OverAllTotal.Name = "lbl_OverAllTotal";
            lbl_OverAllTotal.Size = new Size(159, 37);
            lbl_OverAllTotal.TabIndex = 0;
            lbl_OverAllTotal.Text = "568,973.99";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(btnArea);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cb_area);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lbl_OverAllTotal);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1457, 116);
            panel1.TabIndex = 47;
            panel1.Paint += panel1_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 655);
            Controls.Add(Lbl_Status);
            Controls.Add(Lbl_ConsumerName);
            Controls.Add(Lbl_AcountNumber);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(btnAddAmtPen);
            Controls.Add(btnFind);
            Controls.Add(btnAddConsumer);
            Controls.Add(Lbl_MeterNumber);
            Controls.Add(DGridView_Amount);
            Controls.Add(dGridView_Consumer);
            Controls.Add(label7);
            Controls.Add(txt_search);
            Controls.Add(panel1);
            
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
        private Button btnAddAmtPen;
        private Button btnFind;
        private Button btnAddConsumer;
        private Label Lbl_MeterNumber;
        private DataGridView DGridView_Amount;
        private DataGridView dGridView_Consumer;
        private Label label7;
        private TextBox txt_search;
        private Button btnArea;
        private Label label5;
        private ComboBox cb_area;
        private Label label11;
        private Label label10;
        private Label lbl_OverAllTotal;
        private Panel panel1;
        private DataGridViewTextBoxColumn AccountNo;
        private DataGridViewTextBoxColumn MeterNo;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn ACTIONS;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Penalty;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Action_Amount;
    }
}