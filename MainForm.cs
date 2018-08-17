using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.road_API();
        }

        private void road_API()
        {
            //Control GUI
            WeatherText.ReadOnly = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            WeatherText.TabStop = false;
            //Connect to API and Bind data
            APIController show_weather = new APIController();
            this.Text = show_weather.show_Location() + "の天気";
            WeatherText.Text = show_weather.show_Weather_Text();
            //Prepare for Background_Image data
            MasterController mastercontroller = new MasterController();
            String file_path = "";
            file_path = mastercontroller.show_image_path_data();

            if (file_path != "")
            {
                try
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(file_path);
                    this.BackgroundImage = img;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Prepare for Weather_Icon_Image
            List<String> weather_list = new List<String>();

            foreach (String icon_image_url in show_weather.show_Weather_Icon())
            {
                weather_list.Add(icon_image_url);
            }
            pictureBox1.ImageLocation = weather_list[0].ToString();
            pictureBox2.ImageLocation = weather_list[1].ToString();
            pictureBox3.ImageLocation = weather_list[2].ToString();

            //Prepare for Weather Telop
            List<String> telop_list = new List<String>();

            foreach (String telop_info in show_weather.show_Telop())
            {
                telop_list.Add(telop_info);
            }
            TodayTelop.Text = telop_list[0].ToString();
            TomorrowTelop.Text = telop_list[1].ToString();
            DayAfterTomorrowTelop.Text = telop_list[2].ToString();
        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            MasterForm master = new MasterForm();
            this.Hide();
            master.ShowDialog();
            //Reload
            this.road_API();
            this.Show();
        }

        private void chenge_image_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "画像ファイル(*.png,*.jpg,*.bmp,*.gif)|*.png;*.jpg;*.bmp;";
            ofd.FilterIndex = 2;
            ofd.Title = "背景にしたい画像を選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(ofd.FileName);
                    this.BackgroundImage = img;
                    MasterController mastercontroller = new MasterController();
                    mastercontroller.edit_image_path_data(ofd.FileName.ToString());
                }
                catch(Exception ex)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile("./Resources/DefaultImage.jpg");
                    this.BackgroundImage = img;
                    Console.WriteLine(ex.Message.ToString());
                }        
            }
        }
    }
}
