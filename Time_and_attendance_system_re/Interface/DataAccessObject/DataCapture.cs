using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Time_and_attendance_system_re
{
    class DataCapture
    {
        AllDataAccess allDataAccess = new AllDataAccess();

        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public void attendanceDataCaputure(List<string> data)
        {

            string dataFormatte = stringChange(data);
            conn.ConnectionString = $"Data Source={EnvironmentalData.dataSource} ;Database={EnvironmentalData.database};User ID={EnvironmentalData.databaseId} ;password={EnvironmentalData.databasePassword}";
            conn.Open();

            cmd.CommandText = $"insert into {EnvironmentalData.databaseAttendanceRecordTable}({EnvironmentalData.databaseAttendanceRecordTable_id}, {EnvironmentalData.databaseAttendanceRecordTable_date}, {EnvironmentalData.databaseAttendanceRecordTable_attendanceTime}, {EnvironmentalData.databaseAttendanceRecordTable_leavingTime}, {EnvironmentalData.databaseAttendanceRecordTable_restTime}) values {dataFormatte}";
            cmd.Connection = conn;
            cmd.ExecuteReader();
            conn.Close();
            allDataAccess.dataGet();
        }

        string stringChange(List<string> data)
        {
            string returnValue = "";
            for (int j = 0; j < data.Count; j++)
            {
                string addData = $"({data[j]})";
                if (data.Count - 1 != j)
                {
                    addData = addData + ", ";
                }
                returnValue += addData;
            }
            return returnValue;

        }

    }
}
