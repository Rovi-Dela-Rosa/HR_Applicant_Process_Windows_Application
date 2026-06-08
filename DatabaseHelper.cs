using MySql.Data.MySqlClient;

namespace HR_RecruitmentSystem
{
    public class DatabaseHelper
    {
        private string connectionString =
            "server=localhost;database=hr_recruitment_db;uid=root;pwd=082016_HR_System;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}