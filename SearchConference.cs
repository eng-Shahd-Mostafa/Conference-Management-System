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
    public partial class SearchConference : Form
    {
        public SearchConference()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(tbYear.Text);
                string city = tbCity.Text;
                string location = tbLocation.Text;

                ConferenceRepo conferenceRepo = new ConferenceRepo();
                Conference conference = conferenceRepo.GetConferenceByPK(year, city, location);

                // Check if a conference was found
                if (conference != null)
                {
                    // Format the conference details into a string
                    string message = $"Conference Details:\n\n" +
                                     $"Year: {conference.YEAR}\n" +
                                     $"City: {conference.CITY}\n" +
                                     $"Location: {conference.LOCATION}\n" +
                                     $"Chairman Name: {conference.NAME}\n" +
                                     $"Chairman ID: {conference.CHAIRMANID}";

                    // Show the details in a MessageBox
                    MessageBox.Show(
                        message,
                        "Conference Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No conference found with the specified details.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to search the conference. Please check the data and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
