using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Lapshin_FitnessClub.ClassHelper
{
    public class ConnectionClass
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Entities"].ConnectionString;

        static SqlConnection connection = new SqlConnection(connectionString);
    }
}
