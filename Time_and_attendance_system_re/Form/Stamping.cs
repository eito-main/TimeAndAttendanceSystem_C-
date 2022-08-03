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
    public partial class Stamping : Form
    {
        IndividualDataAccess individualDataAccess = new IndividualDataAccess();

        public Stamping()
        {
            InitializeComponent();
            statusSet();
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            string time = DateTime.Now.ToString("HH:mm:ss");

            individualDataAccess.attendance(date, time);
            statusSet();
        }

        private void restButton_Click(object sender, EventArgs e)
        {
        }

        private void leavingButton_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");

            individualDataAccess.leaving(time);
            statusSet();
        }

        private void statusSet()
        {
            switch (LogInAccount.Working_Type)
            {
                case working_type.leaving:
                    statusLabel.Text = "勤務外";
                    return;

                case working_type.working:
                    statusLabel.Text = "勤務中";
                    return;
            }
        }
    }
}
