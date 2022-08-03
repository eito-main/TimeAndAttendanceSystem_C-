using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_and_attendance_system_re
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void stampingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stamping stamping = new Stamping();
            stamping.ShowDialog();
            this.Show();
        }

        private void workScheduleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkSchedual workSchedual = new WorkSchedual(work_schedual_type.individual);
            workSchedual.ShowDialog();
            this.Show();
        }
        private void todoListButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start($"{EnvironmentalData.todoListPath}");
        }

        private void allWorkSchedualButton_Click(object sender, EventArgs e)
        {
            if (LogInAccount.Director == "PL")
            {
                this.Hide();
                WorkSchedual workSchedual = new WorkSchedual(work_schedual_type.all);
                workSchedual.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("アクセス権限がありません");
            }
        }
    }
}
