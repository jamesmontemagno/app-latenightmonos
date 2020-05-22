using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LauncherApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var monkey = MonkeyPicker.SelectedItem as string;
            if (monkey == null)
                return;

            if(await Launcher.CanOpenAsync("latenightmonos://"))
                await Launcher.OpenAsync($"latenightmonos://monkeys/detail?id={Uri.EscapeDataString(monkey)}");
        }
    }
}
