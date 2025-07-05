using Conference_Management_System.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_Management_System.Repos
{
    public class SessionRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Conference_Management_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        public List<Session> GetSessions()
        {
            List<Session> sessions = new List<Session>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Session ORDER BY YEAR, CITY, LOCATION, SESSIONID";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Session session = new Session
                        {
                            YEAR = reader.GetInt32(0),
                            CITY = reader.GetString(1),
                            LOCATION = reader.GetString(2),
                            SESSIONID = reader.GetInt32(3),
                            NAME = reader.GetString(4),
                            CHAIRMANID = reader.GetInt32(5),
                            SESSION_LOCATION = reader.GetString(6),
                            START_TIME = reader.GetDateTime(7),
                            END_TIME = reader.GetDateTime(8)
                        };
                        sessions.Add(session);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return sessions;
        }

        public void AddSession(Session session)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Session (YEAR, CITY, LOCATION, SESSIONID, NAME, CHAIRMANID, SESSION_LOCATION, START_TIME, END_TIME) VALUES (@YEAR, @CITY, @LOCATION, @SESSIONID, @NAME, @CHAIRMANID, @SESSION_LOCATION, @START_TIME, @END_TIME)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@YEAR", session.YEAR);
                    command.Parameters.AddWithValue("@CITY", session.CITY);
                    command.Parameters.AddWithValue("@LOCATION", session.LOCATION);
                    command.Parameters.AddWithValue("@SESSIONID", session.SESSIONID);
                    command.Parameters.AddWithValue("@NAME", session.NAME);
                    command.Parameters.AddWithValue("@CHAIRMANID", session.CHAIRMANID);
                    command.Parameters.AddWithValue("@SESSION_LOCATION", session.SESSION_LOCATION);
                    command.Parameters.AddWithValue("@START_TIME", session.START_TIME);
                    command.Parameters.AddWithValue("@END_TIME", session.END_TIME);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public bool RemoveSession(Session session)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a transaction to ensure all operations succeed or fail together
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Delete records from AUTHORS table for papers in this session
                            string deleteAuthorsQuery = @"DELETE FROM AUTHORS
                                                WHERE PAPERID IN (
                                                    SELECT PAPERID 
                                                    FROM PAPER 
                                                    WHERE YEAR = @YEAR 
                                                      AND CITY = @CITY 
                                                      AND LOCATION = @LOCATION 
                                                      AND SESSIONID = @SESSIONID
                                                )";

                            SqlCommand deleteAuthorsCommand = new SqlCommand(deleteAuthorsQuery, connection, transaction);
                            deleteAuthorsCommand.Parameters.AddWithValue("@YEAR", session.YEAR);
                            deleteAuthorsCommand.Parameters.AddWithValue("@CITY", session.CITY.Trim());
                            deleteAuthorsCommand.Parameters.AddWithValue("@LOCATION", session.LOCATION.Trim());
                            deleteAuthorsCommand.Parameters.AddWithValue("@SESSIONID", session.SESSIONID);
                            deleteAuthorsCommand.ExecuteNonQuery();

                            // Step 2: Delete records from PAPER_REFERENCES table that reference papers in this session
                            string deletePaperRefsQuery = @"DELETE FROM PAPER_REFERENCES
                                                  WHERE PAPERID IN (
                                                      SELECT PAPERID 
                                                      FROM PAPER 
                                                      WHERE YEAR = @YEAR 
                                                        AND CITY = @CITY 
                                                        AND LOCATION = @LOCATION 
                                                        AND SESSIONID = @SESSIONID
                                                  )
                                                  OR PAP_PAPERID IN (
                                                      SELECT PAPERID 
                                                      FROM PAPER 
                                                      WHERE YEAR = @YEAR 
                                                        AND CITY = @CITY 
                                                        AND LOCATION = @LOCATION 
                                                        AND SESSIONID = @SESSIONID
                                                  )";

                            SqlCommand deletePaperRefsCommand = new SqlCommand(deletePaperRefsQuery, connection, transaction);
                            deletePaperRefsCommand.Parameters.AddWithValue("@YEAR", session.YEAR);
                            deletePaperRefsCommand.Parameters.AddWithValue("@CITY", session.CITY.Trim());
                            deletePaperRefsCommand.Parameters.AddWithValue("@LOCATION", session.LOCATION.Trim());
                            deletePaperRefsCommand.Parameters.AddWithValue("@SESSIONID", session.SESSIONID);
                            deletePaperRefsCommand.ExecuteNonQuery();

                            // Step 3: Delete records from ATTENDS table for this session
                            string deleteAttendsQuery = @"DELETE FROM ATTENDS
                                               WHERE YEAR = @YEAR 
                                                 AND CITY = @CITY 
                                                 AND LOCATION = @LOCATION 
                                                 AND SESSIONID = @SESSIONID";

                            SqlCommand deleteAttendsCommand = new SqlCommand(deleteAttendsQuery, connection, transaction);
                            deleteAttendsCommand.Parameters.AddWithValue("@YEAR", session.YEAR);
                            deleteAttendsCommand.Parameters.AddWithValue("@CITY", session.CITY.Trim());
                            deleteAttendsCommand.Parameters.AddWithValue("@LOCATION", session.LOCATION.Trim());
                            deleteAttendsCommand.Parameters.AddWithValue("@SESSIONID", session.SESSIONID);
                            deleteAttendsCommand.ExecuteNonQuery();

                            // Step 4: Delete the papers in this session
                            string deletePapersQuery = @"DELETE FROM PAPER
                                              WHERE YEAR = @YEAR 
                                                AND CITY = @CITY 
                                                AND LOCATION = @LOCATION 
                                                AND SESSIONID = @SESSIONID";

                            SqlCommand deletePapersCommand = new SqlCommand(deletePapersQuery, connection, transaction);
                            deletePapersCommand.Parameters.AddWithValue("@YEAR", session.YEAR);
                            deletePapersCommand.Parameters.AddWithValue("@CITY", session.CITY.Trim());
                            deletePapersCommand.Parameters.AddWithValue("@LOCATION", session.LOCATION.Trim());
                            deletePapersCommand.Parameters.AddWithValue("@SESSIONID", session.SESSIONID);
                            deletePapersCommand.ExecuteNonQuery();

                            // Step 5: Delete the session itself
                            string deleteSessionQuery = @"DELETE FROM SESSION
                                               WHERE YEAR = @YEAR 
                                                 AND CITY = @CITY 
                                                 AND LOCATION = @LOCATION 
                                                 AND SESSIONID = @SESSIONID";

                            SqlCommand deleteSessionCommand = new SqlCommand(deleteSessionQuery, connection, transaction);
                            deleteSessionCommand.Parameters.AddWithValue("@YEAR", session.YEAR);
                            deleteSessionCommand.Parameters.AddWithValue("@CITY", session.CITY.Trim());
                            deleteSessionCommand.Parameters.AddWithValue("@LOCATION", session.LOCATION.Trim());
                            deleteSessionCommand.Parameters.AddWithValue("@SESSIONID", session.SESSIONID);
                            int rowsAffected = deleteSessionCommand.ExecuteNonQuery();

                            // Commit the transaction if all commands executed successfully
                            transaction.Commit();

                            return rowsAffected > 0;
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if any command fails
                            transaction.Rollback();
                            Console.WriteLine("Transaction Error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Error: " + ex.Message);
                return false;
            }
        }


        public void UpdateSession(Session session)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE SESSION 
                             SET NAME = @NAME, 
                                 CHAIRMANID = @CHAIRMANID, 
                                 SESSION_LOCATION = @SESSION_LOCATION, 
                                 START_TIME = @START_TIME, 
                                 END_TIME = @END_TIME
                             WHERE YEAR = @YEAR AND 
                                   CITY = @CITY AND 
                                   LOCATION = @LOCATION AND 
                                   SESSIONID = @SESSIONID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NAME", session.NAME);
                    command.Parameters.AddWithValue("@CHAIRMANID", session.CHAIRMANID);
                    command.Parameters.AddWithValue("@SESSION_LOCATION", session.SESSION_LOCATION);
                    command.Parameters.AddWithValue("@START_TIME", session.START_TIME);
                    command.Parameters.AddWithValue("@END_TIME", session.END_TIME);

                    // Primary key parameters
                    command.Parameters.AddWithValue("@YEAR", session.YEAR);
                    command.Parameters.AddWithValue("@CITY", session.CITY);
                    command.Parameters.AddWithValue("@LOCATION", session.LOCATION);
                    command.Parameters.AddWithValue("@SESSIONID", session.SESSIONID);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Error: " + ex.Message);
            }
        }

        public Session GetSessionByPK(int year, string city, string location, int sessionId)
        {
            Session session = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Session WHERE YEAR = @YEAR AND CITY = @CITY AND LOCATION = @LOCATION AND SESSIONID = @SESSIONID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@YEAR", year);
                    command.Parameters.AddWithValue("@CITY", city);
                    command.Parameters.AddWithValue("@LOCATION", location);
                    command.Parameters.AddWithValue("@SESSIONID", sessionId);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        session = new Session
                        {
                            YEAR = reader.GetInt32(0),
                            CITY = reader.GetString(1),
                            LOCATION = reader.GetString(2),
                            SESSIONID = reader.GetInt32(3),
                            NAME = reader.GetString(4),
                            CHAIRMANID = reader.GetInt32(5),
                            SESSION_LOCATION = reader.GetString(6),
                            START_TIME = reader.GetDateTime(7),
                            END_TIME = reader.GetDateTime(8)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return session;
        }
    }
}
