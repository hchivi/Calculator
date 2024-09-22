namespace Calculator
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
            btnCong = new Button();
            label1 = new Label();
            txtA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtB = new TextBox();
            label4 = new Label();
            txtKQ = new TextBox();
            btnTru = new Button();
            SuspendLayout();
            // 
            // btnCong
            // 
            btnCong.Location = new Point(285, 235);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(66, 38);
            btnCong.TabIndex = 0;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 1;
            label1.Text = "Tính toán";
            label1.Click += label1_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(116, 76);
            txtA.Name = "txtA";
            txtA.Size = new Size(235, 39);
            txtA.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 80);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 1;
            label2.Text = "Số a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 125);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 1;
            label3.Text = "Số b:";
            // 
            // txtB
            // 
            txtB.Location = new Point(116, 121);
            txtB.Name = "txtB";
            txtB.Size = new Size(235, 39);
            txtB.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 169);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 1;
            label4.Text = "Kết quả:";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(116, 166);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(235, 39);
            txtKQ.TabIndex = 2;
            txtKQ.TextChanged += textBox3_TextChanged;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(213, 235);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(66, 38);
            btnTru.TabIndex = 0;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 306);
            Controls.Add(txtKQ);
            Controls.Add(label4);
            Controls.Add(txtB);
            Controls.Add(label3);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Font = new Font("Segoe UI", 14F);
            ForeColor = Color.CornflowerBlue;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Tính toán ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCong;
        private Label label1;
        private TextBox txtA;
        private Label label2;
        private Label label3;
        private TextBox txtB;
        private Label label4;
        private TextBox txtKQ;
        private Button btnTru;
    }
}
