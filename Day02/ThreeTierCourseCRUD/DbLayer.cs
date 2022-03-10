using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ThreeTierCourseCRUD
{
    public class DbLayer
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;

        public DbLayer()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI"].ConnectionString);
        }

        public DataTable Select(string query, Dictionary<string,object> parameters = null)
        {
            command = new SqlCommand(query,connection);
            if (sqlParameters != null)
            {
                for (int i = 0; i < parameters.Count; i++)
                {
                    command.Parameters.AddWithValue(parameters.Keys.ElementAt(i),parameters.Values.ElementAt(i));
                }
            }
            adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int ExecuteDMLQueries(string query, Dictionary<string,object> parameters)
        {

            int affectedRows = -1;
            command = new SqlCommand(query,connection);
            for (int i = 0; i < parameters.Count; i++)
            {
                command.Parameters.AddWithValue(parameters.Keys.ElementAt(i),parameters.Values.ElementAt(i));
            }
            parameters.Clear();
            try
            {
                connection.Open();
                affectedRows= command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return affectedRows;
        }
    }
}
