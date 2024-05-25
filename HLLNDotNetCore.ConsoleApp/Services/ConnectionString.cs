using System.Data.SqlClient;

namespace HLLNDotNetCore.ConsoleApp.services {
    public static class ConnectionStrings {
        public static SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder() {
            DataSource = "GW",
            InitialCatalog = "HLLNDotNetTraining",
            UserID = "sa",
            Password = "sa@123",
            TrustServerCertificate = true
        };


    }
}
