using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using zaliczenie.Core;
using System.Windows;
using System.Data.SqlClient;

namespace zaliczenie.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TransakcjeViewCommand { get; set; }
        public RelayCommand WydatekViewCommand { get; set; }

        public RelayCommand PrzychodViewCommand { get; set; }
        public RelayCommand WykresikiViewCommand { get; set; }


        public HomeViewModel HomeVm { get; set; }
        public TransakcjeViewModel TransakcjeVm { get; set; }

        public WydatekViewModel WydatekVm { get; set; }
        public PrzychodViewModel PrzychodVm { get; set; }

        public WykresikiViewModel WykresikiVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            {
                _currentView = value;
                OnPropertychanged();
            }

            
        }

        public MainViewModel()

        {
            //wydatki
            
            //koniec wydatki

            HomeVm = new HomeViewModel();

            TransakcjeVm = new TransakcjeViewModel();

            WydatekVm = new WydatekViewModel();
            PrzychodVm = new PrzychodViewModel();

            WykresikiVm = new WykresikiViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            TransakcjeViewCommand = new RelayCommand(o =>
            {
                CurrentView = TransakcjeVm;
            });

            WydatekViewCommand = new RelayCommand(o =>
            {
                CurrentView = WydatekVm;
            });
            PrzychodViewCommand = new RelayCommand(o =>
            {
                CurrentView = PrzychodVm;
            });
            WykresikiViewCommand = new RelayCommand(o =>
            {
                CurrentView = WykresikiVm;
            });
        }
    }
}
