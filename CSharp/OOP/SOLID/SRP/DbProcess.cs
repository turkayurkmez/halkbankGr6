using System.Data.SqlClient;

namespace SRP
{
    class DbProcess
    {
        public int Add(string name, decimal price)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand command = new SqlCommand("Insert into Products (ProductName, UnitPrice) values (@name,@price)", sqlConnection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);

            sqlConnection.Open();
            var affectedRows = command.ExecuteNonQuery();
            sqlConnection.Close();
            return affectedRows;
        }
    }
}
