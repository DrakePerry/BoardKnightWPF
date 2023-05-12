using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardKnightWPF.Core;
using BoardKnightWPF.Services;


namespace BoardKnightWPF.ViewModel
{
    class MainViewModel : TViewModel
    {
        private INavigationService _navigationService;
        public INavigationService NavigationService
        {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateHomeCommand { get; set; }
        public RelayCommand NavigatePlayersCommand { get; set; }
        public RelayCommand NavigateBracketCommand { get; set; }


        public MainViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            NavigateHomeCommand = new RelayCommand(o => { NavigationService.NavigateTo<HomeViewModel>(); }, o => true);
            NavigatePlayersCommand = new RelayCommand(o => { NavigationService.NavigateTo<ManagePlayersViewModel>(); }, o => true);
            NavigateBracketCommand = new RelayCommand(o => { NavigationService.NavigateTo<StartBracketViewModel>(); }, o => true);
        }
    }
}
