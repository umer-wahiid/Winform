using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Shakeel_Brothers
{
    internal class Class1
    {
        public SqlConnection con;

        public Class1()
        {
            con = new SqlConnection("Data Source=DESKTOP-76GEPIK; user id=sa;password=a123456;Initial Catalog=shakeel_brothers");
        }

    }
}
