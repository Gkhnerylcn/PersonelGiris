using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel1 = new Personel();
            personel1.ScilNo = 405;
            personel1.Ad = "Gökhan";
            personel1.SoyAd = "Eryalçın";
            personel1.Adres = "Beşiktaş";
            personel1.DoğumTarihi = DateTime.Now;
            personel1.IsegirisTarihi = DateTime.Now;
            personel1.Telefon = 2121212;

            string Ad = personel1.PersonelBilgileri();

            txtscil.Text = personel1.ScilNo.ToString();
            txtad.Text = personel1.Ad.ToString();
            txtsoyad.Text = personel1.SoyAd.ToString();
            txttelefon.Text = personel1.Telefon.ToString();
            rchtxtadres.Text = personel1.Adres.ToString();

            









        }
    }
}
