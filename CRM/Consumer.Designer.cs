namespace CRM
{
    partial class Consumer
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
            label7 = new Label();
            btn_SaveConsumer = new Button();
            cbo_Status = new ComboBox();
            label9 = new Label();
            label3 = new Label();
            txt_ConsumerName = new TextBox();
            label2 = new Label();
            txt_MeterNumber = new TextBox();
            label1 = new Label();
            txt_AccountNumber = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(136, 32);
            label7.Name = "label7";
            label7.Size = new Size(204, 37);
            label7.TabIndex = 52;
            label7.Text = "New Consumer";
            // 
            // btn_SaveConsumer
            // 
            btn_SaveConsumer.BackColor = Color.DarkSeaGreen;
            btn_SaveConsumer.Location = new Point(156, 274);
            btn_SaveConsumer.Name = "btn_SaveConsumer";
            btn_SaveConsumer.Size = new Size(115, 37);
            btn_SaveConsumer.TabIndex = 51;
            btn_SaveConsumer.Text = "SAVE";
            btn_SaveConsumer.UseVisualStyleBackColor = false;
            btn_SaveConsumer.Click += Save_Click;
            // 
            // cbo_Status
            // 
            cbo_Status.BackColor = Color.LemonChiffon;
            cbo_Status.FormattingEnabled = true;
            cbo_Status.Items.AddRange(new object[] { "ACTIVE", "DISCONNECTED", "PULLED OUT" });
            cbo_Status.Location = new Point(136, 224);
            cbo_Status.Name = "cbo_Status";
            cbo_Status.Size = new Size(168, 23);
            cbo_Status.TabIndex = 50;
            cbo_Status.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(80, 227);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 49;
            label9.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(24, 180);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 48;
            label3.Text = "Consumer Name:";
            // 
            // txt_ConsumerName
            // 
            txt_ConsumerName.BackColor = Color.LemonChiffon;
            txt_ConsumerName.Location = new Point(136, 177);
            txt_ConsumerName.Name = "txt_ConsumerName";
            txt_ConsumerName.Size = new Size(236, 23);
            txt_ConsumerName.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(34, 134);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 46;
            label2.Text = "Meter Number:";
            // 
            // txt_MeterNumber
            // 
            txt_MeterNumber.BackColor = Color.LemonChiffon;
            txt_MeterNumber.Location = new Point(136, 131);
            txt_MeterNumber.Name = "txt_MeterNumber";
            txt_MeterNumber.Size = new Size(236, 23);
            txt_MeterNumber.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(22, 87);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 44;
            label1.Text = "Account Number:";
            // 
            // txt_AccountNumber
            // 
            txt_AccountNumber.BackColor = Color.LemonChiffon;
            txt_AccountNumber.Location = new Point(136, 87);
            txt_AccountNumber.Name = "txt_AccountNumber";
            txt_AccountNumber.Size = new Size(236, 23);
            txt_AccountNumber.TabIndex = 43;
            // 
            // Consumer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(431, 353);
            Controls.Add(label7);
            Controls.Add(btn_SaveConsumer);
            Controls.Add(cbo_Status);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(txt_ConsumerName);
            Controls.Add(label2);
            Controls.Add(txt_MeterNumber);
            Controls.Add(label1);
            Controls.Add(txt_AccountNumber);
            Name = "Consumer";
            Text = "Consumer";
            Load += Consumer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btn_SaveConsumer;
        private ComboBox cbo_Status;
        private Label label9;
        private Label label3;
        private TextBox txt_ConsumerName;
        private Label label2;
        private TextBox txt_MeterNumber;
        private Label label1;
        private TextBox txt_AccountNumber;
    }
}