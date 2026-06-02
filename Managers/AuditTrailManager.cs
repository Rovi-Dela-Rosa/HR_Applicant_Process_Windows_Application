using HR_Recruitment_System.Database;
using MySql.Data.MySqlClient;
using System;

namespace HR_Applicant_Process_Windows_System
{
    public static class AuditTrailManager
    {
        public static void LogAction( int userId, string action)
        {
            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query =
                    @"INSERT INTO AuditTrail
                    (UserID, ActionTaken)
                    VALUES
                    (@UserID, @ActionTaken)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@UserID",
                            userId);

                        cmd.Parameters.AddWithValue(
                            "@ActionTaken",
                            action);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}