using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdoNet
{
    internal class ProductDal
    {
        SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true;");

        // DataTable
        internal List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("Select * From Products", sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            //DataTable dataTable = new DataTable();
            //dataTable.Load(dataReader);

            List<Product> products = new List<Product>();
            while (dataReader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Name = dataReader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(dataReader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(dataReader["StockAmount"])
                };
                products.Add(product);
            }

            dataReader.Close();
            sqlConnection.Close();
            return products;
        }

        internal void Add(Product product)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("Insert into Products Values (@name, @unitPrice, @stockAmount)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@StockAmount", product.StockAmount);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        internal void Update(Product product)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("Update Products Set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount Where Id=@id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        internal void Delete(int id)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("Delete From Products Where Id=@id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void ConnectionControl()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }
    }
}
