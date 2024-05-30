namespace CRM
{
    partial class Amount_Recievable
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
            label3 = new Label();
            label2 = new Label();
            txt_Amount = new TextBox();
            label1 = new Label();
            txt_Month = new TextBox();
            Save = new Button();
            cbo_Penalty = new ComboBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(69, 27);
            label7.Name = "label7";
            label7.Size = new Size(253, 37);
            label7.TabIndex = 63;
            label7.Text = "Amount Recievable";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(43, 174);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 62;
            label3.Text = "Penalty :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(41, 128);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 60;
            label2.Text = "Amount:";
            // 
            // txt_Amount
            // 
            txt_Amount.BackColor = Color.LemonChiffon;
            txt_Amount.Location = new Point(99, 125);
            txt_Amount.Name = "txt_Amount";
            txt_Amount.Size = new Size(236, 23);
            txt_Amount.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(48, 83);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 58;
            label1.Text = "Month:";
            // 
            // txt_Month
            // 
            txt_Month.BackColor = Color.LemonChiffon;
            txt_Month.Location = new Point(99, 81);
            txt_Month.Name = "txt_Month";
            txt_Month.Size = new Size(236, 23);
            txt_Month.TabIndex = 57;
            // 
            // Save
            // 
            Save.BackColor = Color.DarkTurquoise;
            Save.Location = new Point(139, 211);
            Save.Name = "Save";
            Save.Size = new Size(115, 37);
            Save.TabIndex = 64;
            Save.Text = "SAVE";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // cbo_Penalty
            // 
            cbo_Penalty.BackColor = Color.LemonChiffon;
            cbo_Penalty.FormattingEnabled = true;
            cbo_Penalty.Items.AddRange(new object[] { "56.00", "33.60" });
            cbo_Penalty.Location = new Point(99, 174);
            cbo_Penalty.Name = "cbo_Penalty";
            cbo_Penalty.Size = new Size(168, 23);
            cbo_Penalty.TabIndex = 65;
            cbo_Penalty.SelectedIndexChanged += cbo_Penalty_SelectedIndexChanged;
            // 
            // Amount_Recievable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(398, 276);
            Controls.Add(cbo_Penalty);
            Controls.Add(Save);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Amount);
            Controls.Add(label1);
            Controls.Add(txt_Month);
            Name = "Amount_Recievable";
            Text = "Amount_Recievable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label3;
        private Label label2;
        private TextBox txt_Amount;
        private Label label1;
        private TextBox txt_Month;
        private Button Save;
        private ComboBox cbo_Penalty;
    }
}