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
    public partial class Anaform : Form
    {
        RenkDegistirenForm frm;
        public Anaform()
        {
            InitializeComponent();
            frm = new RenkDegistirenForm(this);
            
        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            //timer1.Interval = 10000;
            //timer1.Start();
        }

        private void btnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            //frm.Show();
            
           // RenkDegistirenForm frm = new RenkDegistirenForm(this);
            frm.ShowDialog();
            this.BackColor = frm.YeniRengiAl(this.BackColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.BackColor = frm.YeniRengiAl(BackColor);
        }
    }
}
