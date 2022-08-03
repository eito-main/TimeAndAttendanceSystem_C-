using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_and_attendance_system_re
{
    public static class LogInAccount
    {
        private static bool logIn;
        private static string id;
        private static string director;
        private static working_type workingType;
        static LogInAccount()
        {
            logIn = false;
            id = "NOT";
            workingType = working_type.leaving;
        }

        public static bool Login
        {
            set => logIn = value;
            get
            {
                return logIn;
            }
        }

        public static string Id
        {
            set => id = value;
            get
            {
                return id;
            }
        }

        public static string Director
        {
            set => director = value;
            get
            {
                return director;
            }
        }

        public static working_type Working_Type
        {
            set => workingType = value;
            get
            {
                return workingType;
            }
        }
    }
}
