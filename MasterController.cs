using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;


namespace WeatherApp
{
    class MasterController
    {
        private String db_file = "M_Weather.db";

        public DataTable show_master()
        {
            DataTable table = new DataTable();
            using (var con = new SQLiteConnection("Data Source=" + db_file))
            {               
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("select location_id,location_name from weather_location order by disp_no;", con);
                adapter.Fill(table);            
            }
            return table;
        }

        public String check_flag_master()
        {
            String location_id = "";
            var table = new DataTable();
            DataRow dtRow;

            using (var con = new SQLiteConnection("Data Source=" + db_file))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("select location_id from weather_location where use_flag=1 order by disp_no", con);
                adapter.Fill(table);
                dtRow = table.Rows[0];
                location_id = dtRow["location_id"].ToString();
            }
            return location_id;
        }

        public DataTable show_search_data(String input_location_name)
        {
            DataTable table = new DataTable();
            using (var con = new SQLiteConnection("Data Source=" + db_file))
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "select location_id,location_name from weather_location where location_name like  @location_name order by disp_no";
                cmd.Parameters.Add(new SQLiteParameter("@location_name", "%" + input_location_name + "%"));
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(table);
                con.Close();
            }
            return table;
        }

        public void update_use_master(String location_id)
        {
            using (var con = new SQLiteConnection("Data Source=" + db_file))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "update weather_location set use_flag = 0";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update weather_location set use_flag = 1 where location_id = @location_id";
                    cmd.Parameters.Add(new SQLiteParameter("@location_id", location_id));
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        public String show_image_path_data()
        {
            String path_data = "";
            var table = new DataTable();
            DataRow dtRow;

            using (var con = new SQLiteConnection("Data Source=" + db_file))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("select file_path from image_file_path ", con);
                adapter.Fill(table);
                dtRow = table.Rows[0];
                path_data = dtRow["file_path"].ToString();
            }
            return path_data;
        }

        public void edit_image_path_data(String file_path)
        {
            using (var con = new SQLiteConnection("Data Source=" + db_file))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "update image_file_path set file_path = @file_path";
                    cmd.Parameters.Add(new SQLiteParameter("@file_path", file_path));
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
