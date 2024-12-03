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
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet9.Electives". При необходимости она может быть перемещена или удалена.
            this.electivesTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet9.Electives);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet5.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter1.Fill(this.факультативы_для_студентов_бдDataSet5.Grades);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet4.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet4.Grades);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.gradesBindingSource.EndEdit();
                this.gradesTableAdapter1.Update(this.факультативы_для_студентов_бдDataSet5.Grades);
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
                int GradeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                gradesBindingSource1.Filter = "GradeID = '" + GradeID.ToString() + "'";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int StudentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                gradesBindingSource1.Filter = "StudentID = '" + StudentID.ToString() + "'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 3) текущей строки
                string Grade = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                gradesBindingSource1.Filter = $"Grade = '{Grade}'";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gradesBindingSource1.Filter = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
