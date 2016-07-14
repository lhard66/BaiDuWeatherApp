using System;
using Windows.UI.Xaml.Data;

//SAY:  这里的命名空间有改变
namespace BaiDuWeatherApp.Utils
{
    public class PM25Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return string.Format("PM2.5: {0}", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
