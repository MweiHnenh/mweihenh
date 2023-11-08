using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            //DateTime now = DateTime.Now;

            //DateTime startofthemonth = new DateTime(now.Year, now.Month,1);

            //int days = DateTime.DaysInMonth(now.Year, now.Month);

            //int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            ////usercontrolblank
            //for(int i = 0; i < dayoftheweek; i++)
            //{
            //    UserControlBlank ucblank = new UserControlBlank();
            //    daycontainer.Controls.Add(ucblank); 
            //}

            //for (int i = 0; i <= days; i++)
            //{
            //    UserControlDays ucdays = new UserControlDays();
            //    ucdays.days(i);
            //    daycontainer.Controls.Add(ucdays);
            //}
            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            // UserControlBlank
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // UserControlDays
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                ucdays.Location = new Point((i + dayoftheweek - 2) % 7 * ucdays.Width, (i + dayoftheweek - 2) / 7 * ucdays.Height);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
