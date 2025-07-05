using Conference_Management_System.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_Management_System.Repos
{
    public class AttendeeRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Conference_Management_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public List<Attendee> GetAttendees()
        {
            List<Attendee> attendees = new List<Attendee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                A.ATTENDEEID,
                A.NAME,
                P.EMAIL,
                A.CATEGORYID,
                C.CATEGORYNAME,
                C.FEES AS CategoryFees,
                COUNT(AU.PAPERID) AS TotalPapers,
                COUNT(AT.SESSIONID) AS TotalSessions
            FROM 
                ATTENDEE A
            JOIN 
                PARTICIPANT P ON A.NAME = P.NAME
            JOIN 
                CATEGORY C ON A.CATEGORYID = C.CATEGORYID
            LEFT JOIN 
                AUTHORS AU ON A.NAME = AU.NAME AND A.ATTENDEEID = AU.ATTENDEEID
            LEFT JOIN 
                ATTENDS AT ON A.NAME = AT.NAME AND A.ATTENDEEID = AT.ATTENDEEID
            GROUP BY 
                A.NAME, A.ATTENDEEID, P.EMAIL, A.CATEGORYID, C.CATEGORYNAME, C.FEES
            ORDER BY 
                A.ATTENDEEID, A.NAME";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Attendee attendee = new Attendee
                        {
                            ATTENDEEID = reader.GetInt32(reader.GetOrdinal("ATTENDEEID")),
                            ATTENDEENAME = reader.GetString(reader.GetOrdinal("NAME")).Trim(),
                            ATTENDEEEMAIL = reader.GetString(reader.GetOrdinal("EMAIL")).Trim(),
                            CATEGORYID = reader.GetInt32(reader.GetOrdinal("CATEGORYID")),
                            CATEGORYNAME = reader.GetString(reader.GetOrdinal("CATEGORYNAME")),
                            ATTENDEEFEES = reader.GetDecimal(reader.GetOrdinal("CategoryFees")),
                            PAPERCOUNT = reader.GetInt32(reader.GetOrdinal("TotalPapers")),
                            SESSIONCOUNT = reader.GetInt32(reader.GetOrdinal("TotalSessions"))
                        };
                        attendees.Add(attendee);
                    }
                }
            }
            return attendees;
        }


        public Attendee GetAttendeeByPK(string name, int attendeeId)
        {
            Attendee attendee = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    A.ATTENDEEID,
                    A.NAME,
                    P.EMAIL,
                    A.CATEGORYID,
                    C.CATEGORYNAME,
                    C.FEES AS CategoryFees
                FROM 
                    ATTENDEE A
                JOIN PARTICIPANT P ON A.NAME = P.NAME
                JOIN CATEGORY C ON A.CATEGORYID = C.CATEGORYID
                WHERE A.NAME = @NAME AND A.ATTENDEEID = @ATTENDEEID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", name.Trim());
                        command.Parameters.AddWithValue("@ATTENDEEID", attendeeId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                attendee = new Attendee
                                {
                                    ATTENDEEID = reader.GetInt32(reader.GetOrdinal("ATTENDEEID")),
                                    ATTENDEENAME = reader.GetString(reader.GetOrdinal("NAME")).Trim(),
                                    ATTENDEEEMAIL = reader.GetString(reader.GetOrdinal("EMAIL")).Trim(),
                                    CATEGORYID = reader.GetInt32(reader.GetOrdinal("CATEGORYID")),
                                    CATEGORYNAME = reader.GetString(reader.GetOrdinal("CATEGORYNAME")),
                                    ATTENDEEFEES = reader.GetDecimal(reader.GetOrdinal("CategoryFees"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return attendee;
        }


    }
}
