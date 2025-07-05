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
    public partial class PaperForm : Form
    {
        public PaperForm()
        {
            InitializeComponent();
            readPapers();
        }

        private void readPapers()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PAPERID");
            dt.Columns.Add("PAPERTYPE");
            dt.Columns.Add("CONFERENCE YEAR");
            dt.Columns.Add("CONFERENCE CITY");
            dt.Columns.Add("CONFERENCE LOCATION");
            dt.Columns.Add("SESSIONID");
            var repo = new Repos.PaperRepo();
            var papers = repo.GetPapers();
            foreach (var paper in papers)
            {
                dt.Rows.Add(paper.PAPERID, paper.TYPE, paper.YEAR, paper.CITY, paper.LOCATION, paper.SESSIONID);
            }
            this.paperTable.DataSource = dt;
        }

        private void btnSearchPaper_Click(object sender, EventArgs e)
        {
            SearchPaper paper = new SearchPaper();
            paper.ShowDialog();
        }
    }
}
