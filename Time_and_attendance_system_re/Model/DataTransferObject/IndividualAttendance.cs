using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_and_attendance_system_re
{
    public static class IndividualAttendance
    {
        private static List<AttendanceData> attendanceDatas;

        static IndividualAttendance()
        {
            attendanceDatas = new List<AttendanceData>();
        }

        public static List<AttendanceData> AttendanceDatas
        {
            set => attendanceDatas = value;
            get
            {
                return attendanceDatas;
            }
        }
    }
}
