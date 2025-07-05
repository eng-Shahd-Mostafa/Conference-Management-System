using Conference_Management_System.Models;
using Conference_Management_System.Repos;
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
    public partial class UpdateConference : Form
    {
        public UpdateConference()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Conference conference = new Conference();
                conference.YEAR = int.Parse(tbNewYear.Text);
                conference.CITY = tbNewCity.Text.Trim();
                conference.LOCATION = tbNewLocation.Text.Trim();
                conference.NAME = tbChairmanName.Text.Trim(); 
                conference.CHAIRMANID = int.Parse(tbChairmanId.Text); 

                int originalYear = int.Parse(tbYear.Text);
                string originalCity = tbCity.Text.Trim();
                string originalLocation = tbLocation.Text.Trim();

                ConferenceRepo conferenceRepo = new ConferenceRepo();
                bool success = conferenceRepo.UpdateConference(conference, originalYear, originalCity, originalLocation);

                if (success)
                {
                    MessageBox.Show("Conference updated successfully!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update the conference. Please check the data and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the conference. Please check the data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

      
    }
}
