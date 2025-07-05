using Conference_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference_Management_System
{
    public partial class SearchAttendee : Form
    {
        public SearchAttendee()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int attendeeId = int.Parse(tbAteendeeId.Text);
                string name = tbAttendeeName.Text;
                var repo = new Repos.AttendeeRepo();
                Attendee attendee = repo.GetAttendeeByPK(name, attendeeId);
                if (attendee != null)
                {
                    string message = $"Attendee Details:\n\n" +
                                     $"ID: {attendee.ATTENDEEID}\n" +
                                     $"Name: {attendee.ATTENDEENAME}\n" +
                                     $"Email: {attendee.ATTENDEEEMAIL}\n" +
                                     $"Category ID: {attendee.CATEGORYID}\n" +
                                     $"Category Name: {attendee.CATEGORYNAME}\n" +
                                     $"Category Fees: {attendee.ATTENDEEFEES}\n" +
                                     $"Total Papers Authored: {attendee.PAPERCOUNT}\n" +
                                     $"Total Sessions Attended: {attendee.SESSIONCOUNT}";
                    MessageBox.Show(
                        message,
                        "Attendee Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No attendee found with the specified details.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while searching for the attendee.\n\nDetails: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
