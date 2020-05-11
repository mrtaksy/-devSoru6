using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ÖdevSoru6
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fw;
            StreamWriter sw;
            fw = new FileStream("c:\\Deneme.txt", FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(fw);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            fw.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 OtoparkYerleri = new Form3();
            OtoparkYerleri.ShowDialog();
        }
    }
}
