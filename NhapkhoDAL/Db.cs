using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public static class Db
    {
        private static string _cnn = ConfigurationManager
            .ConnectionStrings["CafeDb"].ConnectionString;

        public static void Init(string connectionString) { _cnn = connectionString; }
        public static SqlConnection GetConnection() { return new SqlConnection(_cnn); }

        public static bool Ping(out string error)
        {
            error = null;
            try { using (var cn = GetConnection()) { cn.Open(); return true; } }
            catch (System.Exception ex) { error = ex.Message; return false; }
        }
    }
}
