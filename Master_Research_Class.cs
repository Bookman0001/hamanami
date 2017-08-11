using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Master_Control
    {
        public DataTable show_master()
        {
            var table = new DataTable();
            var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                    command.CommandText = @"SELECT Location_ID,Location_Name FROM Weather_Location";

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Environment.Exit(0);
                }
                finally
                {
                    connection.Close();
                }
            }
            return table;
        }

        public String check_flag_master()
        {
            String Location_ID = "";
            var table = new DataTable();
            DataRow dtRow;
            var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                    command.CommandText = @"SELECT TOP 1 Location_ID FROM Weather_Location WHERE Use_Flag = 1";

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    dtRow = table.Rows[0];
                    Location_ID = dtRow["Location_ID"].ToString();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Environment.Exit(0);
                }
                finally
                {
                    connection.Close();
                }
            }
            return Location_ID;
        }

        public void new_insert_master(String city_id,String city_name)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                    command.CommandText = @"INSERT INTO Weather_Location(Location_ID,Location_Name) VALUES(@Location_ID,@Location_Name)";
                    command.Parameters.Add(new SqlParameter("@Location_ID",city_id));
                    command.Parameters.Add(new SqlParameter("@Location_Name", city_name));
                    command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void delete_master(String city_id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                    command.CommandText = @"DELETE FROM Weather_Location WHERE Location_ID = @Location_ID";
                    command.Parameters.Add(new SqlParameter("@Location_ID", city_id));
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void update_use_master(String city_id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                    command.CommandText = @"UPDATE Weather_Location SET Use_Flag = 0";
                    command.ExecuteNonQuery();

                    command.CommandText = @"UPDATE Weather_Location SET Use_Flag = 1 WHERE Location_ID = @Location_ID";
                    command.Parameters.Add(new SqlParameter("@Location_ID", city_id));
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
