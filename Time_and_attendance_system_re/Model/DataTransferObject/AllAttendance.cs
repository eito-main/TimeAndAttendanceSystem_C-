using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_and_attendance_system_re
{
    public static class AllAttendance
    {
        private static List<AllIndivisualData> allIndivisualDatas;

        static AllAttendance()
        {
            allIndivisualDatas = new List<AllIndivisualData>();
        }

        public static List<AllIndivisualData> AllIndivisualDatas
        {
            set => allIndivisualDatas = value;
            get
            {
                return allIndivisualDatas;
            }
        }

        public static String[] csvFormatter()
        {
            int dataCount = allIndivisualDatas.Count;
            List<String> temporaryStorage = new List<string>();

            for (int j = 0; j < dataCount; j++)
            {
                temporaryStorage.Add
                    (
                    $"{allIndivisualDatas[j].attendanceData.date}, " +
                    $"{allIndivisualDatas[j].userData.name}, " +
                    $"{allIndivisualDatas[j].userData.department}, " +
                    $"{allIndivisualDatas[j].attendanceData.attendanceTime}, " +
                    $"{allIndivisualDatas[j].attendanceData.leavingTime}, " +
                    $"{allIndivisualDatas[j].attendanceData.restTime}"
                    );
            }

            string[] returnData = temporaryStorage.ToArray();
            return returnData;
        }
    }
}