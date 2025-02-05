namespace SwiftInventory.Common
{
    public enum Role
    {
        Admin,
        Manager,
        Salesman
    }

    internal static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static void SetUser(int userId, string username, string role)
        {
            UserId = userId;
            Username = username;
            Role = role;
        }
        public static void ClearUser()
        {
            UserId = 0;
            Username = null;
            Role = null;
        }
    }
}
