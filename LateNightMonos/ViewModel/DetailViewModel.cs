using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Xamarin.Forms;
using Command = MvvmHelpers.Commands.Command;

namespace LateNightMonos.ViewModel
{
    [QueryProperty(nameof(Data), "data")]
    [QueryProperty(nameof(Phone), "phone")]
    public class DetailViewModel : BaseViewModel
    {
        public DetailViewModel()
        {
        }

        public AsyncCommand GoBackCommand =>
            new AsyncCommand(GoBack);

        Task GoBack() =>
            Shell.Current.GoToAsync($"../page3?count={Count}");

        public ICommand IncreaseCommand =>
            new Command(() => Count++);

        int count;
        public int Count
        {
            get => count;
            set => SetProperty(ref count, value);
        }

        string phone;

        public string Phone
        {
            get => phone;
            set
            {
                phone = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

        string data;
        public string Data
        {
            get => data;
            set
            {
                data = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

    }
}
