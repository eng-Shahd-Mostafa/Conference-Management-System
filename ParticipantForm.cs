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
    public partial class ParticipantForm : Form
    {
        public ParticipantForm()
        {
            InitializeComponent();
            readParticipant();
        }
        private void readParticipant()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NAME");
            dt.Columns.Add("EMAIL");
            var repo = new Repos.ParticipantRepo();
            var participants = repo.GetParticipants();
            foreach (var participant in participants)
            {
                dt.Rows.Add(participant.NAME, participant.EMAIL);
            }
            this.participantTable.DataSource = dt;
        }

        private void btnSearchParticipant_Click(object sender, EventArgs e)
        {
            SearchParticipant searchParticipant = new SearchParticipant();
            searchParticipant.ShowDialog();
        }
    }
}
