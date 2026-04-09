using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public static class AppBootstrap
    {
        public static void Init(string connectionString)
        {
            Db.Init(connectionString);
        }

        public static bool Ping(out string error)
        {
            return Db.Ping(out error);
        }
    }
}
