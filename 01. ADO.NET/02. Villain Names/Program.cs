using Microsoft.Data.SqlClient;

SqlConnection connection = new SqlConnection("Server=DESKTOP-MK61FRQ\\SQLEXPRESS;Database=MinionsDB;Integrated Security=True");
connection.Open();

using (connection)
{
    string query = File.ReadAllText(@"../../GetVillainsCounts.sql");

    SqlCommand command = new SqlCommand(query, connection);
    SqlDataReader reader = command.ExecuteReader();

    using (reader)
    {
        while (reader.Read())
        {
            string villainName = (string)reader["Name"];
            int totalMinions = (int)reader["TotalMinions"];

            Console.WriteLine($"{villainName} {totalMinions}");
        }
    }
}