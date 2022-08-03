using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace Time_and_attendance_system_re
{
    class LogOutput
    {
        public void Print1()
        {
            ILog log = LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            string str1 = "ログイン";
            log.Info(str1);
            Console.WriteLine("ひさしぶり");
            //log.Info(str1);
            //log.Warn(str1);
            //log.Error(str1);
            //log.Fatal(str1);
        }
    }
}
