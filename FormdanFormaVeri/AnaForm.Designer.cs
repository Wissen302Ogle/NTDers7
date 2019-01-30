namespace FormdanFormaVeri
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.btn_fontayarla = new System.Windows.Forms.Button();
            this.btn_renkayarla = new System.Windows.Forms.Button();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 52);
            this.label4.TabIndex = 3;
            this.label4.Text = "Önemli Not!!\r\nHedef Form üzerindeki bütün\r\nkontrollerdeki modifier özelliğini\r\npu" +
    "blic yaptık.\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(114, 46);
            this.txt_adi.Multiline = true;
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(125, 29);
            this.txt_adi.TabIndex = 4;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(114, 81);
            this.txt_soyadi.Multiline = true;
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(125, 29);
            this.txt_soyadi.TabIndex = 5;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(114, 116);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(125, 50);
            this.txt_aciklama.TabIndex = 6;
            // 
            // btn_fontayarla
            // 
            this.btn_fontayarla.Location = new System.Drawing.Point(114, 194);
            this.btn_fontayarla.Name = "btn_fontayarla";
            this.btn_fontayarla.Size = new System.Drawing.Size(75, 23);
            this.btn_fontayarla.TabIndex = 7;
            this.btn_fontayarla.Text = "Font Ayarla";
            this.btn_fontayarla.UseVisualStyleBackColor = true;
            this.btn_fontayarla.Click += new System.EventHandler(this.btn_fontayarla_Click);
            // 
            // btn_renkayarla
            // 
            this.btn_renkayarla.Location = new System.Drawing.Point(198, 194);
            this.btn_renkayarla.Name = "btn_renkayarla";
            this.btn_renkayarla.Size = new System.Drawing.Size(75, 23);
            this.btn_renkayarla.TabIndex = 9;
            this.btn_renkayarla.Text = "Renk Ayarla";
            this.btn_renkayarla.UseVisualStyleBackColor = true;
            this.btn_renkayarla.Click += new System.EventHandler(this.btn_renkayarla_Click);
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(198, 242);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(75, 38);
            this.btn_gonder.TabIndex = 10;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(114, 242);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 38);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(379, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 100);
            this.panel1.TabIndex = 12;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.btn_renkayarla);
            this.Controls.Add(this.btn_fontayarla);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Button btn_fontayarla;
        private System.Windows.Forms.Button btn_renkayarla;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel panel1;
    }
}

