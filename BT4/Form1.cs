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

namespace BT4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FileStream fs;
            if (!File.Exists("D://Pass.txt"))
            {
                fs = new FileStream("D://Pass.txt", FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);

                sWriter.WriteLine("Hello World!");
                sWriter.Flush();
                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D://Pass.txt", FileMode.Open);
            StreamWriter writeFile = new StreamWriter(fs, Encoding.UTF8);
            if (checkBox1.Checked == true)
            {
                writeFile.WriteLine(textBox1.Text);
                writeFile.WriteLine(textBox2.Text);
                writeFile.WriteLine("1");
                writeFile.Flush();
            }
            else writeFile.WriteLine("0");
            writeFile.Close();
        }
    }
}
