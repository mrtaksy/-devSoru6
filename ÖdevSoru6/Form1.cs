using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ÖdevSoru6
{
    public partial class Form1 : Form
    {
        public Form2 frm2;

        public Form3 frm3;
        public Form1()
        {
            InitializeComponent();

            frm2 = new Form2();

            frm3 = new Form3();

            frm2.frm1 = this;

            frm3.frm1 = this;
        }
        
              
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr=new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();
                while (satir != null)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 kayıtGirisi = new Form2();
            kayıtGirisi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 OtoparkYerleri = new Form3();
            
            OtoparkYerleri.ShowDialog();
           

        }
    }
}
