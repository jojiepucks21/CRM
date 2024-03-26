namespace CRM
{
    partial class Area
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
            Save = new Button();
            label7 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Save
            // 
            Save.BackColor = Color.DarkSeaGreen;
            Save.Location = new Point(79, 152);
            Save.Name = "Save";
            Save.Size = new Size(115, 37);
            Save.TabIndex = 42;
            Save.Text = "SAVE";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(62, 34);
            label7.Name = "label7";
            label7.Size = new Size(152, 37);
            label7.TabIndex = 41;
            label7.Text = "NEW AREA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(23, 96);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 40;
            label1.Text = "Area:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.Location = new Point(62, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 39;
            // 
            // Area
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(265, 228);
            Controls.Add(Save);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Area";
            Text = "Area";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save;
        private Label label7;
        private Label label1;
        private TextBox textBox1;
    }
}