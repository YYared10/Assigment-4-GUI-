using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_4__GUI_
{
    internal class Database_Services
    {

        public SqlConnection sqlConnection { get; set; }

        public int ExecuteNonQuery(string query)
        {
            SqlConnection connection = Connection();
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            return result;
        }

        public int ExecuteScalar(string query)
        {
            SqlConnection connection = Connection();
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                result = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (connection != null)
                connection.Close();
            return result;
        }

        public SqlDataReader ExecuteReader(string query)
        {
            /*
             * The connection is not closed in this 
             * funnction because we can not do read 
             * operation on sqlDataReader after the 
             * connetion is closed.
             */
            sqlConnection = Connection();
            SqlDataReader result = null;
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public SqlConnection Connection()
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = @"Data source = .; Initial Catalog = C#WORK; Integrated Security = True;";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;
        }
    }
}

