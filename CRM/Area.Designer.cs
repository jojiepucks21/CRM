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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area));
            btn_UpdateArea = new Button();
            btn_DeleteArea = new Button();
            btn_AddArea = new Button();
            dataGridView1 = new DataGridView();
            Area1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txt_FileImport = new TextBox();
            Lbl_Status = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_UpdateArea
            // 
            btn_UpdateArea.BackColor = Color.DodgerBlue;
            btn_UpdateArea.Image = (Image)resources.GetObject("btn_UpdateArea.Image");
            btn_UpdateArea.ImageAlign = ContentAlignment.MiddleRight;
            btn_UpdateArea.Location = new Point(44, 144);
            btn_UpdateArea.Name = "btn_UpdateArea";
            btn_UpdateArea.Size = new Size(77, 34);
            btn_UpdateArea.TabIndex = 43;
            btn_UpdateArea.Text = "UPDATE";
            btn_UpdateArea.TextAlign = ContentAlignment.MiddleLeft;
            btn_UpdateArea.UseVisualStyleBackColor = false;
            btn_UpdateArea.Click += btn_UpdateArea_Click;
            // 
            // btn_DeleteArea
            // 
            btn_DeleteArea.BackColor = Color.DodgerBlue;
            btn_DeleteArea.Image = (Image)resources.GetObject("btn_DeleteArea.Image");
            btn_DeleteArea.ImageAlign = ContentAlignment.MiddleRight;
            btn_DeleteArea.Location = new Point(44, 190);
            btn_DeleteArea.Name = "btn_DeleteArea";
            btn_DeleteArea.Size = new Size(77, 34);
            btn_DeleteArea.TabIndex = 42;
            btn_DeleteArea.Text = "DELETE";
            btn_DeleteArea.TextAlign = ContentAlignment.MiddleLeft;
            btn_DeleteArea.UseVisualStyleBackColor = false;
            // 
            // btn_AddArea
            // 
            btn_AddArea.BackColor = Color.DodgerBlue;
            btn_AddArea.Image = (Image)resources.GetObject("btn_AddArea.Image");
            btn_AddArea.ImageAlign = ContentAlignment.MiddleRight;
            btn_AddArea.Location = new Point(44, 97);
            btn_AddArea.Name = "btn_AddArea";
            btn_AddArea.Size = new Size(77, 34);
            btn_AddArea.TabIndex = 41;
            btn_AddArea.Text = "ADD";
            btn_AddArea.TextAlign = ContentAlignment.MiddleLeft;
            btn_AddArea.UseVisualStyleBackColor = false;
            btn_AddArea.Click += btn_AddArea_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Area1 });
            dataGridView1.Location = new Point(178, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(165, 238);
            dataGridView1.TabIndex = 44;
            // 
            // Area1
            // 
            Area1.HeaderText = "Area";
            Area1.Name = "Area1";
            Area1.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 16);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 45;
            label1.Text = "Area List";
            // 
            // txt_FileImport
            // 
            txt_FileImport.BackColor = Color.LemonChiffon;
            txt_FileImport.Location = new Point(12, 52);
            txt_FileImport.Name = "txt_FileImport";
            txt_FileImport.Size = new Size(136, 23);
            txt_FileImport.TabIndex = 66;
            // 
            // Lbl_Status
            // 
            Lbl_Status.AutoSize = true;
            Lbl_Status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lbl_Status.Location = new Point(12, 23);
            Lbl_Status.Name = "Lbl_Status";
            Lbl_Status.Size = new Size(93, 21);
            Lbl_Status.TabIndex = 65;
            Lbl_Status.Text = "NEW AREA:";
            // 
            // Area
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(355, 296);
            Controls.Add(txt_FileImport);
            Controls.Add(Lbl_Status);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_UpdateArea);
            Controls.Add(btn_DeleteArea);
            Controls.Add(btn_AddArea);
            Name = "Area";
            Text = "Area";
            Load += Area_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_UpdateArea;
        private Button btn_DeleteArea;
        private Button btn_AddArea;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Area1;
        private Label label1;
        private TextBox txt_FileImport;
        private Label Lbl_Status;
    }
}