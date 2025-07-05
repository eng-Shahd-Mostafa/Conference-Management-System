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
    public partial class DeleteConference : Form
    {
        public DeleteConference()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(tbYear.Text);
                string city = tbCity.Text;
                string location = tbLocation.Text;

                ConferenceRepo conferenceRepo = new ConferenceRepo();
                Conference conference = conferenceRepo.GetConferenceByPK(year, city, location);
                if(conference != null)
                {
                    // Delete the conference
                    conferenceRepo.RemoveConference(conference);
                    MessageBox.Show(
                        "Conference deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

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
                    $"An error occurred: {ex.Message}",
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
