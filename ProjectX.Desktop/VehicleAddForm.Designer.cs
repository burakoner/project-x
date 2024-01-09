namespace ProjectX.Desktop
{
    partial class VehicleAddForm
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
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "Yeni Araç Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marka";
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(73, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(302, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 15);
            label3.TabIndex = 1;
            label3.Text = "Model";
            // 
            // textBox2
            // 
            textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox2.Location = new System.Drawing.Point(73, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(302, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(32, 15);
            label4.TabIndex = 1;
            label4.Text = "Yakıt";
            // 
            // textBox3
            // 
            textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox3.Location = new System.Drawing.Point(73, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(302, 23);
            textBox3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 146);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(20, 15);
            label5.TabIndex = 1;
            label5.Text = "Yıl";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 175);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(40, 15);
            label6.TabIndex = 1;
            label6.Text = "Notlar";
            // 
            // textBox5
            // 
            textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox5.Location = new System.Drawing.Point(73, 172);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(302, 153);
            textBox5.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(300, 331);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(73, 143);
            numericUpDown1.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(302, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1980, 0, 0, 0 });
            // 
            // VehicleAddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(387, 372);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VehicleAddForm";
            Text = "VehicleAddForm";
            Load += VehicleAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}