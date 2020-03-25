using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Hesapla_App
{
    public partial class Form1 : Form
    {
        #region Parameters

        int a, b, alan;

        #endregion

        #region Methods

        public int AlanHesapla(int x, int y)
        {
            return x*y;
        }

        public int AlanHesapla(string t, string u)
        {
            a = int.Parse(t);
            b = int.Parse(u);

            alan = a * b;

            return alan;
        }

        

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);
            //b = int.Parse(textBox2.Text);

            //alan = a * b;

            //label3.Text = alan.ToString();

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            label3.Text = AlanHesapla(a,b).ToString();

            //label3.Text = AlanHesapla(textBox1.Text, textBox2.Text).ToString();
        }
    }
}
