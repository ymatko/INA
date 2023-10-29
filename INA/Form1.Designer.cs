namespace INA
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblA = new Label();
            LblB = new Label();
            LblD = new Label();
            LblN = new Label();
            LblPk = new Label();
            LblPm = new Label();
            BtnCalculate = new Button();
            comboBox_D = new ComboBox();
            panel1 = new Panel();
            textBox_N = new TextBox();
            textBox_Pm = new TextBox();
            textBox_Pk = new TextBox();
            textBox_B = new TextBox();
            textBox_A = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblA
            // 
            LblA.AutoSize = true;
            LblA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblA.Location = new Point(8, 12);
            LblA.Name = "LblA";
            LblA.Size = new Size(21, 21);
            LblA.TabIndex = 0;
            LblA.Text = "a:";
            // 
            // LblB
            // 
            LblB.AutoSize = true;
            LblB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblB.Location = new Point(105, 12);
            LblB.Name = "LblB";
            LblB.Size = new Size(22, 21);
            LblB.TabIndex = 0;
            LblB.Text = "b:";
            // 
            // LblD
            // 
            LblD.AutoSize = true;
            LblD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblD.Location = new Point(202, 12);
            LblD.Name = "LblD";
            LblD.Size = new Size(22, 21);
            LblD.TabIndex = 0;
            LblD.Text = "d:";
            // 
            // LblN
            // 
            LblN.AutoSize = true;
            LblN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblN.Location = new Point(551, 12);
            LblN.Name = "LblN";
            LblN.Size = new Size(25, 21);
            LblN.TabIndex = 0;
            LblN.Text = "N:";
            // 
            // LblPk
            // 
            LblPk.AutoSize = true;
            LblPk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPk.Location = new Point(310, 12);
            LblPk.Name = "LblPk";
            LblPk.Size = new Size(30, 21);
            LblPk.TabIndex = 0;
            LblPk.Text = "Pk:";
            // 
            // LblPm
            // 
            LblPm.AutoSize = true;
            LblPm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPm.Location = new Point(429, 12);
            LblPm.Name = "LblPm";
            LblPm.Size = new Size(36, 21);
            LblPm.TabIndex = 0;
            LblPm.Text = "Pm:";
            // 
            // BtnCalculate
            // 
            BtnCalculate.Dock = DockStyle.Right;
            BtnCalculate.Location = new Point(1530, 0);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(75, 47);
            BtnCalculate.TabIndex = 1;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // comboBox_D
            // 
            comboBox_D.FormattingEnabled = true;
            comboBox_D.Items.AddRange(new object[] { "0.1", "0.01", "0.001" });
            comboBox_D.Location = new Point(225, 12);
            comboBox_D.Name = "comboBox_D";
            comboBox_D.Size = new Size(67, 23);
            comboBox_D.TabIndex = 2;
            comboBox_D.Text = "0.1";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_N);
            panel1.Controls.Add(textBox_Pm);
            panel1.Controls.Add(textBox_Pk);
            panel1.Controls.Add(textBox_B);
            panel1.Controls.Add(textBox_A);
            panel1.Controls.Add(LblB);
            panel1.Controls.Add(comboBox_D);
            panel1.Controls.Add(LblA);
            panel1.Controls.Add(BtnCalculate);
            panel1.Controls.Add(LblD);
            panel1.Controls.Add(LblN);
            panel1.Controls.Add(LblPk);
            panel1.Controls.Add(LblPm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1605, 47);
            panel1.TabIndex = 3;
            // 
            // textBox_N
            // 
            textBox_N.Location = new Point(582, 12);
            textBox_N.Name = "textBox_N";
            textBox_N.Size = new Size(51, 23);
            textBox_N.TabIndex = 2;
            textBox_N.Text = "10";
            // 
            // textBox_Pm
            // 
            textBox_Pm.Location = new Point(471, 12);
            textBox_Pm.Name = "textBox_Pm";
            textBox_Pm.Size = new Size(51, 23);
            textBox_Pm.TabIndex = 2;
            textBox_Pm.Text = "0.002";
            // 
            // textBox_Pk
            // 
            textBox_Pk.Location = new Point(346, 12);
            textBox_Pk.Name = "textBox_Pk";
            textBox_Pk.Size = new Size(51, 23);
            textBox_Pk.TabIndex = 2;
            textBox_Pk.Text = "0.7";
            // 
            // textBox_B
            // 
            textBox_B.Location = new Point(133, 12);
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(51, 23);
            textBox_B.TabIndex = 2;
            textBox_B.Text = "12";
            // 
            // textBox_A
            // 
            textBox_A.Location = new Point(35, 12);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(51, 23);
            textBox_A.TabIndex = 2;
            textBox_A.Text = "-4";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(1605, 390);
            panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1605, 390);
            dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 437);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LblA;
        private Label LblB;
        private Label LblD;
        private Label LblN;
        private Label LblPk;
        private Label LblPm;
        private Button BtnCalculate;
        private ComboBox comboBox_D;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox_N;
        private TextBox textBox_Pm;
        private TextBox textBox_Pk;
        private TextBox textBox_B;
        private TextBox textBox_A;
        private DataGridView dataGridView1;
    }
}