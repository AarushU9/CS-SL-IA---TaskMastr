using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SQLite;
using System.IO;

namespace TaskMastrProgram
{
    public class DatabaseHelper
    {
        private static string databaseFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.db");
        private static string connectionString = $"Data Source={databaseFile};Version=3;";


        public static void InitializeDatabase()
        {
            // Check if the database file exists, if not, create it
            if (!File.Exists(databaseFile))
            {
                SQLiteConnection.CreateFile(databaseFile);
                Console.WriteLine("Database file created.");
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Create Tasks table if it doesn't exist
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Tasks (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                    Name TEXT NOT NULL, 
                    Priority TEXT, 
                    DueDate TEXT)";

                using (var cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to get the SQLite connection
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}