using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
    public class User_model
    {
       
        public int user_gid { get; set; }
        public string user_code { get; set; }
        public string user_name { get; set; }
        public string user_address { get; set; }
        public string city_name { get; set; }
        public string pin_code { get; set; }
        public string state_name { get; set; }
        public string user_contact_no { get; set; }
        public string user_emailid { get; set; }
        public string security_question { get; set; }
        public string security_answer { get; set; }
        public int usergroup_gid { get; set; }
        public string usergroup_code { get; set; }
        public string user_type { get; set; }
        public string user_status { get; set; }
        public string active_status_desc { get; set; }

        public string oldpassworrd { get; set; }
        public string newpassword { get; set; }

        public string dbsource { get; set; }
        public int result { get; set; }
        public string msg { get; set; }

        public string ip_address { get; set; }
        public string treearray { get; set; }

        public string recon_gid { get; set; }
    }
}
