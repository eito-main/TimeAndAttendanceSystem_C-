using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Time_and_attendance_system_re
{
    public partial class WorkSchedual : Form
    {
        private work_schedual_type displayType;
        CsvAccess csvOutput = new CsvAccess();

        public WorkSchedual(work_schedual_type schedualType)
        {
            InitializeComponent();
            displayType = schedualType;
        }

        private void WorkSchedual_Load(object sender, EventArgs e)
        {
            switch (displayType)
            {
                case work_schedual_type.individual:

                    individualDgvSetup();
                    individualDataSet();
                    csvInputB.Visible = false;
                    break;

                case work_schedual_type.all:

                    AllDataAccess allDataAccess = new AllDataAccess();
                    allDataAccess.dataGet();
                    allDgvSetup();
                    allIndividualDataSet();
                    break;
            }
            workSchedualDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            workSchedualDataGridView.AllowUserToAddRows = false;
        }
        private void csvInputB_Click(object sender, EventArgs e)
        {
            csvOutput.inputCSV(@"C:\test\test2.csv");
            reDraw();
        }
        private void csvButton_Click(object sender, EventArgs e)
        {
            csvOutput.outputCSV("C:\test", work_schedual_type.all);
        }

        void individualDgvSetup()
        {
            DataGridViewTextBoxColumn workdayDgvColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn attendanceTimeDgvColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn leavingTimeDgvColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn restTimeDgvColumn = new DataGridViewTextBoxColumn();

            workdayDgvColumn.HeaderText = "日付";
            attendanceTimeDgvColumn.HeaderText = "出勤時間";
            leavingTimeDgvColumn.HeaderText = "退勤時間";
            restTimeDgvColumn.HeaderText = "休憩時間";

            workSchedualDataGridView.Columns.Add(workdayDgvColumn);
            workSchedualDataGridView.Columns.Add(attendanceTimeDgvColumn);
            workSchedualDataGridView.Columns.Add(leavingTimeDgvColumn);
            workSchedualDataGridView.Columns.Add(restTimeDgvColumn);
        }

        void allDgvSetup()
        {
            DataGridViewTextBoxColumn workdayDgvColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn nameDgvColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn departmentDgvColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn attendanceTimeDgvColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn leavingTimeDgvColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn restTimeDgvColumn = new DataGridViewTextBoxColumn();

            workdayDgvColumn.HeaderText = "日付";
            nameDgvColumn.HeaderText = "名前";
            departmentDgvColumn.HeaderText = "部門";
            attendanceTimeDgvColumn.HeaderText = "出勤時間";
            leavingTimeDgvColumn.HeaderText = "退勤時間";
            restTimeDgvColumn.HeaderText = "休憩時間";

            workSchedualDataGridView.Columns.Add(workdayDgvColumn);
            workSchedualDataGridView.Columns.Add(nameDgvColumn);
            workSchedualDataGridView.Columns.Add(departmentDgvColumn);
            workSchedualDataGridView.Columns.Add(attendanceTimeDgvColumn);
            workSchedualDataGridView.Columns.Add(leavingTimeDgvColumn);
            workSchedualDataGridView.Columns.Add(restTimeDgvColumn);
        }

        void individualDataSet()
        {
            int rowaaa = 0;
            while (IndividualAttendance.AttendanceDatas.Count > rowaaa)
            {
                workSchedualDataGridView.Rows.Add(new DataGridViewRow());

                workSchedualDataGridView.Rows[rowaaa].Cells[0].Value = IndividualAttendance.AttendanceDatas[rowaaa].date;
                workSchedualDataGridView.Rows[rowaaa].Cells[1].Value = IndividualAttendance.AttendanceDatas[rowaaa].attendanceTime;
                workSchedualDataGridView.Rows[rowaaa].Cells[2].Value = IndividualAttendance.AttendanceDatas[rowaaa].leavingTime;
                workSchedualDataGridView.Rows[rowaaa].Cells[3].Value = IndividualAttendance.AttendanceDatas[rowaaa].restTime;
                rowaaa++;
            }
        }

        void allIndividualDataSet()
        {
            int rowaaa = 0;
            while (AllAttendance.AllIndivisualDatas.Count > rowaaa)
            {
                workSchedualDataGridView.Rows.Add(new DataGridViewRow());

                workSchedualDataGridView.Rows[rowaaa].Cells[0].Value = AllAttendance.AllIndivisualDatas[rowaaa].attendanceData.date;
                workSchedualDataGridView.Rows[rowaaa].Cells[1].Value = AllAttendance.AllIndivisualDatas[rowaaa].userData.name;
                workSchedualDataGridView.Rows[rowaaa].Cells[2].Value = AllAttendance.AllIndivisualDatas[rowaaa].userData.department;
                workSchedualDataGridView.Rows[rowaaa].Cells[3].Value = AllAttendance.AllIndivisualDatas[rowaaa].attendanceData.attendanceTime;
                workSchedualDataGridView.Rows[rowaaa].Cells[4].Value = AllAttendance.AllIndivisualDatas[rowaaa].attendanceData.leavingTime;
                workSchedualDataGridView.Rows[rowaaa].Cells[5].Value = AllAttendance.AllIndivisualDatas[rowaaa].attendanceData.restTime;
                rowaaa++;
            }
        }

        void reDraw()
        {
            switch (displayType)
            {
                case work_schedual_type.individual:

                    individualDgvSetup();
                    individualDataSet();
                    csvInputB.Visible = false;
                    break;

                case work_schedual_type.all:

                    AllDataAccess allDataAccess = new AllDataAccess();
                    allDataAccess.dataGet();
                    allDgvSetup();
                    allIndividualDataSet();
                    break;
            }
        }
    }
}
