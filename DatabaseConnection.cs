using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace HR_Applicant_Process_Windows_System_MAIN.Database
{
    public static class DatabaseConnection
    {
        private static string connectionString =
            "Server=localhost;Database=hr_recruitment_db;Uid=root;Pwd=ivor_blunt00;"; // PALITAN NIYO NG MYSQL PASS NIYO YUNNG SA "PWD".

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
