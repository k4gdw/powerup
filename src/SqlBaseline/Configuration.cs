using System.Data.SqlClient;
namespace SqlBaseline
{
    public class Configuration
    {
        public string ServerName { get; internal set; }
        public string DatabaseName { get; internal set; }
        public string OutputFolder { get; internal set; }
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
        public string DatabaseConnection
        {
            get
            {

                SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
                csb.DataSource = ServerName;
                csb.InitialCatalog = DatabaseName;
                if (!string.IsNullOrEmpty(UserName))
                {
                    csb.UserID = UserName;
                    csb.Password = Password;
                }
                else
                    csb.IntegratedSecurity = true;
                return csb.ConnectionString;
            }
        }

        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(ServerName) &&
                          !string.IsNullOrEmpty(DatabaseName) &&
                          !string.IsNullOrEmpty(OutputFolder);
            }
        }
    }
}