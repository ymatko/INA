namespace INA_lab3
{
    partial class Form1
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
            checkBox_elite = new CheckBox();
            textBox_T = new TextBox();
            textBox_N = new TextBox();
            textBox_Pm = new TextBox();
            textBox_Pk = new TextBox();
            textBox_B = new TextBox();
            textBox_A = new TextBox();
            LblB = new Label();
            comboBox_D = new ComboBox();
            LblA = new Label();
            BtnCalculate = new Button();
            LblT = new Label();
            LblD = new Label();
            LblN = new Label();
            LblPk = new Label();
            LblPm = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox_elite);
            panel1.Controls.Add(textBox_T);
            panel1.Controls.Add(textBox_N);
            panel1.Controls.Add(textBox_Pm);
            panel1.Controls.Add(textBox_Pk);
            panel1.Controls.Add(textBox_B);
            panel1.Controls.Add(textBox_A);
            panel1.Controls.Add(LblB);
            panel1.Controls.Add(comboBox_D);
            panel1.Controls.Add(LblA);
            panel1.Controls.Add(BtnCalculate);
            panel1.Controls.Add(LblT);
            panel1.Controls.Add(LblD);
            panel1.Controls.Add(LblN);
            panel1.Controls.Add(LblPk);
            panel1.Controls.Add(LblPm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 47);
            panel1.TabIndex = 4;
            // 
            // checkBox_elite
            // 
            checkBox_elite.AutoSize = true;
            checkBox_elite.Location = new Point(671, 13);
            checkBox_elite.Name = "checkBox_elite";
            checkBox_elite.Size = new Size(48, 19);
            checkBox_elite.TabIndex = 3;
            checkBox_elite.Text = "Elite";
            checkBox_elite.UseVisualStyleBackColor = true;
            // 
            // textBox_T
            // 
            textBox_T.Location = new Point(513, 11);
            textBox_T.Name = "textBox_T";
            textBox_T.Size = new Size(51, 23);
            textBox_T.TabIndex = 2;
            textBox_T.Text = "100";
            // 
            // textBox_N
            // 
            textBox_N.Location = new Point(610, 11);
            textBox_N.Name = "textBox_N";
            textBox_N.Size = new Size(51, 23);
            textBox_N.TabIndex = 2;
            textBox_N.Text = "10";
            // 
            // textBox_Pm
            // 
            textBox_Pm.Location = new Point(418, 11);
            textBox_Pm.Name = "textBox_Pm";
            textBox_Pm.Size = new Size(51, 23);
            textBox_Pm.TabIndex = 2;
            textBox_Pm.Text = "0.002";
            // 
            // textBox_Pk
            // 
            textBox_Pk.Location = new Point(313, 11);
            textBox_Pk.Name = "textBox_Pk";
            textBox_Pk.Size = new Size(51, 23);
            textBox_Pk.TabIndex = 2;
            textBox_Pk.Text = "0.7";
            // 
            // textBox_B
            // 
            textBox_B.Location = new Point(117, 11);
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(51, 23);
            textBox_B.TabIndex = 2;
            textBox_B.Text = "12";
            // 
            // textBox_A
            // 
            textBox_A.Location = new Point(30, 11);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(51, 23);
            textBox_A.TabIndex = 2;
            textBox_A.Text = "-4";
            // 
            // LblB
            // 
            LblB.AutoSize = true;
            LblB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblB.Location = new Point(89, 11);
            LblB.Name = "LblB";
            LblB.Size = new Size(22, 21);
            LblB.TabIndex = 0;
            LblB.Text = "b:";
            // 
            // comboBox_D
            // 
            comboBox_D.FormattingEnabled = true;
            comboBox_D.Items.AddRange(new object[] { "0.1", "0.01", "0.001" });
            comboBox_D.Location = new Point(200, 11);
            comboBox_D.Name = "comboBox_D";
            comboBox_D.Size = new Size(67, 23);
            comboBox_D.TabIndex = 2;
            comboBox_D.Text = "0.1";
            // 
            // LblA
            // 
            LblA.AutoSize = true;
            LblA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblA.Location = new Point(3, 11);
            LblA.Name = "LblA";
            LblA.Size = new Size(21, 21);
            LblA.TabIndex = 0;
            LblA.Text = "a:";
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(721, 7);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(75, 34);
            BtnCalculate.TabIndex = 1;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // LblT
            // 
            LblT.AutoSize = true;
            LblT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblT.Location = new Point(482, 11);
            LblT.Name = "LblT";
            LblT.Size = new Size(21, 21);
            LblT.TabIndex = 0;
            LblT.Text = "T:";
            // 
            // LblD
            // 
            LblD.AutoSize = true;
            LblD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblD.Location = new Point(177, 11);
            LblD.Name = "LblD";
            LblD.Size = new Size(22, 21);
            LblD.TabIndex = 0;
            LblD.Text = "d:";
            // 
            // LblN
            // 
            LblN.AutoSize = true;
            LblN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblN.Location = new Point(579, 11);
            LblN.Name = "LblN";
            LblN.Size = new Size(25, 21);
            LblN.TabIndex = 0;
            LblN.Text = "N:";
            // 
            // LblPk
            // 
            LblPk.AutoSize = true;
            LblPk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPk.Location = new Point(277, 11);
            LblPk.Name = "LblPk";
            LblPk.Size = new Size(30, 21);
            LblPk.TabIndex = 0;
            LblPk.Text = "Pk:";
            // 
            // LblPm
            // 
            LblPm.AutoSize = true;
            LblPm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPm.Location = new Point(376, 11);
            LblPm.Name = "LblPm";
            LblPm.Size = new Size(36, 21);
            LblPm.TabIndex = 0;
            LblPm.Text = "Pm:";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 403);
            panel2.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 403);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 375);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 375);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 375);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "INA_lab3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox_N;
        private TextBox textBox_Pm;
        private TextBox textBox_Pk;
        private TextBox textBox_B;
        private TextBox textBox_A;
        private Label LblB;
        private ComboBox comboBox_D;
        private Label LblA;
        private Button BtnCalculate;
        private Label LblD;
        private Label LblN;
        private Label LblPk;
        private Label LblPm;
        private Panel panel2;
        private TextBox textBox_T;
        private Label LblT;
        private CheckBox checkBox_elite;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}