using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiDuWeatherApp.Models
{
    public class WeatherInfoModel
    {
        public int error { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }
        public List<ResultsListModel> results { get; set; }
    }
}
