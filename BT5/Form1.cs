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

namespace BT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D://VanBan.txt", FileMode.OpenOrCreate);
            StreamWriter wr = new StreamWriter(fs);
            StreamReader sr = new StreamReader(fs);
            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            wr.WriteLine(textBox1.Text);
            wr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D://VanBan.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            textBox2.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
