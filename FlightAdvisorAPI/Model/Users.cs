using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAdvisorAPI.Model
{
    public class Users
    {
        public void InsertUsers()
        {
            string sql = SQLHelper.GetSqlCommand("srdjan", "tomic", "admin", "pass", "saltt", "hash", "admin");
            SQLHelper.ExecuteCommand(sql);

            string sql1 = SQLHelper.GetSqlCommand("srdjan", "topic", "user", "pass", "saltt", "hash", "regular");
            SQLHelper.ExecuteCommand(sql1);
        }


        public void InsertUsers(string first, string last, string username, string pass, string salt)
        {
            string sql = SQLHelper.GetSqlCommand(first, last, username, pass, "salt", "hash", "regular");
            SQLHelper.ExecuteCommand(sql);
        }

        public List<Tuple<string, string>> getAllUsers()
        {
            List<Tuple<string, string>> mm = new List<Tuple<string, string>>();
            string sql = SQLHelper.GetUsersLogin();
            mm = SQLHelper.ExecuteCommandReadLogin(sql);

            return mm;
        }
    }
}
