using System.Configuration;
namespace LOGON_APP
{
    internal class Connection
    {
        public static string connectionString =>
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
