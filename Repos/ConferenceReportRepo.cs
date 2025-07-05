using Conference_Management_System.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_Management_System.Repos
{
    public class ConferenceReportRepo
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Conference_Management_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public List<ConferenceReport> GetConferenceReports()
        {
            List<ConferenceReport> reports = new List<ConferenceReport>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
WITH SessionPopularity AS (
    SELECT 
        YEAR, CITY, LOCATION, SESSIONID,
        COUNT(*) AS AttendeeCount
    FROM ATTENDS
    GROUP BY YEAR, CITY, LOCATION, SESSIONID
)
SELECT 
    C.YEAR,
    C.CITY,
    C.LOCATION,
    CH.NAME AS CHAIRMAN_NAME,
    CH.CHAIRMANID AS CHAIRMAN_ID,
    P.EMAIL AS CHAIRMAN_EMAIL,
    COUNT(DISTINCT S.SESSIONID) AS SESSION_COUNT,
    COUNT(DISTINCT PA.PAPERID) AS PAPER_COUNT,
    COUNT(DISTINCT AT.NAME + CAST(AT.ATTENDEEID AS VARCHAR)) AS ATTENDEE_COUNT,
    COUNT(DISTINCT AU.NAME + CAST(AU.ATTENDEEID AS VARCHAR)) AS AUTHOR_COUNT,
    ISNULL(SUM(CA.FEES), 0) AS TOTAL_FEES,
    COUNT(DISTINCT M.NAME + CAST(M.ORGANIZERID AS VARCHAR)) AS ORGANIZER_COUNT,
    MIN(S.START_TIME) AS EARLIEST_SESSION,
    MAX(S.END_TIME) AS LATEST_SESSION,
    (SELECT TOP 1 CAST(SP.SESSIONID AS VARCHAR)
     FROM SessionPopularity SP
     WHERE SP.YEAR = C.YEAR AND SP.CITY = C.CITY AND SP.LOCATION = C.LOCATION
     ORDER BY SP.AttendeeCount DESC) AS MOST_POPULAR_SESSION
FROM CONFERENCE C
LEFT JOIN CHAIRMAN CH ON C.NAME = CH.NAME AND C.CHAIRMANID = CH.CHAIRMANID
LEFT JOIN PARTICIPANT P ON CH.NAME = P.NAME
LEFT JOIN SESSION S ON C.YEAR = S.YEAR AND C.CITY = S.CITY AND C.LOCATION = S.LOCATION
LEFT JOIN PAPER PA ON S.YEAR = PA.YEAR AND S.CITY = PA.CITY AND S.LOCATION = PA.LOCATION AND S.SESSIONID = PA.SESSIONID
LEFT JOIN ATTENDS AT ON S.YEAR = AT.YEAR AND S.CITY = AT.CITY AND S.LOCATION = AT.LOCATION AND S.SESSIONID = AT.SESSIONID
LEFT JOIN AUTHORS AU ON AU.PAPERID = PA.PAPERID
LEFT JOIN ATTENDEE A ON A.NAME = AT.NAME AND A.ATTENDEEID = AT.ATTENDEEID
LEFT JOIN CATEGORY CA ON CA.CATEGORYID = A.CATEGORYID
LEFT JOIN MANAGES M ON M.YEAR = C.YEAR AND M.CITY = C.CITY AND M.LOCATION = C.LOCATION
GROUP BY 
    C.YEAR, C.CITY, C.LOCATION, CH.NAME, CH.CHAIRMANID, P.EMAIL";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ConferenceReport report = new ConferenceReport
                        {
                            YEAR = reader.GetInt32(reader.GetOrdinal("YEAR")),
                            CITY = reader.GetString(reader.GetOrdinal("CITY")).Trim(),
                            LOCATION = reader.GetString(reader.GetOrdinal("LOCATION")).Trim(),
                            CHAIRMAN_NAME = reader.IsDBNull(reader.GetOrdinal("CHAIRMAN_NAME")) ? "" : reader.GetString(reader.GetOrdinal("CHAIRMAN_NAME")).Trim(),
                            CHAIRMAN_ID = reader.IsDBNull(reader.GetOrdinal("CHAIRMAN_ID")) ? 0 : reader.GetInt32(reader.GetOrdinal("CHAIRMAN_ID")),
                            CHAIRMAN_EMAIL = reader.IsDBNull(reader.GetOrdinal("CHAIRMAN_EMAIL")) ? "" : reader.GetString(reader.GetOrdinal("CHAIRMAN_EMAIL")).Trim(),
                            SESSION_COUNT = reader.GetInt32(reader.GetOrdinal("SESSION_COUNT")),
                            PAPER_COUNT = reader.GetInt32(reader.GetOrdinal("PAPER_COUNT")),
                            ATTENDEE_COUNT = reader.GetInt32(reader.GetOrdinal("ATTENDEE_COUNT")),
                            AUTHOR_COUNT = reader.GetInt32(reader.GetOrdinal("AUTHOR_COUNT")),
                            TOTAL_FEES = reader.GetDecimal(reader.GetOrdinal("TOTAL_FEES")),
                            ORGANIZER_COUNT = reader.GetInt32(reader.GetOrdinal("ORGANIZER_COUNT")),
                            // Fix the DateTime fields to properly handle NULL values
                            EARLIEST_SESSION = reader.IsDBNull(reader.GetOrdinal("EARLIEST_SESSION")) ?
                                DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("EARLIEST_SESSION")),
                            LATEST_SESSION = reader.IsDBNull(reader.GetOrdinal("LATEST_SESSION")) ?
                                DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("LATEST_SESSION")),
                            MOST_POPULAR_SESSION = reader.IsDBNull(reader.GetOrdinal("MOST_POPULAR_SESSION")) ?
                                "" : reader.GetString(reader.GetOrdinal("MOST_POPULAR_SESSION"))
                        };

                        reports.Add(report);
                    }
                }
            }

            return reports;
        }

        public ConferenceReport GetConferenceReportByPK(int year, string city, string location)
        {
            ConferenceReport report = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
WITH SessionPopularity AS (
    SELECT 
        YEAR, CITY, LOCATION, SESSIONID,
        COUNT(*) AS AttendeeCount
    FROM ATTENDS
    GROUP BY YEAR, CITY, LOCATION, SESSIONID
)
SELECT 
    C.YEAR,
    C.CITY,
    C.LOCATION,
    CH.NAME AS CHAIRMAN_NAME,
    CH.CHAIRMANID AS CHAIRMAN_ID,
    P.EMAIL AS CHAIRMAN_EMAIL,
    COUNT(DISTINCT S.SESSIONID) AS SESSION_COUNT,
    COUNT(DISTINCT PA.PAPERID) AS PAPER_COUNT,
    COUNT(DISTINCT AT.NAME + CAST(AT.ATTENDEEID AS VARCHAR)) AS ATTENDEE_COUNT,
    COUNT(DISTINCT AU.NAME + CAST(AU.ATTENDEEID AS VARCHAR)) AS AUTHOR_COUNT,
    ISNULL(SUM(CA.FEES), 0) AS TOTAL_FEES,
    COUNT(DISTINCT M.NAME + CAST(M.ORGANIZERID AS VARCHAR)) AS ORGANIZER_COUNT,
    MIN(S.START_TIME) AS EARLIEST_SESSION,
    MAX(S.END_TIME) AS LATEST_SESSION,
    (SELECT TOP 1 CAST(SP.SESSIONID AS VARCHAR)
     FROM SessionPopularity SP
     WHERE SP.YEAR = C.YEAR AND SP.CITY = C.CITY AND SP.LOCATION = C.LOCATION
     ORDER BY SP.AttendeeCount DESC) AS MOST_POPULAR_SESSION
FROM CONFERENCE C
LEFT JOIN CHAIRMAN CH ON C.NAME = CH.NAME AND C.CHAIRMANID = CH.CHAIRMANID
LEFT JOIN PARTICIPANT P ON CH.NAME = P.NAME
LEFT JOIN SESSION S ON C.YEAR = S.YEAR AND C.CITY = S.CITY AND C.LOCATION = S.LOCATION
LEFT JOIN PAPER PA ON S.YEAR = PA.YEAR AND S.CITY = PA.CITY AND S.LOCATION = PA.LOCATION AND S.SESSIONID = PA.SESSIONID
LEFT JOIN ATTENDS AT ON S.YEAR = AT.YEAR AND S.CITY = AT.CITY AND S.LOCATION = AT.LOCATION AND S.SESSIONID = AT.SESSIONID
LEFT JOIN AUTHORS AU ON AU.PAPERID = PA.PAPERID
LEFT JOIN ATTENDEE A ON A.NAME = AT.NAME AND A.ATTENDEEID = AT.ATTENDEEID
LEFT JOIN CATEGORY CA ON CA.CATEGORYID = A.CATEGORYID
LEFT JOIN MANAGES M ON M.YEAR = C.YEAR AND M.CITY = C.CITY AND M.LOCATION = C.LOCATION
WHERE C.YEAR = @YEAR AND C.CITY = @CITY AND C.LOCATION = @LOCATION
GROUP BY 
    C.YEAR, C.CITY, C.LOCATION, CH.NAME, CH.CHAIRMANID, P.EMAIL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@YEAR", year);
                    command.Parameters.AddWithValue("@CITY", city.Trim());
                    command.Parameters.AddWithValue("@LOCATION", location.Trim());

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            report = new ConferenceReport
                            {
                                YEAR = reader.GetInt32(reader.GetOrdinal("YEAR")),
                                CITY = reader.GetString(reader.GetOrdinal("CITY")).Trim(),
                                LOCATION = reader.GetString(reader.GetOrdinal("LOCATION")).Trim(),
                                CHAIRMAN_NAME = reader.IsDBNull(reader.GetOrdinal("CHAIRMAN_NAME")) ? "" : reader.GetString(reader.GetOrdinal("CHAIRMAN_NAME")).Trim(),
                                CHAIRMAN_ID = reader.IsDBNull(reader.GetOrdinal("CHAIRMAN_ID")) ? 0 : reader.GetInt32(reader.GetOrdinal("CHAIRMAN_ID")),
                                CHAIRMAN_EMAIL = reader.IsDBNull(reader.GetOrdinal("CHAIRMAN_EMAIL")) ? "" : reader.GetString(reader.GetOrdinal("CHAIRMAN_EMAIL")).Trim(),
                                SESSION_COUNT = reader.GetInt32(reader.GetOrdinal("SESSION_COUNT")),
                                PAPER_COUNT = reader.GetInt32(reader.GetOrdinal("PAPER_COUNT")),
                                ATTENDEE_COUNT = reader.GetInt32(reader.GetOrdinal("ATTENDEE_COUNT")),
                                AUTHOR_COUNT = reader.GetInt32(reader.GetOrdinal("AUTHOR_COUNT")),
                                TOTAL_FEES = reader.GetDecimal(reader.GetOrdinal("TOTAL_FEES")),
                                ORGANIZER_COUNT = reader.GetInt32(reader.GetOrdinal("ORGANIZER_COUNT")),
                                EARLIEST_SESSION = reader.IsDBNull(reader.GetOrdinal("EARLIEST_SESSION"))
                                    ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("EARLIEST_SESSION")),
                                LATEST_SESSION = reader.IsDBNull(reader.GetOrdinal("LATEST_SESSION"))
                                    ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("LATEST_SESSION")),
                                MOST_POPULAR_SESSION = reader.IsDBNull(reader.GetOrdinal("MOST_POPULAR_SESSION"))
                                    ? "" : reader.GetString(reader.GetOrdinal("MOST_POPULAR_SESSION"))
                            };
                        }
                    }
                }
            }

            return report;
        }


    }
}
