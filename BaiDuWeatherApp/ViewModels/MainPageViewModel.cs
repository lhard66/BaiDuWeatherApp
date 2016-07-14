using BaiDuWeatherApp.Common;
using BaiDuWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace BaiDuWeatherApp.ViewModels
{
    public class MainPageViewModel:BaseModel
    {
        HttpClient client = new HttpClient();

        public MainPageViewModel()
        {
            BDWeatherInfoModel = new ObservableCollection<Models.WeatherInfoModel>();
            NotTodayDataModel = new ObservableCollection<List<Models.Weather_dataListModel>>();
#if DEBUG
            //BDWeatherInfoModel = new WeatherInfoModel();
            //BDWeatherInfoModel.error = 16171;
            //BDWeatherInfoModel.status = "success";
            //BDWeatherInfoModel.date = DateTime.Now;
            //BDWeatherInfoModel.results = null;
#endif
            //TODO: 加载等等未生效
            
            InitializeDate();
            

        }


        private async void InitializeDate()
        {
            Loading = true;
            //await System.Threading.Tasks.Task.Delay(6000);
            string apiUrl = "http://api.map.baidu.com/telematics/v3/weather?location=%E9%83%91%E5%B7%9E&output=json&ak=wGVghNT1LBHwoBZuXOvf0XNj8vG0IWxv";
            var json = await client.GetStringAsync(new Uri(apiUrl));
            BDWeatherInfoModel.Add(JsonHelper.Deserialize<WeatherInfoModel>(json));
            NotTodayDataModel.Add(BDWeatherInfoModel[0].results[0].weather_data.GetRange(1, 3));
            Loading = false;
        }

        public ObservableCollection<WeatherInfoModel> BDWeatherInfoModel { get; set; }
        public ObservableCollection<List<Weather_dataListModel>> NotTodayDataModel { get; set; }

        private bool loading;
        public bool Loading
        {
            get { return loading; }
            set
            {
                SetProperty(ref loading, value);
            }
        }
    }
}
