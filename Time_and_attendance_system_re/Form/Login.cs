using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace Time_and_attendance_system_re
{
    public partial class Login : Form
    {
        AccountAccess accountAccess = new AccountAccess();
        IndividualDataAccess individualDataAccess = new IndividualDataAccess();
        LogOutput logOutput = new LogOutput();
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (accountAccess.login(nameTB.Text, passTB.Text) == true)
            {
                this.Hide();
                individualDataAccess.dataGet();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("アカウントが見つかりません");
            }
        }
    }
}
