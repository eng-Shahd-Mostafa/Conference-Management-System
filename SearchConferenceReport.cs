using Conference_Management_System.Models;
using Conference_Management_System.Repos;
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
    public partial class SearchConferenceReport : Form
    {
        public SearchConferenceReport()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tbYear.Text, out int year))
                {
                    MessageBox.Show("Please enter a valid numeric year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string city = tbCity.Text.Trim();
                string location = tbLocation.Text.Trim();

                if (string.IsNullOrEmpty(city) || string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("City and location must not be empty.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var repo = new ConferenceReportRepo();
                ConferenceReport conferencereport = repo.GetConferenceReportByPK(year, city, location);

                if (conferencereport != null)
                {
                    MessageBox.Show($"Conference Report:\n" +
                                    $"Year: {conferencereport.YEAR}\n" +
                                    $"City: {conferencereport.CITY}\n" +
                                    $"Location: {conferencereport.LOCATION}\n" +
                                    $"Chairman Name: {conferencereport.CHAIRMAN_NAME}\n" +
                                    $"Chairman ID: {conferencereport.CHAIRMAN_ID}\n" +
                                    $"Chairman Email: {conferencereport.CHAIRMAN_EMAIL}\n" +
                                    $"Session Count: {conferencereport.SESSION_COUNT}\n" +
                                    $"Paper Count: {conferencereport.PAPER_COUNT}\n" +
                                    $"Attendee Count: {conferencereport.ATTENDEE_COUNT}\n" +
                                    $"Author Count: {conferencereport.AUTHOR_COUNT}\n" +
                                    $"Total Fees: {conferencereport.TOTAL_FEES:C}\n" +
                                    $"Organizer Count: {conferencereport.ORGANIZER_COUNT}\n" +
                                    $"Earliest Session: {conferencereport.EARLIEST_SESSION.ToShortDateString()}\n" +
                                    $"Latest Session: {conferencereport.LATEST_SESSION.ToShortDateString()}\n" +
                                    $"Most Popular Session: {conferencereport.MOST_POPULAR_SESSION}",
                                    "Conference Report",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No conference report found for the given criteria.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for the conference report:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
