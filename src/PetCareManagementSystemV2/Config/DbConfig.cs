using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystemV2.Config
{
    public static class DbConfig
    {
        public static string ConnectionString =>
            "Server=JAMES-HP-LAPTOP;Database=PetCareDB;Trusted_Connection=True;Encrypt=False;";
    }
}
