namespace INA_lab_1
{
    partial class Form1
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
            Calculate = new Button();
            LblA = new Label();
            LblB = new Label();
            LblD = new Label();
            LblN = new Label();
            TbA = new TextBox();
            TbB = new TextBox();
            TbN = new TextBox();
            dataGridView1 = new DataGridView();
            CbD = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Calculate
            // 
            Calculate.Location = new Point(830, 24);
            Calculate.Margin = new Padding(2);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(65, 29);
            Calculate.TabIndex = 0;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // LblA
            // 
            LblA.AutoSize = true;
            LblA.Location = new Point(26, 30);
            LblA.Margin = new Padding(2, 0, 2, 0);
            LblA.Name = "LblA";
            LblA.Size = new Size(16, 15);
            LblA.TabIndex = 1;
            LblA.Text = "a:";
            // 
            // LblB
            // 
            LblB.AutoSize = true;
            LblB.Location = new Point(131, 30);
            LblB.Margin = new Padding(2, 0, 2, 0);
            LblB.Name = "LblB";
            LblB.Size = new Size(17, 15);
            LblB.TabIndex = 2;
            LblB.Text = "b:";
            // 
            // LblD
            // 
            LblD.AutoSize = true;
            LblD.Location = new Point(233, 30);
            LblD.Margin = new Padding(2, 0, 2, 0);
            LblD.Name = "LblD";
            LblD.Size = new Size(17, 15);
            LblD.TabIndex = 3;
            LblD.Text = "d:";
            // 
            // LblN
            // 
            LblN.AutoSize = true;
            LblN.Location = new Point(374, 30);
            LblN.Margin = new Padding(2, 0, 2, 0);
            LblN.Name = "LblN";
            LblN.Size = new Size(19, 15);
            LblN.TabIndex = 4;
            LblN.Text = "N:";
            // 
            // TbA
            // 
            TbA.Location = new Point(47, 30);
            TbA.Margin = new Padding(2);
            TbA.Name = "TbA";
            TbA.Size = new Size(37, 23);
            TbA.TabIndex = 5;
            TbA.Text = "-4";
            // 
            // TbB
            // 
            TbB.Location = new Point(152, 28);
            TbB.Margin = new Padding(2);
            TbB.Name = "TbB";
            TbB.Size = new Size(37, 23);
            TbB.TabIndex = 5;
            TbB.Text = "12";
            // 
            // TbN
            // 
            TbN.Location = new Point(400, 27);
            TbN.Margin = new Padding(2);
            TbN.Name = "TbN";
            TbN.Size = new Size(37, 23);
            TbN.TabIndex = 5;
            TbN.Text = "10";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 82);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(866, 524);
            dataGridView1.TabIndex = 6;
            // 
            // CbD
            // 
            CbD.FormattingEnabled = true;
            CbD.Items.AddRange(new object[] { "0.1", "0.01", "0.001", "0.0001" });
            CbD.Location = new Point(258, 27);
            CbD.Margin = new Padding(4, 3, 4, 3);
            CbD.Name = "CbD";
            CbD.Size = new Size(78, 23);
            CbD.TabIndex = 7;
            CbD.Text = "0.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 628);
            Controls.Add(CbD);
            Controls.Add(dataGridView1);
            Controls.Add(TbN);
            Controls.Add(TbB);
            Controls.Add(TbA);
            Controls.Add(LblN);
            Controls.Add(LblD);
            Controls.Add(LblB);
            Controls.Add(LblA);
            Controls.Add(Calculate);
            Margin = new Padding(2);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculate;
        private Label LblA;
        private Label LblB;
        private Label LblD;
        private Label LblN;
        private TextBox TbA;
        private TextBox TbB;
        private TextBox TbN;
        private DataGridView dataGridView1;
        private ComboBox CbD;
    }
}

