using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormdanFormaVeri
{
    public partial class AnaForm : Form
    {
        HedefForm hdform = new HedefForm();
        /*AnaFormda girilen verileri hedef formda göstermek için
          HedefForm için instance oluşturduk. */
        public AnaForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_fontayarla_Click(object sender, EventArgs e)
        {
            FontAl(); //fontları alma metotunu çağırdık
        }

        private void btn_renkayarla_Click(object sender, EventArgs e)
        {
            RenkAl(); //renkleri alma metotunu çağırdık
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clear(); //Silme metotunu çağırdık.
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            GonderilecekVeriler(); //Gönderilecek verileri alma metotunu çağırdık
        }

        public void RenkAl()
        {
            ColorDialog renk = new ColorDialog();
            renk.ShowDialog();
            txt_adi.ForeColor = renk.Color;
            txt_soyadi.ForeColor = renk.Color;
            txt_aciklama.ForeColor = renk.Color;
        }

        public void FontAl()
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            txt_adi.Font = font.Font;
            txt_soyadi.Font = font.Font;
            txt_aciklama.Font = font.Font;
        }
        public void Clear()
        {
            txt_adi.Clear();
            txt_soyadi.Clear();
            txt_aciklama.Clear();
            hdform.Close();
        }

        public void GonderilecekVeriler()
        {
            hdform.lbl_adi.Text = txt_adi.Text.Substring(0, 1).ToUpper() + txt_adi.Text.Substring(1);
            hdform.lbl_adi.Font = txt_adi.Font;
            hdform.lbl_adi.ForeColor = txt_adi.ForeColor;

            hdform.lbl_soyadi.Text = txt_soyadi.Text.ToUpper();
            hdform.lbl_soyadi.Font = txt_soyadi.Font;
            hdform.lbl_soyadi.ForeColor = txt_soyadi.ForeColor;

            hdform.lbl_aciklama.Text = txt_aciklama.Text;
            hdform.lbl_aciklama.Font = txt_aciklama.Font;
            hdform.lbl_aciklama.ForeColor = txt_aciklama.ForeColor;

            hdform.Show();
            this.Hide();
        }
    }
}
