using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingCI.Models
{
    public class cResponseSukses
    {
        public string tag { get; set; }
        public string success { get; set; }
        public string error { get; set; }
        public string token { get; set; }
    }

    public class cResponseSukses_message
    {
        public string tag { get; set; }
        public string success { get; set; }
        public string error { get; set; }
        public string message { get; set; }
    }


    public class cResponseGagal
    {
        public string tag { get; set; }
        public string success { get; set; }
        public string error { get; set; }
        public string error_msg { get; set; }
    }
}