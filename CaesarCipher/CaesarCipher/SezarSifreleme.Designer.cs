namespace CaesarCipher
{
    partial class SezarSifreleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYaziSifre = new System.Windows.Forms.RichTextBox();
            this.buton1 = new System.Windows.Forms.Button();
            this.txtAnahtarSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buton2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSifrelenenYazi = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şifreÇözToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programdanÇıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYaziSifre);
            this.groupBox1.Controls.Add(this.buton1);
            this.groupBox1.Controls.Add(this.txtAnahtarSayi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifrelenecek";
            // 
            // txtYaziSifre
            // 
            this.txtYaziSifre.BackColor = System.Drawing.Color.GhostWhite;
            this.txtYaziSifre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYaziSifre.Location = new System.Drawing.Point(221, 68);
            this.txtYaziSifre.Name = "txtYaziSifre";
            this.txtYaziSifre.Size = new System.Drawing.Size(370, 123);
            this.txtYaziSifre.TabIndex = 4;
            this.txtYaziSifre.Text = "";
            // 
            // buton1
            // 
            this.buton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buton1.ForeColor = System.Drawing.Color.GhostWhite;
            this.buton1.Location = new System.Drawing.Point(46, 156);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(83, 35);
            this.buton1.TabIndex = 2;
            this.buton1.Text = "Onayla";
            this.buton1.UseVisualStyleBackColor = false;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // txtAnahtarSayi
            // 
            this.txtAnahtarSayi.BackColor = System.Drawing.Color.GhostWhite;
            this.txtAnahtarSayi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAnahtarSayi.Location = new System.Drawing.Point(221, 32);
            this.txtAnahtarSayi.Name = "txtAnahtarSayi";
            this.txtAnahtarSayi.Size = new System.Drawing.Size(370, 26);
            this.txtAnahtarSayi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifrelenecek yazıyı girin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anahtar sayıyı girin:";
            // 
            // buton2
            // 
            this.buton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.buton2.ForeColor = System.Drawing.Color.GhostWhite;
            this.buton2.Location = new System.Drawing.Point(46, 124);
            this.buton2.Name = "buton2";
            this.buton2.Size = new System.Drawing.Size(83, 35);
            this.buton2.TabIndex = 3;
            this.buton2.Text = "Temizle";
            this.buton2.UseVisualStyleBackColor = false;
            this.buton2.Click += new System.EventHandler(this.buton2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSifrelenenYazi);
            this.groupBox2.Controls.Add(this.buton2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(13, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 207);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifrelenen";
            // 
            // txtSifrelenenYazi
            // 
            this.txtSifrelenenYazi.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSifrelenenYazi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSifrelenenYazi.Location = new System.Drawing.Point(221, 36);
            this.txtSifrelenenYazi.Name = "txtSifrelenenYazi";
            this.txtSifrelenenYazi.Size = new System.Drawing.Size(370, 123);
            this.txtSifrelenenYazi.TabIndex = 4;
            this.txtSifrelenenYazi.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifrelenen yazı:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreÇözToolStripMenuItem,
            this.programdanÇıkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // şifreÇözToolStripMenuItem
            // 
            this.şifreÇözToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.şifreÇözToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifreÇözToolStripMenuItem.ForeColor = System.Drawing.Color.GhostWhite;
            this.şifreÇözToolStripMenuItem.Name = "şifreÇözToolStripMenuItem";
            this.şifreÇözToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.şifreÇözToolStripMenuItem.Text = "Şifre Çöz";
            this.şifreÇözToolStripMenuItem.Click += new System.EventHandler(this.şifreÇözToolStripMenuItem_Click);
            // 
            // programdanÇıkToolStripMenuItem
            // 
            this.programdanÇıkToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.programdanÇıkToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.programdanÇıkToolStripMenuItem.ForeColor = System.Drawing.Color.GhostWhite;
            this.programdanÇıkToolStripMenuItem.Name = "programdanÇıkToolStripMenuItem";
            this.programdanÇıkToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.programdanÇıkToolStripMenuItem.Text = "Programdan Çık";
            this.programdanÇıkToolStripMenuItem.Click += new System.EventHandler(this.programdanÇıkToolStripMenuItem_Click);
            // 
            // SezarSifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(658, 483);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SezarSifreleme";
            this.ShowIcon = false;
            this.Text = "Sezar Şifrelemesi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.TextBox txtAnahtarSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buton2;
        private System.Windows.Forms.RichTextBox txtYaziSifre;
        private System.Windows.Forms.RichTextBox txtSifrelenenYazi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şifreÇözToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programdanÇıkToolStripMenuItem;
    }
}

