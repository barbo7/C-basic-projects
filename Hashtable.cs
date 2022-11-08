using System;
using System.Collections;

using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hashtable deneme = new Hashtable();
            
            deneme.Add(1, "Kaan");
            deneme.Add(2, "Halil");

            deneme[3] = "Bora";
            deneme[4] = "Emrah";

            ICollection anahtar = deneme.Keys;
            ICollection değer = deneme.Values;

            foreach (var s in anahtar)
                listBox1.Items.Add(s);

            foreach (var s in değer)
                listBox2.Items.Add(s);

            listBox2.Items.Add("Toplam kelime sayısı: " + deneme.Count);
        }
    }
}
