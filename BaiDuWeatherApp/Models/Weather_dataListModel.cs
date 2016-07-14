using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiDuWeatherApp.Models
{
    public class Weather_dataListModel
    {
        public string date { get; set; }
        public Uri dayPictureUrl { get; set; }
        public Uri nightPictureUrl { get; set; }
        public string weather { get; set; }
        public string wind { get; set; }
        public string temperature { get; set; }
    }
}
