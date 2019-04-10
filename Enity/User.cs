using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fhl165033213.Enity
{
    public class User
    {
        private string m_username;

        public string Username
        {
            get { return m_username; }
            set { m_username = value; }
        }
        private string m_password;

        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }
        
    }
}
