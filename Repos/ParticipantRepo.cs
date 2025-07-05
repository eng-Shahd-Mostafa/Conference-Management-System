using Conference_Management_System.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_Management_System.Repos
{
    public class ParticipantRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Conference_Management_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public List<Participant> GetParticipants()
        {
            List<Participant> participants = new List<Participant>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM PARTICIPANT ORDER BY NAME";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Participant participant = new Participant
                        {
                            NAME = reader.GetString(0),
                            EMAIL = reader.GetString(1)
                        };
                        participants.Add(participant);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return participants;
        }

        public Participant GetParticipantByPK(string name)
        {
            Participant participant = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM PARTICIPANT WHERE NAME = @NAME";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NAME", name.Trim());
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        participant = new Participant
                        {
                            NAME = reader.GetString(0),
                            EMAIL = reader.GetString(1)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return participant;
        }

    }

}
