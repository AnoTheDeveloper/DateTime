using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_feladat
{
    public partial class ZimaCsanád : Form
    {
        DateTime ma = DateTime.Now;
        DateTime szulido;
        DateTime szulma;
        public ZimaCsanád()
        {
            InitializeComponent();
            label2.Text = ma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Rövid dátum:";
            label2.Text = ma.ToString("d");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Hosszú dátum:";
            label2.Text = ma.ToString("D");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Teljes dátum:";
            label2.Text = ma.ToString("F");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Általános dátum, idő:";
            label2.Text = ma.ToString("g");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Rövid idő:";
            label2.Text = ma.ToString("t");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Hosszú idő:";
            label2.Text = ma.ToString("T");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Legkisebb dátum:";
            label2.Text = ma.ToShortDateString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Legnagyobb dátum:";
            label2.Text = ma.ToLongDateString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "A dátum számértéke:";
            label2.Text = ma.Ticks.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Aktuális dátum:";
            label2.Text = ma.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "Aktuális időpont:";
            label2.Text = ma.TimeOfDay.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "Aktuális nap neve angolul:";
            label2.Text = ma.DayOfWeek.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "Hányadik nap az éveben:";
            label2.Text = ma.DayOfYear.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "Hány napos a hónap:";
            label2.Text = DateTime.DaysInMonth(2019, 2).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "A dátum éve:";
            label2.Text = ma.Year.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "Aktuális hónap:";
            label2.Text = ma.Month.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "Aktuális nap:";
            label2.Text = ma.Day.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "Aktuális óra:";
            label2.Text = ma.Hour.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "Aktuális perc:";
            label2.Text = ma.Minute.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = "Aktuális másodperc:";
            label2.Text = ma.Second.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "Tegnapi nap:";
            label2.Text = ma.AddDays(-1).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "Holnapi nap:";
            label2.Text = ma.AddDays(+1).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text, out szulido))
            {
                DateTime.TryParse(ma.Year + "-" + textBox2.Text + "-" + textBox3.Text, out szulma);
            }
            else label8.Text = "Nem jól adta meg a dátumot!";

            label8.Text = szulma.CompareTo(ma) > 0 ? (ma.Year - szulido.Year - 1).ToString() : (ma.Year - szulido.Year).ToString();
        }
    }
}
