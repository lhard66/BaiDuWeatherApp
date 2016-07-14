using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiDuWeatherApp.Models
{
    public class ResultsListModel
    {
        public string currentCity { get; set; }
        public int pm25 { get; set; }
        public List<IndexListModel> index { get; set; }
        public List<Weather_dataListModel> weather_data { get; set; }
    }
}
