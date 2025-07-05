using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_Management_System.Models
{
    public class Session
    {
        public int YEAR;
        public string CITY = "";
        public string LOCATION = "";
        public int SESSIONID;
        public string NAME = "";
        public int CHAIRMANID;
        public string SESSION_LOCATION = "";
        public DateTime START_TIME;
        public DateTime END_TIME;
    }
}
