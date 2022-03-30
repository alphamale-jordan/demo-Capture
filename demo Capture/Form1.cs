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

namespace demo_Capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\Alex Moyo\\source\\repos\\demo Capture\\demo Capture\\DEMO FILE\\demo.txt";
           
          

            using (StreamWriter alex = new StreamWriter(path, true))
            {
              
                alex.Write("\n"+ "  " + txtName.Text +  ",");
                alex.Write      ("  "+ txtSurname.Text + "," );
                alex.Write      ("  "+ txtAge.Text + ",");
                alex.Write      ("  "+ cbGender.Text + ",");
                alex.Write      ("  "+cbCity.Text);

                MessageBox.Show("Details have been captured successfuly");

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string pat = @"C:\\Users\\Alex Moyo\\source\\repos\\demo Capture\\demo Capture\\DEMO FILE\\demo.txt";
            var str = File.ReadAllText(pat);
            richTextBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search hi = new Search();
            hi.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
