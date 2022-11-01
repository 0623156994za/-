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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            fm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();

            this.Hide();
        }
    }
}
