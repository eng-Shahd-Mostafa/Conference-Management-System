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
using System.Xml.Linq;

namespace Conference_Management_System
{
    public partial class CreateConference : Form
    {
        public CreateConference()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Conference conference = new Conference();
                conference.YEAR = int.Parse(tbYear.Text);
                conference.CITY = tbCity.Text;
                conference.LOCATION = tbLocation.Text;
                conference.NAME = tbChairmanName.Text;
                conference.CHAIRMANID = int.Parse(tbChairmanId.Text);

                ConferenceRepo conferenceRepo = new ConferenceRepo();
                conferenceRepo.addConference(conference);

                MessageBox.Show("Conference added successfully!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to add the conference. Please check the data and try again.",
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
