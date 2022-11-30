using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        string APIKey = "90e88c8ec7e346091035ea7f968622cb";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            GetWeather();
        }



        private void GetWeather()
        {
            using (WebClient OpenWeatherMap = new WebClient())
            {
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", TbCity.Text, APIKey, pic_icon);
                    var json = OpenWeatherMap.DownloadString(url);
                    WeatherInfo.Root Info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);
                    pic_icon.ImageLocation = "https://openweathermap.org/img/w/" + Info.Weather[0].icon + ".png";
                    lab_condition.Text = Info.Weather[0].Main;
                    lab_detail.Text = Info.Weather[0].Description;
                    lab_sunset.Text = convertDateTime(Info.Sys.Sunset).ToString();
                    lab_sunrise.Text = convertDateTime(Info.Sys.Sunrise).ToString();
                    lab_windspeed.Text = Info.Wind.Speed.ToString();
                    lab_pressure.Text = Info.Main.Pressure.ToString();
                    lab_temp.Text = Info.Main.Temp.ToString();
                    lab_feelslike.Text = Info.Main.Feels_Like.ToString();
                    lab_tempmin.Text = Info.Main.Temp_Min.ToString();
                    lab_tempmax.Text = Info.Main.Temp_Max.ToString();
                }
                catch (System.Net.WebException ex)
                {
                    Application.Exit();
                }
                catch (ArgumentNullException ex)
                {
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    Application.Exit();
                }
                finally
                {
                    OpenWeatherMap?.Dispose();
                }
            }
        }

        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
