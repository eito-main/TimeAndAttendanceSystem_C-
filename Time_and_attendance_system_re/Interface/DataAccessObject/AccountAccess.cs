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
    class AccountAccess
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public bool login(string name, string pass)
        {

            conn.ConnectionString = $"Data Source={EnvironmentalData.dataSource} ;Database={EnvironmentalData.database};User ID={EnvironmentalData.databaseId} ;password={EnvironmentalData.databasePassword}";
            cmd.CommandText = $"select * from {EnvironmentalData.databaseUserInformationTable} where {EnvironmentalData.databaseUserInformationTable_userName} = \"{name}\" and {EnvironmentalData.databaseUserInformationTable_userPassword} = \"{pass}\"";

            conn.Open();
            cmd.Connection = conn;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    LogInAccount.Login = true;
                    LogInAccount.Id = reader[0].ToString();
                    LogInAccount.Director = reader[3].ToString();

                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
        }
    }
}
