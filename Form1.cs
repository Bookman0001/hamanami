using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            weather_text.ReadOnly = true;

            List<String> weather_list = new List<string>();

            Image[] picture_image = new Image[3];

            ShowWeather show_weather = new ShowWeather();

            weather_text.Text = show_weather.Show_Weather_Text();
 
            location_name.Text = show_weather.Show_Location();
        
            foreach(String icon_info in show_weather.Show_Weather_Icon())
            {
                weather_list.Add(icon_info);
            }

            for(int i=0; i<weather_list.Count; i++)
            {
                if(0 <= weather_list[i].IndexOf("晴"))
                {
                    picture_image[i] = Properties.Resources.sunny;
                }
                else if(0 <= weather_list[i].IndexOf("曇"))
                {
                    picture_image[i] = Properties.Resources.cloud;
                }
                else if(0 <= weather_list[i].IndexOf("雨"))
                {
                    picture_image[i] = Properties.Resources.rain;
                }
                else if(0 <= weather_list[i].IndexOf("雪"))
                {
                    picture_image[i] = Properties.Resources.snow;
                }
            }
            pictureBox1.Image = picture_image[0];
            pictureBox2.Image = picture_image[1];
            pictureBox3.Image = picture_image[2];
        }



        private void setting_button_Click(object sender, EventArgs e)
        {
            
            Master master = new Master();
            master.ShowDialog();         
            
        }
    }
}
