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
    class AllDataAccess
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public void dataGet()
        {
            conn.ConnectionString = $"Data Source={EnvironmentalData.dataSource};" +
                                    $"Database={EnvironmentalData.database};" +
                                    $"User ID={EnvironmentalData.databaseId};" +
                                    $"password={EnvironmentalData.databasePassword}";
            conn.Open();
            cmd.CommandText = $"select {EnvironmentalData.databaseAttendanceRecordTable}.{EnvironmentalData.databaseAttendanceRecordTable_id}, " +
                                     $"{EnvironmentalData.databaseUserInformationTable}.{EnvironmentalData.databaseUserInformationTable_userId}, " +
                                     $"{EnvironmentalData.databaseUserInformationTable}.{EnvironmentalData.databaseUserInformationTable_userName}, " +
                                     $"{EnvironmentalData.databaseUserInformationTable}.{EnvironmentalData.databaseUserInformationTable_userDepartment}, " +
                                     $"{EnvironmentalData.databaseUserInformationTable}.{EnvironmentalData.databaseUserInformationTable_userDirector}, " +
                                     $"{EnvironmentalData.databaseAttendanceRecordTable}.{EnvironmentalData.databaseAttendanceRecordTable_date}, " +
                                     $"{EnvironmentalData.databaseAttendanceRecordTable}.{EnvironmentalData.databaseAttendanceRecordTable_attendanceTime}, " +
                                     $"{EnvironmentalData.databaseAttendanceRecordTable}.{EnvironmentalData.databaseAttendanceRecordTable_leavingTime}, " +
                                     $"{EnvironmentalData.databaseAttendanceRecordTable}.{EnvironmentalData.databaseAttendanceRecordTable_restTime} " +
                                $"from {EnvironmentalData.databaseAttendanceRecordTable} " +
                     $"left outer join {EnvironmentalData.databaseUserInformationTable} " +
                                  $"on {EnvironmentalData.databaseAttendanceRecordTable}.id =   {EnvironmentalData.databaseUserInformationTable}.id;";
            cmd.Connection = conn;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    var attendanceData = new AllIndivisualData();
                    var attendanceDataList = new List<AllIndivisualData>();

                    while (reader.Read())
                    {
                        {
                            attendanceData.userData.id = reader[1].ToString();
                            attendanceData.userData.name = reader[2].ToString();
                            attendanceData.userData.department = reader[3].ToString();
                            attendanceData.userData.director = reader[4].ToString();
                            attendanceData.attendanceData.recordKey = reader[0].ToString();
                            attendanceData.attendanceData.date = reader[5].ToString();
                            attendanceData.attendanceData.attendanceTime = reader[6].ToString();
                            attendanceData.attendanceData.leavingTime = reader[7].ToString();
                            attendanceData.attendanceData.restTime = reader[8].ToString();
                        }
                        attendanceDataList.Add(attendanceData);
                    }
                    AllAttendance.AllIndivisualDatas = attendanceDataList;
                }
            }
            conn.Close();
        }
    }
}
