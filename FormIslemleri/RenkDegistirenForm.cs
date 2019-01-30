using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIslemleri
{
    public partial class RenkDegistirenForm : Form
    {
        public Form BaglananAnaForm;
        public RenkDegistirenForm(Form p)
        {
            InitializeComponent();
            BaglananAnaForm = p;
        }

        private void RenkDegistirenForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRenkDegistir_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            Hide();
            
            //try
            //{
            //    if (BaglananAnaForm != null)
            //    {
            //        BaglananAnaForm.BackColor = YeniRengiAl(BaglananAnaForm.BackColor);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Renk Değeri Tanımlı Değil.");
            //}
        }

        private void txtRenkGirisi_TextChanged(object sender, EventArgs e)
        {

        }

        public Color YeniRengiAl(Color OncekiRenk)
        {
            try
            {
                return RenkKodunaCevir(txtRenkGirisi.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Girilen Renk Tanımlı Değil.Önceki renk uygulandı.");
                return OncekiRenk;
            }
        }
       public Color RenkKodunaCevir(string RenkMetni)
        {
            switch (RenkMetni.ToLower())
            {
                case "kırmızı":
                    return Color.Red;
                case "mavi":
                    return Color.Blue;
                case "yeşil":
                    return Color.Green;
                default:
                    throw new NotImplementedException();
                    
            }
        }


    }
    
}
