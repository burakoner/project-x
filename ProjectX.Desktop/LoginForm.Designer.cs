namespace ProjectX.Desktop
{
    partial class LoginForm
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
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(30, 158);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(88, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(263, 23);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "a@b.com";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(88, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(263, 23);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "1234";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 28F);
            label3.Location = new System.Drawing.Point(30, 47);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(298, 51);
            label3.TabIndex = 0;
            label3.Text = "Project X - Login";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(264, 184);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(87, 28);
            button1.TabIndex = 3;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(392, 285);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}