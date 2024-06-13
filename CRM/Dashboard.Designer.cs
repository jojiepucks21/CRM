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
            btnFind = new Button();
            dGridView_Consumer = new DataGridView();
            col_id = new DataGridViewTextBoxColumn();
            AccountNo = new DataGridViewTextBoxColumn();
            MeterNo = new DataGridViewTextBoxColumn();
            Col_Name = new DataGridViewTextBoxColumn();
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
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dGridView_Consumer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.DodgerBlue;
            btnFind.Location = new Point(680, 248);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(80, 36);
            btnFind.TabIndex = 53;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // dGridView_Consumer
            // 
            dGridView_Consumer.AllowUserToAddRows = false;
            dGridView_Consumer.AllowUserToDeleteRows = false;
            dGridView_Consumer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridView_Consumer.Columns.AddRange(new DataGridViewColumn[] { col_id, AccountNo, MeterNo, Col_Name, Status });
            dGridView_Consumer.Location = new Point(253, 303);
            dGridView_Consumer.Margin = new Padding(3, 4, 3, 4);
            dGridView_Consumer.Name = "dGridView_Consumer";
            dGridView_Consumer.ReadOnly = true;
            dGridView_Consumer.RowHeadersWidth = 51;
            dGridView_Consumer.Size = new Size(731, 681);
            dGridView_Consumer.TabIndex = 50;
            dGridView_Consumer.CellContentClick += dGridView_Consumer_CellContentClick;
            // 
            // col_id
            // 
            col_id.HeaderText = "";
            col_id.MinimumWidth = 6;
            col_id.Name = "col_id";
            col_id.ReadOnly = true;
            col_id.Visible = false;
            col_id.Width = 125;
            // 
            // AccountNo
            // 
            AccountNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AccountNo.HeaderText = "ACCT NO.";
            AccountNo.MinimumWidth = 6;
            AccountNo.Name = "AccountNo";
            AccountNo.ReadOnly = true;
            AccountNo.Width = 125;
            // 
            // MeterNo
            // 
            MeterNo.HeaderText = "METER NO.";
            MeterNo.MinimumWidth = 6;
            MeterNo.Name = "MeterNo";
            MeterNo.ReadOnly = true;
            MeterNo.Width = 125;
            // 
            // Col_Name
            // 
            Col_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_Name.HeaderText = "NAME";
            Col_Name.MinimumWidth = 6;
            Col_Name.Name = "Col_Name";
            Col_Name.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "STATUS";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 256);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 49;
            label7.Text = "Search by ID or Name:";
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.LemonChiffon;
            txt_search.Location = new Point(403, 252);
            txt_search.Margin = new Padding(3, 4, 3, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(269, 27);
            txt_search.TabIndex = 48;
            // 
            // btn_Areas
            // 
            btn_Areas.BackColor = Color.DodgerBlue;
            btn_Areas.Location = new Point(43, 135);
            btn_Areas.Margin = new Padding(3, 4, 3, 4);
            btn_Areas.Name = "btn_Areas";
            btn_Areas.Size = new Size(128, 45);
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
            label5.Location = new Point(200, 145);
            label5.Name = "label5";
            label5.Size = new Size(164, 28);
            label5.TabIndex = 29;
            label5.Text = "SELECT BY AREA:";
            label5.Click += label5_Click;
            // 
            // cb_area
            // 
            cb_area.BackColor = Color.LemonChiffon;
            cb_area.FormattingEnabled = true;
            cb_area.Location = new Point(354, 147);
            cb_area.Margin = new Padding(3, 4, 3, 4);
            cb_area.Name = "cb_area";
            cb_area.Size = new Size(166, 28);
            cb_area.TabIndex = 28;
            cb_area.SelectedIndexChanged += cb_area_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(43, 12);
            label11.Name = "label11";
            label11.Size = new Size(607, 41);
            label11.TabIndex = 2;
            label11.Text = "SUMMARY ACCOUNTS RECIEVABLE BAPA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(600, 129);
            label10.Name = "label10";
            label10.Size = new Size(255, 41);
            label10.TabIndex = 1;
            label10.Text = "OVERALL TOTAL:";
            // 
            // lbl_OverAllTotal
            // 
            lbl_OverAllTotal.AutoSize = true;
            lbl_OverAllTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_OverAllTotal.ForeColor = Color.Red;
            lbl_OverAllTotal.Location = new Point(866, 124);
            lbl_OverAllTotal.Name = "lbl_OverAllTotal";
            lbl_OverAllTotal.Size = new Size(198, 46);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 208);
            panel1.TabIndex = 47;
            panel1.Paint += panel1_Paint;
            // 
            // btnAddConsumer
            // 
            btnAddConsumer.BackColor = Color.DodgerBlue;
            btnAddConsumer.Image = (Image)resources.GetObject("btnAddConsumer.Image");
            btnAddConsumer.ImageAlign = ContentAlignment.MiddleRight;
            btnAddConsumer.Location = new Point(43, 491);
            btnAddConsumer.Margin = new Padding(3, 4, 3, 4);
            btnAddConsumer.Name = "btnAddConsumer";
            btnAddConsumer.Size = new Size(155, 67);
            btnAddConsumer.TabIndex = 66;
            btnAddConsumer.Text = "ADD CONSUMER";
            btnAddConsumer.TextAlign = ContentAlignment.MiddleLeft;
            btnAddConsumer.UseVisualStyleBackColor = false;
            btnAddConsumer.Click += btnAddConsumer_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(43, 565);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(155, 67);
            button4.TabIndex = 68;
            button4.Text = "UPDATE CONSUMER";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(43, 644);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(155, 67);
            button5.TabIndex = 69;
            button5.Text = "DELETE CONSUMER";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 1037);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnAddConsumer);
            Controls.Add(btnFind);
            Controls.Add(dGridView_Consumer);
            Controls.Add(label7);
            Controls.Add(txt_search);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dGridView_Consumer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFind;
        private Label label7;
        private TextBox txt_search;
        private Button btn_Areas;
        private Label label5;
        private ComboBox cb_area;
        private Label label11;
        private Label label10;
        private Label lbl_OverAllTotal;
        private Panel panel1;
        private Button btnAddConsumer;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn AccountNo;
        private DataGridViewTextBoxColumn MeterNo;
        private DataGridViewTextBoxColumn Col_Name;
        private DataGridViewTextBoxColumn Status;
        public static DataGridView dGridView_Consumer;
    }
}