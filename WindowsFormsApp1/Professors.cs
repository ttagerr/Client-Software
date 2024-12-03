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
    public partial class Professors : Form
    {
        public Professors()
        {
            InitializeComponent();
        }

        private void Professors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet10.Electives". При необходимости она может быть перемещена или удалена.
            this.electivesTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet10.Electives);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet1.Professors". При необходимости она может быть перемещена или удалена.
            this.professorsTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet1.Professors);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.professorsBindingSource.EndEdit();
                this.professorsTableAdapter.Update(this.факультативы_для_студентов_бдDataSet1.Professors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int ProfessorID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                professorsBindingSource.Filter = "ProfessorID = '" + ProfessorID.ToString() + "'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 3) текущей строки
                string Email = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                professorsBindingSource.Filter = $"Email = '{Email}'";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 5) текущей строки
                string PhoneNumber = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                professorsBindingSource.Filter = $"PhoneNumber = '{PhoneNumber}'";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            professorsBindingSource.Filter = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
