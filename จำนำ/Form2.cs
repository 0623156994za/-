using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace จำนำ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                Form4 fm  = new Form4();
                fm.Show();

            this.Hide();
        }
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
