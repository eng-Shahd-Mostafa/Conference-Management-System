using Conference_Management_System.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_Management_System.Repos
{
    public class ConferenceRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Conference_Management_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public List<Conference> GetConferences()
        {
            List<Conference> conferences = new List<Conference>();
            try
            {
                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Conference ORDER BY YEAR";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Conference conference = new Conference
                        {
                            YEAR = reader.GetInt32(0),
                            CITY = reader.GetString(1),
                            LOCATION = reader.GetString(2),
                            NAME = reader.GetString(3),
                            CHAIRMANID = reader.GetInt32(4)
                        };
                        conferences.Add(conference);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions 
                Console.WriteLine("Error: " + ex.Message);
            }

            return conferences;
        }

        public void addConference(Conference conference)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Conference (YEAR, CITY, LOCATION, NAME, CHAIRMANID) VALUES (@YEAR, @CITY, @LOCATION, @NAME, @CHAIRMANID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@YEAR", conference.YEAR);
                    command.Parameters.AddWithValue("@CITY", conference.CITY);
                    command.Parameters.AddWithValue("@LOCATION", conference.LOCATION);
                    command.Parameters.AddWithValue("@NAME", conference.NAME);
                    command.Parameters.AddWithValue("@CHAIRMANID", conference.CHAIRMANID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions 
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public Conference GetConferenceByPK(int year, string city, string location)
        {
            Conference conference = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Conference WHERE YEAR=@YEAR AND CITY=@CITY AND LOCATION=@LOCATION";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@YEAR", year);
                    command.Parameters.AddWithValue("@CITY", city);
                    command.Parameters.AddWithValue("@LOCATION", location);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        conference = new Conference
                        {
                            YEAR = reader.GetInt32(0),
                            CITY = reader.GetString(1),
                            LOCATION = reader.GetString(2),
                            NAME = reader.GetString(3),
                            CHAIRMANID = reader.GetInt32(4)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions 
                Console.WriteLine("Error: " + ex.Message);
            }
            return conference;
        }
        public bool RemoveConference(Conference conference)
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
                            // Step 1: Delete records from AUTHORS for papers in sessions of this conference
                            string deleteAuthorsQuery = @"DELETE FROM AUTHORS
                                                        WHERE PAPERID IN (
                                                            SELECT p.PAPERID 
                                                            FROM PAPER p
                                                            JOIN SESSION s ON p.YEAR = s.YEAR AND p.CITY = s.CITY AND 
                                                                           p.LOCATION = s.LOCATION AND p.SESSIONID = s.SESSIONID
                                                            WHERE s.YEAR = @YEAR AND s.CITY = @CITY AND s.LOCATION = @LOCATION
                                                        )";

                            SqlCommand deleteAuthorsCommand = new SqlCommand(deleteAuthorsQuery, connection, transaction);
                            deleteAuthorsCommand.Parameters.AddWithValue("@YEAR", conference.YEAR);
                            deleteAuthorsCommand.Parameters.AddWithValue("@CITY", conference.CITY.Trim());
                            deleteAuthorsCommand.Parameters.AddWithValue("@LOCATION", conference.LOCATION.Trim());
                            deleteAuthorsCommand.ExecuteNonQuery();

                            // Step 2: Delete records from PAPER_REFERENCES that reference papers in this conference
                            string deletePaperRefsQuery = @"DELETE FROM PAPER_REFERENCES
                                                          WHERE PAPERID IN (
                                                              SELECT p.PAPERID 
                                                              FROM PAPER p
                                                              JOIN SESSION s ON p.YEAR = s.YEAR AND p.CITY = s.CITY AND 
                                                                              p.LOCATION = s.LOCATION AND p.SESSIONID = s.SESSIONID
                                                              WHERE s.YEAR = @YEAR AND s.CITY = @CITY AND s.LOCATION = @LOCATION
                                                          )
                                                          OR PAP_PAPERID IN (
                                                              SELECT p.PAPERID 
                                                              FROM PAPER p
                                                              JOIN SESSION s ON p.YEAR = s.YEAR AND p.CITY = s.CITY AND 
                                                                              p.LOCATION = s.LOCATION AND p.SESSIONID = s.SESSIONID
                                                              WHERE s.YEAR = @YEAR AND s.CITY = @CITY AND s.LOCATION = @LOCATION
                                                          )";

                            SqlCommand deletePaperRefsCommand = new SqlCommand(deletePaperRefsQuery, connection, transaction);
                            deletePaperRefsCommand.Parameters.AddWithValue("@YEAR", conference.YEAR);
                            deletePaperRefsCommand.Parameters.AddWithValue("@CITY", conference.CITY.Trim());
                            deletePaperRefsCommand.Parameters.AddWithValue("@LOCATION", conference.LOCATION.Trim());
                            deletePaperRefsCommand.ExecuteNonQuery();

                            // Step 3: Delete records from ATTENDS for sessions in this conference
                            string deleteAttendsQuery = @"DELETE FROM ATTENDS
                                                        WHERE YEAR = @YEAR AND CITY = @CITY AND LOCATION = @LOCATION";

                            SqlCommand deleteAttendsCommand = new SqlCommand(deleteAttendsQuery, connection, transaction);
                            deleteAttendsCommand.Parameters.AddWithValue("@YEAR", conference.YEAR);
                            deleteAttendsCommand.Parameters.AddWithValue("@CITY", conference.CITY.Trim());
                            deleteAttendsCommand.Parameters.AddWithValue("@LOCATION", conference.LOCATION.Trim());
                            deleteAttendsCommand.ExecuteNonQuery();

                            // Step 4: Delete the papers in sessions of this conference
                            string deletePapersQuery = @"DELETE FROM PAPER
                                                      WHERE PAPERID IN (
                                                          SELECT p.PAPERID 
                                                          FROM PAPER p
                                                          JOIN SESSION s ON p.YEAR = s.YEAR AND p.CITY = s.CITY AND 
                                                                         p.LOCATION = s.LOCATION AND p.SESSIONID = s.SESSIONID
                                                          WHERE s.YEAR = @YEAR AND s.CITY = @CITY AND s.LOCATION = @LOCATION
                                                      )";

                            SqlCommand deletePapersCommand = new SqlCommand(deletePapersQuery, connection, transaction);
                            deletePapersCommand.Parameters.AddWithValue("@YEAR", conference.YEAR);
                            deletePapersCommand.Parameters.AddWithValue("@CITY", conference.CITY.Trim());
                            deletePapersCommand.Parameters.AddWithValue("@LOCATION", conference.LOCATION.Trim());
                            deletePapersCommand.ExecuteNonQuery();

                            // Step 5: Delete all sessions related to this conference
                            string deleteSessionsQuery = @"DELETE FROM SESSION
                                                        WHERE YEAR = @YEAR AND CITY = @CITY AND LOCATION = @LOCATION";

                            SqlCommand deleteSessionsCommand = new SqlCommand(deleteSessionsQuery, connection, transaction);
                            deleteSessionsCommand.Parameters.AddWithValue("@YEAR", conference.YEAR);
                            deleteSessionsCommand.Parameters.AddWithValue("@CITY", conference.CITY.Trim());
                            deleteSessionsCommand.Parameters.AddWithValue("@LOCATION", conference.LOCATION.Trim());
                            deleteSessionsCommand.ExecuteNonQuery();

                            // Step 6: Delete records from MANAGES for this conference
                            string deleteManagesQuery = @"DELETE FROM MANAGES
                                                       WHERE YEAR = @YEAR AND CITY = @CITY AND LOCATION = @LOCATION";

                            SqlCommand deleteManagesCommand = new SqlCommand(deleteManagesQuery, connection, transaction);
                            deleteManagesCommand.Parameters.AddWithValue("@YEAR", conference.YEAR);
                            deleteManagesCommand.Parameters.AddWithValue("@CITY", conference.CITY.Trim());
                            deleteManagesCommand.Parameters.AddWithValue("@LOCATION", conference.LOCATION.Trim());
                            deleteManagesCommand.ExecuteNonQuery();

                            // Step 7: Finally, delete the conference itself
                            string deleteConferenceQuery = @"DELETE FROM CONFERENCE
                                                          WHERE YEAR = @YEAR AND CITY = @CITY AND LOCATION = @LOCATION";

                            SqlCommand deleteConferenceCommand = new SqlCommand(deleteConferenceQuery, connection, transaction);
                            deleteConferenceCommand.Parameters.AddWithValue("@YEAR", conference.YEAR);
                            deleteConferenceCommand.Parameters.AddWithValue("@CITY", conference.CITY.Trim());
                            deleteConferenceCommand.Parameters.AddWithValue("@LOCATION", conference.LOCATION.Trim());
                            int rowsAffected = deleteConferenceCommand.ExecuteNonQuery();

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

        public bool UpdateConference(Conference conference, int originalYear, string originalCity, string originalLocation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a transaction for data integrity
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Verify that the chairman exists
                            string verifyChairmanQuery = "SELECT COUNT(*) FROM CHAIRMAN WHERE NAME = @NAME AND CHAIRMANID = @CHAIRMANID";
                            SqlCommand verifyCommand = new SqlCommand(verifyChairmanQuery, connection, transaction);
                            verifyCommand.Parameters.AddWithValue("@NAME", conference.NAME);
                            verifyCommand.Parameters.AddWithValue("@CHAIRMANID", conference.CHAIRMANID);
                            int chairmanExists = (int)verifyCommand.ExecuteScalar();

                            if (chairmanExists == 0)
                            {
                                transaction.Rollback();
                                Console.WriteLine("Update Error: Chairman does not exist");
                                return false;
                            }

                            // If we're changing the primary key (YEAR, CITY, LOCATION)
                            if (conference.YEAR != originalYear ||
                                !conference.CITY.Trim().Equals(originalCity.Trim()) ||
                                !conference.LOCATION.Trim().Equals(originalLocation.Trim()))
                            {
                                // Check if the new primary key already exists
                                string checkExistsQuery = @"SELECT COUNT(*) FROM CONFERENCE 
                                                          WHERE YEAR = @NEW_YEAR AND CITY = @NEW_CITY AND LOCATION = @NEW_LOCATION";
                                SqlCommand checkCommand = new SqlCommand(checkExistsQuery, connection, transaction);
                                checkCommand.Parameters.AddWithValue("@NEW_YEAR", conference.YEAR);
                                checkCommand.Parameters.AddWithValue("@NEW_CITY", conference.CITY.Trim());
                                checkCommand.Parameters.AddWithValue("@NEW_LOCATION", conference.LOCATION.Trim());
                                int conferenceExists = (int)checkCommand.ExecuteScalar();

                                if (conferenceExists > 0)
                                {
                                    transaction.Rollback();
                                    Console.WriteLine("Update Error: A conference with these details already exists");
                                    return false;
                                }

                                // Check if there are dependencies (sessions, etc.)
                                string checkDependenciesQuery = @"SELECT COUNT(*) FROM SESSION 
                                                                WHERE YEAR = @ORIGINAL_YEAR AND CITY = @ORIGINAL_CITY AND LOCATION = @ORIGINAL_LOCATION";
                                SqlCommand checkDependenciesCommand = new SqlCommand(checkDependenciesQuery, connection, transaction);
                                checkDependenciesCommand.Parameters.AddWithValue("@ORIGINAL_YEAR", originalYear);
                                checkDependenciesCommand.Parameters.AddWithValue("@ORIGINAL_CITY", originalCity.Trim());
                                checkDependenciesCommand.Parameters.AddWithValue("@ORIGINAL_LOCATION", originalLocation.Trim());
                                int dependenciesExist = (int)checkDependenciesCommand.ExecuteScalar();

                                if (dependenciesExist > 0)
                                {
                                    transaction.Rollback();
                                    Console.WriteLine("Update Error: Cannot update conference with active sessions. Update sessions first.");
                                    return false;
                                }
                            }

                            // Update the conference information
                            string updateQuery = @"UPDATE CONFERENCE 
                                                 SET YEAR = @YEAR, 
                                                     CITY = @CITY, 
                                                     LOCATION = @LOCATION, 
                                                     NAME = @NAME, 
                                                     CHAIRMANID = @CHAIRMANID
                                                 WHERE YEAR = @ORIGINAL_YEAR AND 
                                                       CITY = @ORIGINAL_CITY AND 
                                                       LOCATION = @ORIGINAL_LOCATION";

                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                            updateCommand.Parameters.AddWithValue("@YEAR", conference.YEAR);
                            updateCommand.Parameters.AddWithValue("@CITY", conference.CITY.Trim());
                            updateCommand.Parameters.AddWithValue("@LOCATION", conference.LOCATION.Trim());
                            updateCommand.Parameters.AddWithValue("@NAME", conference.NAME);
                            updateCommand.Parameters.AddWithValue("@CHAIRMANID", conference.CHAIRMANID);
                            updateCommand.Parameters.AddWithValue("@ORIGINAL_YEAR", originalYear);
                            updateCommand.Parameters.AddWithValue("@ORIGINAL_CITY", originalCity.Trim());
                            updateCommand.Parameters.AddWithValue("@ORIGINAL_LOCATION", originalLocation.Trim());

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            // Check if update was successful
                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                return true;
                            }
                            else
                            {
                                transaction.Rollback();
                                Console.WriteLine("Update Error: Conference not found");
                                return false;
                            }
                        }
                        catch (Exception ex)
                        {
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
    }
}
