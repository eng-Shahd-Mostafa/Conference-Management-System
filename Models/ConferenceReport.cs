using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_Management_System.Models
{
    public class ConferenceReport
    {
        // Conference details
        public int YEAR;
        public string CITY = "";
        public string LOCATION = "";

        // Chairman details
        public string CHAIRMAN_NAME = "";
        public int CHAIRMAN_ID;
        public string CHAIRMAN_EMAIL = "";

        // Conference statistics
        public int SESSION_COUNT;
        public int PAPER_COUNT;
        public int ATTENDEE_COUNT;
        public int AUTHOR_COUNT;
        public decimal TOTAL_FEES;

        // Additional useful metrics
        public int ORGANIZER_COUNT;
        public DateTime EARLIEST_SESSION;
        public DateTime LATEST_SESSION;
        public string MOST_POPULAR_SESSION = "";
    }
}
