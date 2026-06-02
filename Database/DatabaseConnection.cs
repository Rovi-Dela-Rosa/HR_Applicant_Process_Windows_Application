using MySql.Data.MySqlClient;

namespace HR_Recruitment_System.Database
{
    public static class DatabaseConnection
    {
        private static string connectionString =
            "Server=localhost;Database=hr_recruitment_db;Uid=root;Pwd=;"; // PALITAN NIYO NG MYSQL PASS NIYO YUNNG SA "PWD".

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
