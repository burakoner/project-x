namespace ProjectX.Desktop
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            operatörleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            müşterileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            araçlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            satışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            satışlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            çıkıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dosyaToolStripMenuItem, müşterilerToolStripMenuItem, araçlarToolStripMenuItem, satışlarToolStripMenuItem, çıkıToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { operatörleriGösterToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            dosyaToolStripMenuItem.Text = "Operatörler";
            // 
            // operatörleriGösterToolStripMenuItem
            // 
            operatörleriGösterToolStripMenuItem.Name = "operatörleriGösterToolStripMenuItem";
            operatörleriGösterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            operatörleriGösterToolStripMenuItem.Text = "Operatörleri Göster";
            operatörleriGösterToolStripMenuItem.Click += operatorleriGosterToolStripMenuItem_Click;
            // 
            // müşterilerToolStripMenuItem
            // 
            müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { müşterileriGösterToolStripMenuItem });
            müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşterileriGösterToolStripMenuItem
            // 
            müşterileriGösterToolStripMenuItem.Name = "müşterileriGösterToolStripMenuItem";
            müşterileriGösterToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            müşterileriGösterToolStripMenuItem.Text = "Müşterileri Göster";
            müşterileriGösterToolStripMenuItem.Click += musterileriGosterToolStripMenuItem_Click;
            // 
            // araçlarToolStripMenuItem
            // 
            araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { araçlarıGösterToolStripMenuItem });
            araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // araçlarıGösterToolStripMenuItem
            // 
            araçlarıGösterToolStripMenuItem.Name = "araçlarıGösterToolStripMenuItem";
            araçlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            araçlarıGösterToolStripMenuItem.Text = "Araçları Göster";
            araçlarıGösterToolStripMenuItem.Click += araclariGosterToolStripMenuItem_Click;
            // 
            // satışlarToolStripMenuItem
            // 
            satışlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { satışlarıGösterToolStripMenuItem });
            satışlarToolStripMenuItem.Name = "satışlarToolStripMenuItem";
            satışlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            satışlarToolStripMenuItem.Text = "Satışlar";
            // 
            // satışlarıGösterToolStripMenuItem
            // 
            satışlarıGösterToolStripMenuItem.Name = "satışlarıGösterToolStripMenuItem";
            satışlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            satışlarıGösterToolStripMenuItem.Text = "Satışları Göster";
            satışlarıGösterToolStripMenuItem.Click += satislariGosterToolStripMenuItem_Click;
            // 
            // çıkıToolStripMenuItem
            // 
            çıkıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { çıkışYapToolStripMenuItem });
            çıkıToolStripMenuItem.Name = "çıkıToolStripMenuItem";
            çıkıToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            çıkıToolStripMenuItem.Text = "Çıkış";
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Project X";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatörleriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterileriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışlarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}
