

using System.Data;
using System.Data.SqlClient;

namespace Task_Ado_net.DataBASE
{
    public class AddDbContext
    {
        readonly string connectionString = "Server=DESKTOP-5AVFCBM\\SQLEXPRESS01,database=AdoNETDb,Trusted_connection=true,Integrated security=true";
        SqlConnection sqlConnection;
        public AddDbContext()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int Nonquery(string command)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
        public DataTable Query(string query)
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query,sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            sqlConnection.Close();
            return table;
        }
    }
}
