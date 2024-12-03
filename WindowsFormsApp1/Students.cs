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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet12.Colleges". При необходимости она может быть перемещена или удалена.
            this.collegesTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet12.Colleges);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet3.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet3.Students);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.studentsBindingSource.EndEdit();
                this.studentsTableAdapter.Update(this.факультативы_для_студентов_бдDataSet3.Students);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int StudentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                studentsBindingSource.Filter = "StudentID = '" + StudentID.ToString() + "'";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 1) текущей строки
                string FirstName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                studentsBindingSource.Filter = $"FirstName = '{FirstName}'";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 1) текущей строки
                string LastName = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                studentsBindingSource.Filter = $"LastName = '{LastName}'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentsBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
