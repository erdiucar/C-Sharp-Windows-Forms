using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedResistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ledGerilim = float.Parse(ledGerilimText.Text);
            float beslemeGerilim = float.Parse(beslemeGerilimText.Text);
            float ledAkim = float.Parse(ledAkimText.Text) / 1000;

            float direncSonuc = ((beslemeGerilim - ledGerilim) / ledAkim);

            label3.Text = direncSonuc.ToString() + " Ohm'dan yüksek en yakın direnci devreye bağlayın";
        }
    }
}
