using Conference_Management_System.Models;
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
    public partial class SearchParticipant : Form
    {
        public SearchParticipant()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Participant participant = new Participant();
                participant.NAME = tbName.Text;
               
                var repo = new Repos.ParticipantRepo();
                participant = repo.GetParticipantByPK(tbName.Text);
                if (participant != null)
                {
                    string message = $"Participant Found:\n\nName: {participant.NAME}\n\nEmail: {participant.EMAIL}";
                    MessageBox.Show(message, "Participant Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                else
                {
                    MessageBox.Show("Participant not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
