using System;
using System.Data.SqlClient;

namespace todolist
{
    internal class DB
    {
        string connectionString = "Server=MICHAELLAPPY\\SQLEXPRESS;Database=TaskList;Trusted_Connection=True;";

        public void DBaddtask(string taskname, string taskdescription, DateTime duedate)
        {
            string sql = "INSERT INTO TaskList (TaskName, TaskDescr, TaskDueDate) VALUES (@TaskName, @TaskDescr, @TaskDueDate)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskName", taskname);
                        cmd.Parameters.AddWithValue("@TaskDescr", taskdescription);
                        cmd.Parameters.AddWithValue("@TaskDueDate", duedate);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine("Task added successfully! Rows affected: " + rowsAffected);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
