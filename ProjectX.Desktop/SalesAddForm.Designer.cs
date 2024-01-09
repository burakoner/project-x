namespace ProjectX.Desktop
{
    partial class SalesAddForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(176, 32);
            label1.TabIndex = 0;
            label1.Text = "Yeni Araç Kirala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Araç";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBox1.DisplayMember = "Model";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(132, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(324, 23);
            comboBox1.TabIndex = 2;
            comboBox1.ValueMember = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Müşteri";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBox2.DisplayMember = "Adi";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(132, 86);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(324, 23);
            comboBox2.TabIndex = 2;
            comboBox2.ValueMember = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 15);
            label4.TabIndex = 1;
            label4.Text = "Kaç Gün Kiralanacak?";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown1.Location = new System.Drawing.Point(133, 115);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(323, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(11, 147);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(103, 15);
            label5.TabIndex = 1;
            label5.Text = "Günlük Kira Bedeli";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown2.Location = new System.Drawing.Point(132, 144);
            numericUpDown2.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(323, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(11, 176);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 15);
            label6.TabIndex = 1;
            label6.Text = "Yakıt Miktarı";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown3.Location = new System.Drawing.Point(132, 173);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(323, 23);
            numericUpDown3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(11, 205);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 15);
            label7.TabIndex = 1;
            label7.Text = "Araç";
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(132, 202);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(323, 234);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(380, 442);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Kirala";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SalesAddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(468, 478);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(numericUpDown3);
            Controls.Add(label6);
            Controls.Add(numericUpDown2);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SalesAddForm";
            Text = "SalesAddForm";
            Load += SalesAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}