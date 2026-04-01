using.system.data.sqlclient;

namespace inventoryapp
{
    public static class DBHelper
    {
        private static string connStr =
             "server=(localdb)\\MSSQLLocalDB:Database=InventoryDB;integrated security=True;";
        public static SqlConnection GetConnection()

        {
            return new SqlConnection(connstr)
    }
    }
}