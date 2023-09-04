namespace Latihan1_Kalkulator
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
            tbPertama = new TextBox();
            tbKedua = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            label3 = new Label();
            tbHasil = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbPertama
            // 
            tbPertama.Location = new Point(184, 60);
            tbPertama.Name = "tbPertama";
            tbPertama.Size = new Size(193, 27);
            tbPertama.TabIndex = 0;
            // 
            // tbKedua
            // 
            tbKedua.Location = new Point(184, 121);
            tbKedua.Name = "tbKedua";
            tbKedua.Size = new Size(193, 27);
            tbKedua.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 67);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 2;
            label1.Text = "Nilai Pertama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 124);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Nilai Kedua";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnPlus, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMinus, 0, 1);
            tableLayoutPanel1.Controls.Add(btnMultiply, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDivide, 1, 1);
            tableLayoutPanel1.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel1.Location = new Point(98, 257);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(250, 113);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(3, 3);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(77, 50);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(3, 59);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(77, 51);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(86, 3);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(77, 50);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(86, 59);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(77, 51);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Location = new Point(169, 3);
            btnClear.Name = "btnClear";
            tableLayoutPanel1.SetRowSpan(btnClear, 2);
            btnClear.Size = new Size(78, 107);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 182);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Hasil";
            // 
            // tbHasil
            // 
            tbHasil.Location = new Point(184, 179);
            tbHasil.Name = "tbHasil";
            tbHasil.Size = new Size(193, 27);
            tbHasil.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(tbHasil);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbKedua);
            Controls.Add(tbPertama);
            Name = "Form1";
            Text = "Simple Kalkulator";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPertama;
        private TextBox tbKedua;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClear;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Label label3;
        private TextBox tbHasil;
    }
}