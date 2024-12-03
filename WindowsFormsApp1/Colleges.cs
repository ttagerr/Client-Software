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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet7.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet7.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet.Colleges". При необходимости она может быть перемещена или удалена.
            this.collegesTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet.Colleges);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.collegesBindingSource.EndEdit();
                this.collegesTableAdapter.Update(this.факультативы_для_студентов_бдDataSet.Colleges);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int CollegeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                collegesBindingSource.Filter = "CollegeID = '" + CollegeID.ToString() + "'";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 3) текущей строки
                string Address = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                collegesBindingSource.Filter = $"Address = '{Address}'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 4) текущей строки
                string PhoneNumber = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                collegesBindingSource.Filter = $"PhoneNumber = '{PhoneNumber}'";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            collegesBindingSource.Filter = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
