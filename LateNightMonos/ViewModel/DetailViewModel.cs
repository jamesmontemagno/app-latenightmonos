using System;
using System.Threading.Tasks;
using System.Windows.Input;
using LateNightMonos.Model;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Xamarin.Forms;
using Command = MvvmHelpers.Commands.Command;

namespace LateNightMonos.ViewModel
{
    [QueryProperty(nameof(Id), "id")]
    public class DetailViewModel : ViewModelBase
    {
        public DetailViewModel()
        {
        }

       
        public string Id
        {
            set
            {
                var id = Uri.UnescapeDataString(value ?? string.Empty);

                Monkey = MonkeyService.GetMonkey(id);
                OnPropertyChanged(nameof(Monkey));
            }
        }

        public Monkey Monkey { get; set; }

    }
}
