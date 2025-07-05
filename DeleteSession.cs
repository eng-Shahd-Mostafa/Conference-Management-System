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
    public partial class DeleteSession : Form
    {
        public DeleteSession()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbSessionId.Text);
                int year = int.Parse(tbConferenceYear.Text);
                string city = tbConferenceCity.Text.Trim();
                string location = tbConferenceLocation.Text.Trim();

                SessionRepo sessionRepo = new SessionRepo();
                Session session = sessionRepo.GetSessionByPK(year, city, location, id);

                if (session != null)
                {
                    bool deleted = sessionRepo.RemoveSession(session);
                    if (deleted)
                    {
                        MessageBox.Show("Session deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No session was deleted. Check if the session details are correct.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No session found with the specified details.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete the session. Please check the data and try again.",
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
