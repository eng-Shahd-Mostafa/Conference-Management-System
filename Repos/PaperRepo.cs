using Conference_Management_System.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_Management_System.Repos
{
    public class PaperRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Conference_Management_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public List<Paper> GetPapers()
        {
            List<Paper> papers = new List<Paper>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT PAPERID, YEAR, CITY, LOCATION, SESSIONID, TYPE 
            FROM PAPER
            ORDER BY PAPERID";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Paper paper = new Paper
                        {
                            PAPERID = reader.GetInt32(reader.GetOrdinal("PAPERID")),
                            YEAR = reader.GetInt32(reader.GetOrdinal("YEAR")),
                            CITY = reader.GetString(reader.GetOrdinal("CITY")).Trim(),
                            LOCATION = reader.GetString(reader.GetOrdinal("LOCATION")).Trim(),
                            SESSIONID = reader.GetInt32(reader.GetOrdinal("SESSIONID")),
                            TYPE = reader.GetString(reader.GetOrdinal("TYPE")).Trim()
                        };
                        papers.Add(paper);
                    }
                }
            }

            return papers;
        }

        public Paper GetPaperByPK(int paperId)
        {
            Paper paper = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PAPERID, YEAR, CITY, LOCATION, SESSIONID, TYPE FROM PAPER WHERE PAPERID = @PAPERID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PAPERID", paperId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            paper = new Paper
                            {
                                PAPERID = reader.GetInt32(reader.GetOrdinal("PAPERID")),
                                YEAR = reader.GetInt32(reader.GetOrdinal("YEAR")),
                                CITY = reader.GetString(reader.GetOrdinal("CITY")).Trim(),
                                LOCATION = reader.GetString(reader.GetOrdinal("LOCATION")).Trim(),
                                SESSIONID = reader.GetInt32(reader.GetOrdinal("SESSIONID")),
                                TYPE = reader.GetString(reader.GetOrdinal("TYPE")).Trim()
                            };
                        }
                    }
                }
            }

            return paper;
        }
    }
}
