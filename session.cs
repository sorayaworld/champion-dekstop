namespace InventoryApp
{
    public static class Session
    {
        public static int Userid { get; set; }
        public static string Username { get; set; }
        public static string RoleName { get; set; }
        public static bool IsAdmin => RoleName == "Admin";

        public static void Clear()
        {
            Userid = 0;
            Username = null;
            RoleName = null;

        }
    }
}
