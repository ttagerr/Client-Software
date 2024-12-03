using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Начальная : Form
    {
        public Начальная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 myForm7 = new Form7();
            myForm7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Electives myForm = new Electives();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grades myForm = new Grades();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Professors myForm = new Professors();
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Schedules myForm = new Schedules();
            myForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Students myForm = new Students();
            myForm.Show();
        }
    }
}
