namespace INA_lab4
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
            panel1 = new Panel();
            btnTests = new Button();
            btnCalc = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbD = new ComboBox();
            tbT = new TextBox();
            tbB = new TextBox();
            tbA = new TextBox();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbBestFxReal = new TextBox();
            tbBestXbin = new TextBox();
            tbBestXreal = new TextBox();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            xReal = new DataGridViewTextBoxColumn();
            xBin = new DataGridViewTextBoxColumn();
            FxReal = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTests);
            panel1.Controls.Add(btnCalc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbD);
            panel1.Controls.Add(tbT);
            panel1.Controls.Add(tbB);
            panel1.Controls.Add(tbA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 63);
            panel1.TabIndex = 0;
            // 
            // btnTests
            // 
            btnTests.Location = new Point(612, 21);
            btnTests.Name = "btnTests";
            btnTests.Size = new Size(75, 23);
            btnTests.TabIndex = 4;
            btnTests.Text = "Tests";
            btnTests.UseVisualStyleBackColor = true;
            btnTests.Click += btnTests_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(713, 21);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(421, 19);
            label4.Name = "label4";
            label4.Size = new Size(21, 21);
            label4.TabIndex = 2;
            label4.Text = "T:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(265, 19);
            label3.Name = "label3";
            label3.Size = new Size(22, 21);
            label3.TabIndex = 2;
            label3.Text = "d:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 19);
            label2.Name = "label2";
            label2.Size = new Size(22, 21);
            label2.TabIndex = 2;
            label2.Text = "b:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 2;
            label1.Text = "a:";
            // 
            // cbD
            // 
            cbD.FormattingEnabled = true;
            cbD.Items.AddRange(new object[] { "0.1", "0.01", "0.001", "0.0001" });
            cbD.Location = new Point(292, 21);
            cbD.Name = "cbD";
            cbD.Size = new Size(84, 23);
            cbD.TabIndex = 1;
            cbD.Text = "0.001";
            // 
            // tbT
            // 
            tbT.Location = new Point(448, 21);
            tbT.Name = "tbT";
            tbT.Size = new Size(41, 23);
            tbT.TabIndex = 0;
            tbT.Text = "50";
            // 
            // tbB
            // 
            tbB.Location = new Point(167, 21);
            tbB.Name = "tbB";
            tbB.Size = new Size(41, 23);
            tbB.TabIndex = 0;
            tbB.Text = "12";
            // 
            // tbA
            // 
            tbA.Location = new Point(51, 21);
            tbA.Name = "tbA";
            tbA.Size = new Size(41, 23);
            tbA.TabIndex = 0;
            tbA.Text = "-4";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 387);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 387);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tbBestFxReal);
            tabPage2.Controls.Add(tbBestXbin);
            tabPage2.Controls.Add(tbBestXreal);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Best of the population";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(429, 26);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 1;
            label7.Text = "F (X real)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(223, 26);
            label6.Name = "label6";
            label6.Size = new Size(40, 19);
            label6.TabIndex = 1;
            label6.Text = "X Bin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 26);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 1;
            label5.Text = "X real";
            // 
            // tbBestFxReal
            // 
            tbBestFxReal.Location = new Point(429, 47);
            tbBestFxReal.Name = "tbBestFxReal";
            tbBestFxReal.Size = new Size(122, 23);
            tbBestFxReal.TabIndex = 0;
            // 
            // tbBestXbin
            // 
            tbBestXbin.Location = new Point(223, 47);
            tbBestXbin.Name = "tbBestXbin";
            tbBestXbin.Size = new Size(122, 23);
            tbBestXbin.TabIndex = 0;
            // 
            // tbBestXreal
            // 
            tbBestXreal.Location = new Point(20, 47);
            tbBestXreal.Name = "tbBestXreal";
            tbBestXreal.Size = new Size(122, 23);
            tbBestXreal.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Table";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { xReal, xBin, FxReal });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 353);
            dataGridView1.TabIndex = 0;
            // 
            // xReal
            // 
            xReal.HeaderText = "xReal";
            xReal.Name = "xReal";
            xReal.ReadOnly = true;
            // 
            // xBin
            // 
            xBin.HeaderText = "xBin";
            xBin.Name = "xBin";
            xBin.ReadOnly = true;
            // 
            // FxReal
            // 
            FxReal.HeaderText = "FxReal";
            FxReal.Name = "FxReal";
            FxReal.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 359);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Biggest Growth Algorithm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbT;
        private TextBox tbB;
        private TextBox tbA;
        private Panel panel2;
        private ComboBox cbD;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTests;
        private Button btnCalc;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn xReal;
        private DataGridViewTextBoxColumn xBin;
        private DataGridViewTextBoxColumn FxReal;
        private TabPage tabPage3;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbBestFxReal;
        private TextBox tbBestXbin;
        private TextBox tbBestXreal;
    }
}