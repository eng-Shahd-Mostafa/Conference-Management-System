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
    public partial class SearchSession : Form
    {
        public SearchSession()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbSessionId.Text);
                int year = int.Parse(tbConferenceYear.Text);
                string city = tbConferenceCity.Text;
                string location = tbConferenceLocation.Text;

                SessionRepo sessionRepo = new SessionRepo();
                Session session = sessionRepo.GetSessionByPK(year, city, location, id);
                if (session != null)
                {
                    // Format the session details into a string
                    string message = "Session Details:\n\n" +
                                     $"Session ID: {session.SESSIONID}\n" +
                                     $"Session Location: {session.SESSION_LOCATION}\n" +
                                     $"Conference Year: {session.YEAR}\n" +
                                     $"Conference City: {session.CITY}\n" +
                                     $"Conference Location: {session.LOCATION}\n" +                                    
                                     $"Chairman Name: {session.NAME}\n" +
                                     $"Chairman ID: {session.CHAIRMANID}\n" +                                    
                                     $"Start Time: {session.START_TIME}\n" +
                                     $"End Time: {session.END_TIME}";
                    // Show the details in a MessageBox
                    MessageBox.Show(
                        message,
                        "Session Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No session found with the specified details.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                      "Failed to search the session. Please check the data and try again.",
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
