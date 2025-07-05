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
    public partial class ConferenceReportForm : Form
    {
        public ConferenceReportForm()
        {
            InitializeComponent();
            readConferences();
        }

        private void readConferences()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Conference Year");
                dt.Columns.Add("Conference City");
                dt.Columns.Add("Conference Location");
                dt.Columns.Add("Chairman ID");
                dt.Columns.Add("Chairman Name");
                dt.Columns.Add("Chairman Email");
                dt.Columns.Add("Session Count");
                dt.Columns.Add("Paper Count");
                dt.Columns.Add("Attendee Count");
                dt.Columns.Add("Author Count");
                dt.Columns.Add("Total Fees");
                dt.Columns.Add("Organizer Count");
                dt.Columns.Add("Earliest Session");
                dt.Columns.Add("Latest Session");
                dt.Columns.Add("Most Popular Session");

                var repo = new Repos.ConferenceReportRepo();
                var conferences = repo.GetConferenceReports();

                foreach (var conference in conferences)
                {
                    // Handle potential null DateTime values
                    var earliestSession = conference.EARLIEST_SESSION == DateTime.MinValue ?
                        DBNull.Value : (object)conference.EARLIEST_SESSION;

                    var latestSession = conference.LATEST_SESSION == DateTime.MinValue ?
                        DBNull.Value : (object)conference.LATEST_SESSION;

                    dt.Rows.Add(
                        conference.YEAR,
                        conference.CITY,
                        conference.LOCATION,
                        conference.CHAIRMAN_ID,
                        conference.CHAIRMAN_NAME,
                        conference.CHAIRMAN_EMAIL,
                        conference.SESSION_COUNT,
                        conference.PAPER_COUNT,
                        conference.ATTENDEE_COUNT,
                        conference.AUTHOR_COUNT,
                        conference.TOTAL_FEES,
                        conference.ORGANIZER_COUNT,
                        earliestSession,
                        latestSession,
                        conference.MOST_POPULAR_SESSION
                    );
                }

                this.ConferenceTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show($"Error loading conference data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchConference_Click(object sender, EventArgs e)
        {
          
            SearchConferenceReport searchConferenceReport = new SearchConferenceReport();
            searchConferenceReport.ShowDialog();
        }
    }
}
