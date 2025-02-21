using System;
using System.Data;

namespace Csharp
{
    class Database
    {
        public static void Database1()
        {
            // Create a DataTable
            DataTable dataTable = new DataTable("MyTable");
            DataTable dataTable1 = new DataTable("MyTable");

            // Define Columns
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable1.Columns.Add("ID", typeof(int));
            dataTable1.Columns.Add("Name", typeof(string));

            // Add Rows
            dataTable.Rows.Add(1, "Dipesh");
            dataTable.Rows.Add(2, "Nishit");
            dataTable1.Rows.Add(3, "Nancy");
            dataTable1.Rows.Add(3, "Harshit");

            dataTable.Merge(dataTable1);

            // Iterate through Rows and Display Data
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["ID"]} {row["Name"]}");
            }
        }
    }

}
