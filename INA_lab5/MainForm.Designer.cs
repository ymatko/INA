namespace INA_lab5
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
            button1 = new Button();
            cbD = new ComboBox();
            textBox_C3 = new TextBox();
            label8 = new Label();
            textBox_C2 = new TextBox();
            label7 = new Label();
            textBox_C1 = new TextBox();
            label6 = new Label();
            textBox_T = new TextBox();
            label5 = new Label();
            textBox_N = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox_B = new TextBox();
            label2 = new Label();
            textBox_A = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            label10 = new Label();
            textBox_resX = new TextBox();
            label11 = new Label();
            textBox_resFx = new TextBox();
            formsPlot1 = new ScottPlot.FormsPlot();
            formsPlot2 = new ScottPlot.FormsPlot();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cbD);
            panel1.Controls.Add(textBox_C3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox_C2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox_C1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox_T);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox_N);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox_B);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_A);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(691, 7);
            button1.Name = "button1";
            button1.Size = new Size(97, 32);
            button1.TabIndex = 3;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbD
            // 
            cbD.FormattingEnabled = true;
            cbD.Items.AddRange(new object[] { "0.1", "0.01", "0.001", "0.0001" });
            cbD.Location = new Point(193, 10);
            cbD.Name = "cbD";
            cbD.Size = new Size(58, 23);
            cbD.TabIndex = 2;
            cbD.Text = "0.001";
            // 
            // textBox_C3
            // 
            textBox_C3.Location = new Point(632, 10);
            textBox_C3.Name = "textBox_C3";
            textBox_C3.Size = new Size(30, 23);
            textBox_C3.TabIndex = 1;
            textBox_C3.Text = "1.2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(597, 13);
            label8.Name = "label8";
            label8.Size = new Size(29, 20);
            label8.TabIndex = 0;
            label8.Text = "C3:";
            // 
            // textBox_C2
            // 
            textBox_C2.Location = new Point(550, 10);
            textBox_C2.Name = "textBox_C2";
            textBox_C2.Size = new Size(30, 23);
            textBox_C2.TabIndex = 1;
            textBox_C2.Text = "1.0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(515, 13);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 0;
            label7.Text = "C2:";
            // 
            // textBox_C1
            // 
            textBox_C1.Location = new Point(470, 10);
            textBox_C1.Name = "textBox_C1";
            textBox_C1.Size = new Size(30, 23);
            textBox_C1.TabIndex = 1;
            textBox_C1.Text = "0.8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(435, 13);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 0;
            label6.Text = "C1:";
            // 
            // textBox_T
            // 
            textBox_T.Location = new Point(370, 9);
            textBox_T.Name = "textBox_T";
            textBox_T.Size = new Size(30, 23);
            textBox_T.TabIndex = 1;
            textBox_T.Text = "70";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(344, 10);
            label5.Name = "label5";
            label5.Size = new Size(20, 20);
            label5.TabIndex = 0;
            label5.Text = "T:";
            // 
            // textBox_N
            // 
            textBox_N.Location = new Point(296, 10);
            textBox_N.Name = "textBox_N";
            textBox_N.Size = new Size(30, 23);
            textBox_N.TabIndex = 1;
            textBox_N.Text = "50";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(267, 9);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 0;
            label4.Text = "N:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(166, 9);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 0;
            label3.Text = "d:";
            // 
            // textBox_B
            // 
            textBox_B.Location = new Point(114, 10);
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(30, 23);
            textBox_B.TabIndex = 1;
            textBox_B.Text = "12";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(88, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 0;
            label2.Text = "b:";
            // 
            // textBox_A
            // 
            textBox_A.Location = new Point(38, 10);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(30, 23);
            textBox_A.TabIndex = 1;
            textBox_A.Text = "-4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 0;
            label1.Text = "a:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_resFx);
            panel2.Controls.Add(textBox_resX);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 50);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(formsPlot1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 350);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(formsPlot2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(400, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 350);
            panel4.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(30, 16);
            label9.Name = "label9";
            label9.Size = new Size(46, 17);
            label9.TabIndex = 0;
            label9.Text = "Result:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(88, 16);
            label10.Name = "label10";
            label10.Size = new Size(25, 17);
            label10.TabIndex = 1;
            label10.Text = "X=";
            // 
            // textBox_resX
            // 
            textBox_resX.Enabled = false;
            textBox_resX.Location = new Point(119, 15);
            textBox_resX.Name = "textBox_resX";
            textBox_resX.Size = new Size(32, 23);
            textBox_resX.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(193, 16);
            label11.Name = "label11";
            label11.Size = new Size(39, 17);
            label11.TabIndex = 1;
            label11.Text = "F(X)=";
            // 
            // textBox_resFx
            // 
            textBox_resFx.Enabled = false;
            textBox_resFx.Location = new Point(238, 15);
            textBox_resFx.Name = "textBox_resFx";
            textBox_resFx.Size = new Size(32, 23);
            textBox_resFx.TabIndex = 2;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(400, 350);
            formsPlot1.TabIndex = 0;
            // 
            // formsPlot2
            // 
            formsPlot2.Dock = DockStyle.Fill;
            formsPlot2.Location = new Point(0, 0);
            formsPlot2.Margin = new Padding(4, 3, 4, 3);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(400, 350);
            formsPlot2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Particle Swarm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox_C3;
        private Label label8;
        private TextBox textBox_C2;
        private Label label7;
        private TextBox textBox_C1;
        private Label label6;
        private TextBox textBox_T;
        private Label label5;
        private TextBox textBox_N;
        private Label label4;
        private Label label3;
        private TextBox textBox_B;
        private Label label2;
        private TextBox textBox_A;
        private Label label1;
        private ComboBox cbD;
        private Button button1;
        private Label label10;
        private Label label9;
        private TextBox textBox_resFx;
        private TextBox textBox_resX;
        private Label label11;
        private ScottPlot.FormsPlot formsPlot1;
        private ScottPlot.FormsPlot formsPlot2;
    }
}