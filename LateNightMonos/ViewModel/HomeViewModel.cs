using System;
using System.Collections.ObjectModel;
using LateNightMonos.Model;
using MvvmHelpers.Commands;
using Xamarin.Forms;

namespace LateNightMonos.ViewModel
{
    public class HomeViewModel: ViewModelBase
    {
        public HomeViewModel()
        {
            Monkeys = MonkeyService.Monkeys;
        }

        public AsyncCommand<string> GoToMonkeyCommand =>
            new AsyncCommand<string>((t) => GoTo($"detail?id={t}"));


        public ObservableCollection<Monkey> Monkeys { get; }
    }
}
