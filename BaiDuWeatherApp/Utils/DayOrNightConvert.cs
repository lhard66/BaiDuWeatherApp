using BaiDuWeatherApp.Models;
using System;
using Windows.UI.Xaml.Data;

namespace BaiDuWeatherApp.Utils
{
    public class DayOrNightConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var weatherList = value as Weather_dataListModel;
            if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 17)
            {
                return weatherList.dayPictureUrl;
            }
            return weatherList.nightPictureUrl;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
