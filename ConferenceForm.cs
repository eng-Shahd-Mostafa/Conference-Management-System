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
    public partial class ConferenceForm : Form
    {
        public ConferenceForm()
        {
            InitializeComponent();
            readConferences();
        }

        private void readConferences()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("YEAR");
            dt.Columns.Add("CITY");
            dt.Columns.Add("LOCATION");
            dt.Columns.Add("CHAIRMAN NAME");
            dt.Columns.Add("CHAIRMANID");

            var repo = new Repos.ConferenceRepo();
            var conferences = repo.GetConferences();
            foreach (var conference in conferences)
            {
                dt.Rows.Add(conference.YEAR, conference.CITY, conference.LOCATION, conference.NAME, conference.CHAIRMANID);
            }
            this.conferenceTable.DataSource = dt;
        }

        private void btnAddConference_Click(object sender, EventArgs e)
        {
            CreateConference createConference = new CreateConference();
            if (createConference.ShowDialog() == DialogResult.OK)
            {
                readConferences();
            }

        }

        private void btnSearchConference_Click(object sender, EventArgs e)
        {
            SearchConference searchConference = new SearchConference();
            searchConference.ShowDialog();

        }

        private void btnUpdateConference_Click(object sender, EventArgs e)
        {
            UpdateConference updateConference = new UpdateConference();
            if (updateConference.ShowDialog() == DialogResult.OK)
            {
                readConferences();
            }
        }

        private void btnDeleteConference_Click(object sender, EventArgs e)
        {
            DeleteConference deleteConference = new DeleteConference();
            if (deleteConference.ShowDialog() == DialogResult.OK)
            {
                readConferences();
            }
        }
    }
}
