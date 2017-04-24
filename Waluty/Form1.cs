using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waluty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Waluta waluta;
         
        private void Waluty_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Waluty_listBox.SelectedIndex == 0)
                Flaga_pictureBox.Image = Properties.Resources.EURO;
            if (Waluty_listBox.SelectedIndex == 1)
                Flaga_pictureBox.Image = Properties.Resources.USA;
            if (Waluty_listBox.SelectedIndex == 2)
                Flaga_pictureBox.Image = Properties.Resources.GBR;
            else if (Waluty_listBox.SelectedIndex == 3)
                Flaga_pictureBox.Image = Properties.Resources.CHF;

            OdswiezDane();
        }
        void OdswiezDane()
        {
            waluta = new Waluta(Data_TimePicker.Value.ToString("yyyy-MM-dd"), Waluty_listBox.SelectedIndex);
            waluta.PobierzDane();
            Kurs_label.Text = waluta.Kurs;
            Waluta_label.Text = waluta.NazwaWaluty;
        }
        
        private void btn_wyczysc_Click(object sender, EventArgs e)
        {
            rtb_historia.Clear();
        }

        private void btn_dodajDoHistorii_Click(object sender, EventArgs e)
        {
            OdswiezDane();
            rtb_historia.AppendText(waluta.Data + "  " + waluta.NazwaWaluty + "  " + waluta.Kurs + "\n");
        }
    }
}
