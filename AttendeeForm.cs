using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference_Management_System
{
    public partial class AttendeeForm : Form
    {
        public AttendeeForm()
        {
            InitializeComponent();
            readAttendee();
        }
        private void readAttendee()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ATTENDEE ID");
            dt.Columns.Add("ATTENDEE NAME");
            dt.Columns.Add("ATTENDEE EMAIL");
            dt.Columns.Add("CATEGORY ID");
            dt.Columns.Add("CATEGORY NAME");
            dt.Columns.Add("CATEGORY FEES");
            dt.Columns.Add("TOTAL PAPERS AUTHORED");
            dt.Columns.Add("TOTAL SESSIONS ATTENDED");
            var repo = new Repos.AttendeeRepo();
            var attendees = repo.GetAttendees();
            foreach (var attendee in attendees)
            {
                dt.Rows.Add(attendee.ATTENDEEID, attendee.ATTENDEENAME, attendee.ATTENDEEEMAIL, attendee.CATEGORYID, attendee.CATEGORYNAME, attendee.ATTENDEEFEES, attendee.PAPERCOUNT, attendee.SESSIONCOUNT);
            }
            this.AttendeeTable.DataSource = dt;
        }

        private void btnSearchAttendee_Click(object sender, EventArgs e)
        {
            SearchAttendee attendee = new SearchAttendee();
            attendee.Show();
        }
    }
}
