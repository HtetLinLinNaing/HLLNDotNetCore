
using System.Data.SqlClient;

namespace HLLNDotNetCore.PizzaApi;

internal static class ConnectionStrings {
    public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder() {
        DataSource = "GW",
        InitialCatalog = "HLLNDotNetCore",
        IntegratedSecurity = true,
        Encrypt = false,
        TrustServerCertificate = true
    };
}