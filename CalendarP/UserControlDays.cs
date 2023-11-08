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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
            this.Load += UserControlDays_Load; //fix thêm
        }
        public void UserControlDays_Load(object sender , EventArgs e)
        {

        }
        public void days(int numdays)
        {
            lbdays.Text = numdays + "";
        }
    }
}
