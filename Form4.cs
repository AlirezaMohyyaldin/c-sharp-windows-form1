using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_app_c_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strtitle = "C# Message";
            string strtext = textBox1.Text;
            MessageBox.Show("your input is :" + "\n" + strtext, strtitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strtitle = "C# Message";
            string strtext = textBox1.Text;
            MessageBox.Show(strtitle + "\n" + "your input length is" +strtext.Length + "characters",strtitle);
        }
    }
}
