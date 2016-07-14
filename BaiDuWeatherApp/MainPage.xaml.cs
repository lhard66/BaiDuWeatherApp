using BaiDuWeatherApp.ViewModels;
using Windows.UI.Xaml.Controls;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace BaiDuWeatherApp
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel vmMainpage { get; set; }
        public MainPage()
        {
            vmMainpage = new MainPageViewModel();
            this.InitializeComponent();
        }        

        private void ball_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CareLife), vmMainpage.BDWeatherInfoModel[0].results[0].index);
            
        }
    }
}
