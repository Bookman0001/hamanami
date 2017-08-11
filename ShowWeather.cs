using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Codeplex.Data;

namespace WindowsFormsApplication2
{
    class ShowWeather
    {
        List<string> list = new List<string>();

        public dynamic Bind_Data()
        {
            Master_Control master_control = new Master_Control();
            var url = "http://weather.livedoor.com/forecast/webservice/json/v1?city=" + master_control.check_flag_master();
            var req = WebRequest.Create(url);

            using (var res = req.GetResponse())
            using (var s = res.GetResponseStream())
            {
                dynamic json = DynamicJson.Parse(s);
                return json;
            }
        }

        public string Show_Weather_Text()
        {
            return Bind_Data().description.text;
        }

        public List<String> Show_Weather_Icon()
        {
            foreach(var forecast in Bind_Data().forecasts)
            {
                var day_information = forecast;
                String icon_information = day_information.telop;
                list.Add(icon_information);
            }
            return list;
        }

        public String Show_Location()
        {
            return Bind_Data().pinpointLocations[0].name.ToString() + "の天気";
        }



    }
}
