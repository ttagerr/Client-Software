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
    public partial class Electives : Form
    {
        public Electives()
        {
            InitializeComponent();
        }

        private void Electives_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet8.Professors". При необходимости она может быть перемещена или удалена.
            this.professorsTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet8.Professors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet6.Electives". При необходимости она может быть перемещена или удалена.
            this.electivesTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet6.Electives);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.electivesBindingSource.EndEdit();
                this.electivesTableAdapter.Update(this.факультативы_для_студентов_бдDataSet6.Electives);
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
                int ElectiveID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                electivesBindingSource.Filter = "ElectiveID = '" + ElectiveID.ToString() + "'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int ProfessorID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                electivesBindingSource.Filter = "ProfessorID = '" + ProfessorID.ToString() + "'";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 1) текущей строки
                string ElectiveName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                electivesBindingSource.Filter = $"ElectiveName = '{ElectiveName}'";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            electivesBindingSource.Filter = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
