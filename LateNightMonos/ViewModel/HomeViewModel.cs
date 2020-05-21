using System;
using System.Collections.ObjectModel;
using LateNightMonos.Model;

namespace LateNightMonos.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Monkeys = MonkeyService.Monkeys;
        }


        public ObservableCollection<Monkey> Monkeys { get; }
    }
}
