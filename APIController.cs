using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Codeplex.Data;
using System.Windows.Forms;

namespace WeatherApp
{
    class APIController
    {
        private List<String> icon_path_list = new List<String>();
        private List<String> telop_name_list = new List<String>();
        private dynamic json_data;

        public APIController()
        {
            try
            {
                MasterController master_control = new MasterController();
                var url = "http://weather.livedoor.com/forecast/webservice/json/v1?city=" + master_control.check_flag_master();
                var req = WebRequest.Create(url);

                using (var res = req.GetResponse())
                using (var s = res.GetResponseStream())
                {
                    json_data = DynamicJson.Parse(s);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                Application.Exit();
            }
        }

        public String show_Weather_Text()
        {
            return json_data.description.text;
        }

        public List<String> show_Weather_Icon()
        {
            foreach(var forecast in json_data.forecasts)
            {
                String icon_image_url = forecast.image.url;
                icon_path_list.Add(icon_image_url);
            }
            return icon_path_list;
        }

        public String show_Location()
        {
            return json_data.pinpointLocations[0].name.ToString();
        }

        public List<String> show_Telop()
        {
            foreach(var forecast in json_data.forecasts)
            {
                String weather_telop = forecast.telop;
                telop_name_list.Add(weather_telop);
            }
            return telop_name_list;
        }
    }
}
