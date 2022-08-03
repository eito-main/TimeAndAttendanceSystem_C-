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
    class IndividualDataAccess
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public void dataGet()
        {
            conn.ConnectionString = $"Data Source={EnvironmentalData.dataSource} ;Database={EnvironmentalData.database};User ID={EnvironmentalData.databaseId} ;password={EnvironmentalData.databasePassword}";
            conn.Open();
            cmd.CommandText = $"select * from {EnvironmentalData.databaseAttendanceRecordTable} where id = \"{LogInAccount.Id}\"";
            cmd.Connection = conn;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    var attendanceData = new AttendanceData();
                    var attendanceDataList = new List<AttendanceData>();

                    while (reader.Read())
                    {
                        {
                            attendanceData.recordKey = reader[0].ToString();
                            attendanceData.date = reader[2].ToString();
                            attendanceData.attendanceTime = reader[3].ToString();
                            attendanceData.leavingTime = reader[4].ToString();
                            attendanceData.restTime = reader[5].ToString();
                        }
                        attendanceDataList.Add(attendanceData);
                    }
                    IndividualAttendance.AttendanceDatas = attendanceDataList;
                }
            }
            conn.Close();
        }

        public void attendance(string date, string time)
        {
            conn.ConnectionString = $"Data Source={EnvironmentalData.dataSource} ;Database={EnvironmentalData.database};User ID={EnvironmentalData.databaseId} ;password={EnvironmentalData.databasePassword}";
            conn.Open();
            cmd.CommandText = $"insert into {EnvironmentalData.databaseAttendanceRecordTable}({EnvironmentalData.databaseAttendanceRecordTable_id}, {EnvironmentalData.databaseAttendanceRecordTable_date}, {EnvironmentalData.databaseAttendanceRecordTable_attendanceTime}) values (\"{LogInAccount.Id}\", \"{date}\", \"{time}\")";
            cmd.Connection = conn;
            cmd.ExecuteReader();
            conn.Close();
            LogInAccount.Working_Type = working_type.working;
            dataGet();
        }

        public void leaving(string time)
        {
            if (LogInAccount.Working_Type == working_type.leaving) { return; }

            string recordKey = IndividualAttendance.AttendanceDatas[IndividualAttendance.AttendanceDatas.Count - 1].recordKey;

            conn.ConnectionString = $"Data Source={EnvironmentalData.dataSource} ;Database={EnvironmentalData.database};User ID={EnvironmentalData.databaseId} ;password={EnvironmentalData.databasePassword}";
            conn.Open();
            cmd.CommandText = $"update {EnvironmentalData.databaseAttendanceRecordTable} set leaving_time = \"{time}\", rest_time = \"01:00:00\" where recoard_id = {recordKey}";
            cmd.Connection = conn;
            cmd.ExecuteReader();
            conn.Close();
            LogInAccount.Working_Type = working_type.leaving;
            dataGet();
        }
    }
}
