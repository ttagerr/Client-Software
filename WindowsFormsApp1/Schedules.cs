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
    public partial class Schedules : Form
    {
        public Schedules()
        {
            InitializeComponent();
        }

        private void Schedules_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet11.Electives". При необходимости она может быть перемещена или удалена.
            this.electivesTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet11.Electives);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "факультативы_для_студентов_бдDataSet2.Schedules". При необходимости она может быть перемещена или удалена.
            this.schedulesTableAdapter.Fill(this.факультативы_для_студентов_бдDataSet2.Schedules);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.schedulesBindingSource.EndEdit();
                this.schedulesTableAdapter.Update(this.факультативы_для_студентов_бдDataSet2.Schedules);
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
                int ScheduleID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                schedulesBindingSource.Filter = "ScheduleID = '" + ScheduleID.ToString() + "'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Получаем значение из четвертой колонки (индекс 1) текущей строки
                string DayOfWeek = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                // Устанавливаем фильтр для BindingSource
                schedulesBindingSource.Filter = $"DayOfWeek = '{DayOfWeek}'";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schedulesBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
    }

