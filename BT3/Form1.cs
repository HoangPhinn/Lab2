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
using System.Runtime.Serialization.Formatters.Binary;

namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.lastName = "Tôn";
            st.firstName = "Loan";
            st.age = 22;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileName = File.Create("..\\student.txt");
            binaryFormatter.Serialize(fileName, st);
            fileName.Close();
            MessageBox.Show("Serialize succesful!", "Info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenRead("..\\student.txt");
            Student student = (Student)bf.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Student Name is " + student.firstName);
        }

        [Serializable()]
        public class Student
        {
            public String lastName;
            public String firstName;
            public int age;
        }

    }
}
