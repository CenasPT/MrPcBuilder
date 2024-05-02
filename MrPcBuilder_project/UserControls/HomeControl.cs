using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace MrPcBuilder_project
{
    public partial class HomeControl : UserControl
    {
        DBConnect conn = new DBConnect();
        public HomeControl()
        {
            InitializeComponent();
        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {
            UpdateStatusCounter();
            timer1.Start();
            lblDateToday.Text = DateTime.Now.ToLongDateString();
        }

        // BUILDS STATUS
        public void UpdateStatusCounter()
        {
            string pending = "";
            string inprogress = "";
            string completed = "";
            conn.BuildsStatusCounter(out pending, out inprogress, out completed);
            lblBuildPendingCounter.Text = pending;
            lblBuildInProgressCounter.Text = inprogress;
            lblBuildCompletedCounter.Text = completed;
        }

        // CLOCK
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
