namespace FormIslemleri
{
    partial class Anaform
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
            this.btnArkaPlanDegistir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnArkaPlanDegistir
            // 
            this.btnArkaPlanDegistir.Location = new System.Drawing.Point(429, 30);
            this.btnArkaPlanDegistir.Name = "btnArkaPlanDegistir";
            this.btnArkaPlanDegistir.Size = new System.Drawing.Size(132, 64);
            this.btnArkaPlanDegistir.TabIndex = 0;
            this.btnArkaPlanDegistir.Text = "Arka Plan Resmini Değiştir";
            this.btnArkaPlanDegistir.UseVisualStyleBackColor = true;
            this.btnArkaPlanDegistir.Click += new System.EventHandler(this.btnArkaPlanDegistir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 369);
            this.Controls.Add(this.btnArkaPlanDegistir);
            this.Name = "Anaform";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArkaPlanDegistir;
        private System.Windows.Forms.Timer timer1;
    }
}

