using System;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Xamarin.Forms;

namespace LateNightMonos.ViewModel
{
    public class ViewModelBase : BaseViewModel
    {
        public ViewModelBase()
        {
        }

        public AsyncCommand GoBackCommand =>
            new AsyncCommand(GoBack);

        Task GoBack() =>
            Shell.Current.GoToAsync("..");

        public AsyncCommand<string> GoToCommand =>
            new AsyncCommand<string>(GoTo);

        bool isNavigating = false;
        public async Task GoTo(string path)
        {
            if (isNavigating)
                return;
            isNavigating = true;
            await Shell.Current.GoToAsync(path);
            isNavigating = false;
        }
    }
}
