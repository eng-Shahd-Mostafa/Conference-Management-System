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
    public partial class SearchPaper : Form
    {
        public SearchPaper()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int paperId = int.Parse(tbPaperId.Text);
                var repo = new Repos.PaperRepo();
                Paper paper = repo.GetPaperByPK(paperId);
                if (paper != null)
                {
                    string message = $"Paper Found:\n\n" +
                            $"ID: {paper.PAPERID}\n" +
                            $"Year: {paper.YEAR}\n" +
                            $"City: {paper.CITY}\n" +
                            $"Location: {paper.LOCATION}\n" +
                            $"Session ID: {paper.SESSIONID}\n" +
                            $"Type: {paper.TYPE}";
                    MessageBox.Show(message, "Paper Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No paper found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for the paper:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
