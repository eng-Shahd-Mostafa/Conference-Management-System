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
    public partial class CreateSession : Form
    {
        public CreateSession()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                Session session = new Session();
                session.YEAR = int.Parse(tbYear.Text);
                session.CITY = tbCity.Text;
                session.LOCATION = tbLocation.Text;
                session.SESSIONID = int.Parse(tbSessionId.Text);
                session.NAME = tbChairmanName.Text;
                session.CHAIRMANID = int.Parse(tbChairmanId.Text);
                session.SESSION_LOCATION = tbSessionLocation.Text;
                session.START_TIME = DateTime.Parse(tbStartTime.Text);
                session.END_TIME = DateTime.Parse(tbEndTime.Text);


                SessionRepo sessionRepo = new SessionRepo();
                sessionRepo.AddSession(session);
                MessageBox.Show("Session added successfully!");
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to add the session. Please check the data and try again.",
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
