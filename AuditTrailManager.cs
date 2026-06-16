using HR_Applicant_Process_Windows_System_MAIN.Database;
using MySql.Data.MySqlClient;
using System;

namespace HR_Applicant_Process_Windows_System_MAIN
{
    public static class AuditTrailManager
    {
        public static void LogAction(string userType, int userId, string action)
        {
            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query =
                    @"INSERT INTO AuditTrail
                    (UserType, UserID, ActionTaken)
                    VALUES
                    (@UserType, @UserID, @ActionTaken)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserType", userType);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@ActionTaken", action);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception ("Audit Trail Error: " + ex.Message);
            }
        }
    }
}