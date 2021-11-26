using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A02 今井隼斗";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double temperature = 20.3;  //気温
            double humidity = 44;   //湿度
            double discomfort_Index = (0.81 * temperature) + (0.01 * humidity) * ((0.99 * temperature) - 14.3) + 46.3;//不快指数を計算
            //(0.81*temp)+(0.01*fumi)*((0.99*temp)-14.3)+46.3
            Console.WriteLine(discomfort_Index);
        }
    }
}
