using System;
using System.Data;
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
        public DataSet fillGrid() {             string sql = "SELECT * FROM TaskList";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
       }
        public void DBdeletetask(string name )
        {
            string sql = "DELETE FROM TaskList WHERE TaskName  = @name";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine("Task deleted successfully! Rows affected: " + rowsAffected);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public string[] getTaskName()
        {
            string sql = "SELECT TaskName FROM TaskList";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        
                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            List<string> taskNames = new List<string>();
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                taskNames.Add(row["TaskName"].ToString());
                            }
                            return taskNames.ToArray();
                        }
                        else
                        {
                            return new string[0]; 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }
        public void dbupdateTask(int taskID, string taskname, string taskdescription, DateTime duedate)
        {
            string sql = "UPDATE TaskList SET TaskName=@taskname,  TaskDescr = @TaskDescr, TaskDueDate = @TaskDueDate WHERE TaskID = @Taskid";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Taskid", taskID);
                        cmd.Parameters.AddWithValue("@TaskName", taskname);
                        cmd.Parameters.AddWithValue("@TaskDescr", taskdescription);
                        cmd.Parameters.AddWithValue("@TaskDueDate", duedate);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine("Task updated successfully! Rows affected: " + rowsAffected);
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
