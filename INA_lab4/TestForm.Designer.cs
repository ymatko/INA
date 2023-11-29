namespace INA_lab4
{
    partial class TestForm
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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbBestFxReal = new TextBox();
            tbBestXbin = new TextBox();
            tbBestXreal = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            T = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            Q = new DataGridViewTextBoxColumn();
            Procent = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbBestFxReal);
            panel1.Controls.Add(tbBestXbin);
            panel1.Controls.Add(tbBestXreal);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(425, 9);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 5;
            label7.Text = "F (X real)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(219, 9);
            label6.Name = "label6";
            label6.Size = new Size(40, 19);
            label6.TabIndex = 6;
            label6.Text = "X Bin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 9);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 7;
            label5.Text = "X real";
            // 
            // tbBestFxReal
            // 
            tbBestFxReal.Location = new Point(425, 30);
            tbBestFxReal.Name = "tbBestFxReal";
            tbBestFxReal.Size = new Size(122, 23);
            tbBestFxReal.TabIndex = 2;
            // 
            // tbBestXbin
            // 
            tbBestXbin.Location = new Point(219, 30);
            tbBestXbin.Name = "tbBestXbin";
            tbBestXbin.Size = new Size(122, 23);
            tbBestXbin.TabIndex = 3;
            // 
            // tbBestXreal
            // 
            tbBestXreal.Location = new Point(16, 30);
            tbBestXreal.Name = "tbBestXreal";
            tbBestXreal.Size = new Size(122, 23);
            tbBestXreal.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 385);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { T, Result, Q, Procent });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 385);
            dataGridView1.TabIndex = 0;
            // 
            // T
            // 
            T.HeaderText = "T";
            T.Name = "T";
            T.ReadOnly = true;
            // 
            // Result
            // 
            Result.HeaderText = "Result";
            Result.Name = "Result";
            Result.ReadOnly = true;
            // 
            // Q
            // 
            Q.HeaderText = "Q";
            Q.Name = "Q";
            Q.ReadOnly = true;
            // 
            // Procent
            // 
            Procent.HeaderText = "Procent";
            Procent.Name = "Procent";
            Procent.ReadOnly = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(700, 18);
            button1.Name = "button1";
            button1.Size = new Size(88, 29);
            button1.TabIndex = 8;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TestForm";
            Text = "Tests";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbBestFxReal;
        private TextBox tbBestXbin;
        private TextBox tbBestXreal;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn T;
        private DataGridViewTextBoxColumn Result;
        private DataGridViewTextBoxColumn Q;
        private DataGridViewTextBoxColumn Procent;
    }
}