/*
using System;
using Microsoft.Data.SqlClient; 
using System.Data;
using System.Reflection.PortableExecutable;


class Program
{
    static void Main()
    {
        // 1. Define the connection string
        // Replace [ServerName] and [DatabaseName] with your actual SQL Server details.
        // Use "Trusted_Connection=True" for Windows Authentication (integrated security)
        // or "User Id=myUsername;Password=myPassword;" for SQL Server Authentication.
        string connectionString = "Data Source=SHIVANSH-PC\\SQLEXPRESS;Database=adodotnet;Integrated Security=True;" +
                                  "Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;" +
                                  "Encrypt=True;TrustServerCertificate=True;" +
                                  "Application Name=SSMS;Connect Timeout=30;";

        // 2. Create a SqlConnection object within a 'using' statement
        // The 'using' statement ensures the connection is automatically closed and disposed
        // even if errors occur.
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // 3. Open the connection
                connection.Open();
                Console.WriteLine("Connection successful!");

                // 4. Define and execute a SQL command
                string query = "SELECT Name,Department from CollegeMaster1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    // Use parameters to prevent SQL injection
                    SqlCommandBuilder sqlee = new SqlCommandBuilder(dataAdapter);








                    // Use SqlDataReader to read data from the database
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nReading data...");
                        while (reader.Read())
                        {
                            // Access data by column name or index
                            Console.WriteLine($"{reader["Name"]} {reader["Department"]}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle any errors that may occur during the connection or query
                Console.WriteLine($"Error: {ex.Message}");
            }
            // The connection is implicitly closed when the 'using' block ends (even in case of error)
            Console.WriteLine("Connection closed.");
            Hyy();
        }
    }

    private static void Hyy()
    {
    }
}
*/



//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        string connectionString ="Data Source=SHIVANSH-PC\\SQLEXPRESS;Database=adodotnet;Integrated Security=True;" +
//                                  "Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;" +
//                                  "Encrypt=True;TrustServerCertificate=True;" +
//                                  "Application Name=SSMS;Connect Timeout=30;";

//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Connection successful!");

//                string query = "SELECT Name, Department FROM CollegeMaster1";

//                using (SqlCommand command = new SqlCommand("sp_getStudentDetails", connection))
//                {

//                    command.CommandType = CommandType.StoredProcedure;

//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        Console.WriteLine("\n Reading from store procedure");
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"{reader[0]} {reader[1]}");
//                        }
//                    }
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//        }

//        Console.WriteLine("Connection closed.");
//    }
//    private static void Hyy()
//    {
//    }
//}

/*
using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        // connection string (change server & db name)
        SqlConnection con = new SqlConnection("Data Source=SHIVANSH-PC\\SQLEXPRESS;Database=adodotnet;Integrated Security=True;" +
                                        "Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;" +
                                         "Encrypt=True;TrustServerCertificate=True;" +
                                         "Application Name=SSMS;Connect Timeout=30;");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();

        // stored procedure call
        SqlCommand cmd = new SqlCommand("sp_GetStuByNameGender", con);
        cmd.CommandType = CommandType.StoredProcedure;

        // add parameters
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Gender", gender);

        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Console.WriteLine(dr["Id"] + " |" + dr["Name"] + " |" + dr["Gender"] + " |" + dr["Marks"]);
        }

        con.Close();
    }
}
*/



//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            SqlConnection con = new SqlConnection("Data Source=SHIVANSH-PC\\SQLEXPRESS;Database=adodotnet;Integrated Security=True;" +
//                                        "Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;" +
//                                         "Encrypt=True;TrustServerCertificate=True;" +
//                                         "Application Name=SSMS;Connect Timeout=30;");

//            Console.Write("Enter Gender: ");
//            string gender = Console.ReadLine();

//            SqlCommand cmd = new SqlCommand("sp_CountByGender", con);
//            cmd.CommandType = CommandType.StoredProcedure;

//            // input parameter
//            cmd.Parameters.AddWithValue("@Gender", gender);

//            // output parameter
//            SqlParameter output = new SqlParameter("@TotalCount", SqlDbType.Int);
//            output.Direction = ParameterDirection.Output;
//            cmd.Parameters.Add(output);

//            con.Open();
//            cmd.ExecuteNonQuery();

//            Console.WriteLine("Total Count: " + output.Value);

//            con.Close();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}



//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            string connectionString =
//            "Data Source=SHIVANSH-PC\\SQLEXPRESS;Initial Catalog=adodotnet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

//            int tc = 0;

//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                string query = "SELECT COUNT(*) FROM CollegeMaster1";

//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    tc = (int)command.ExecuteScalar();
//                    Console.WriteLine("Total Head Count: " + tc);
//                }
//                if (tc > 5)
//                {
//                    query = "DELETE FROM CollegeMaster1 WHERE M1 < 50";

//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        int nonq = command.ExecuteNonQuery();
//                        Console.WriteLine("Rows Deleted: " + nonq);
//                    }
//                }
//                query = "SELECT * FROM CollegeMaster1";

//                using (SqlCommand command = new SqlCommand(query, connection))
//                using (SqlDataReader reader = command.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Department"]} {reader["Gender"]} {reader["M1"]}");
//                    }
//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}



//using Microsoft.Data.SqlClient;
//using System;
//using System.Data;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            string connectionString =
//            "Data Source=SHIVANSH-PC\\SQLEXPRESS;Initial Catalog=adodotnet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();

//                int num = 6;

//                string query = "SELECT dbo.fn_square(@n)";

//                using (SqlCommand cmd = new SqlCommand(query, connection))
//                {
//                    cmd.Parameters.AddWithValue("@n", num);

//                    int result = (int)cmd.ExecuteScalar();

//                    Console.WriteLine("Square of " + num + " is: " + result);
//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}

using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=172.21.232.150;" +
            "Initial Catalog=LPU;" +
            "Integrated Security=True;" +
            "Encrypt=True;TrustServerCertificate=True;";

        DataSet ds = new DataSet();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("sp_GetStudents", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            // Fill
            da.Fill(ds, "Students");

            DataTable dt = ds.Tables["Students"];

            // CREATE
            DataRow newRow = dt.NewRow();
            newRow["Name"] = "Arun";
            newRow["Department"] = "IT";
            dt.Rows.Add(newRow);

            // UPDATE
            dt.Rows[0]["Department"] = "CSE";

            // DELETE
            if (dt.Rows.Count > 1)
                dt.Rows[1].Delete();

            // 🔑 UPDATE MUST BE HERE
            da.Update(dt);
        }

        Console.WriteLine("CRUD operations completed successfully");
    }
}
wau - styd - hdh