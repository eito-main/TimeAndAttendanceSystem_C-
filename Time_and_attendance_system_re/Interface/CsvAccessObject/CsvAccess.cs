using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Time_and_attendance_system_re
{
    class CsvAccess
    {

        DataCapture dataCaputure = new DataCapture();
        public void inputCSV(string path)
        {
            StreamReader sr = new StreamReader(path);
            var values = new List<string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                values.Add(line);
            }
            dataCaputure.attendanceDataCaputure(values);
            
            
        }

        public void outputCSV(string path, work_schedual_type workingSchedualType)
        {

            int outputRowCounat = 0;

            switch (workingSchedualType)
            {
                case work_schedual_type.individual:
                    outputRowCounat = IndividualAttendance.AttendanceDatas.Count;
                    break;

                case work_schedual_type.all:
                    outputRowCounat = AllAttendance.AllIndivisualDatas.Count;
                    break;
            }

            if (outputRowCounat == 0) { return; }

            StreamWriter file = new StreamWriter(@"C:\test\test.csv", false, Encoding.UTF8);

            string[] outputData = AllAttendance.csvFormatter();

            for (int j = 0; j<outputData.Length; j++)
            {
                file.WriteLine(outputData[j]);
            }

            file.Close();

        }
    }
}