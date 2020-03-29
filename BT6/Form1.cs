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
using System.Collections;

namespace BT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string TinhToan(string s1, string s2, string s3)
        {

           if (s3 == "+") s1 = (double.Parse(s1) + double.Parse(s2)).ToString();
           if (s3 == "-") s1 = (double.Parse(s1) - double.Parse(s2)).ToString();
           if (s3 == "*") s1 = (double.Parse(s1) * double.Parse(s2)).ToString();
           if (s3 == "/") s1 = (double.Parse(s1) / double.Parse(s2)).ToString();
           return s1;
        }
        char TinhToan(char s1, char s2, char s3)
        {

            if (s3 == '+') s1 = char.Parse((double.Parse(s1.ToString()) + double.Parse(s2.ToString())).ToString());
            if (s3 == '-') s1 = char.Parse((double.Parse(s1.ToString()) - double.Parse(s2.ToString())).ToString());
            if (s3 == '*') s1 = char.Parse((double.Parse(s1.ToString()) * double.Parse(s2.ToString())).ToString());
            if (s3 == '/') s1 = char.Parse((double.Parse(s1.ToString()) / double.Parse(s2.ToString())).ToString());

            return s1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String[] x = new String[100];
            FileStream fs1 = new FileStream("D://Input.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs1);

            FileStream fs2 = new FileStream("D://Output.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs2);

            string a = "";
            ArrayList arrText = new ArrayList();

            //String[] a = File.ReadAllLines("D://Input.txt");
            //foreach (String b in a)
            //{

            //    String[] arr = b.Split();
            //    arr[0] = x[1];
            //}

            while (a != null)
            {
                a = sr.ReadLine();                
                sw.WriteLine(a + "=" + (TinhToan(a[1], a[3], a[2])));
                if (a != null)arrText.Add(a);
            }
            sr.Close();
        }
    }
}
