using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRM
{
    internal class dbconnection
    {
        public string dbconnect() { 
        string connstring = "server=localhost;uid=root;pwd=Dinocrisis_1980;database=crm;";
            return connstring;
        }
    }
}
