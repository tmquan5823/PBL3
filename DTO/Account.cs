using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Account
    {
        internal string _username {  get; set; }
        internal string _password { get; set; }
        
        public Account(string username, string password)
        {
            _username = username;
            _password = password;
        }
    }
}
