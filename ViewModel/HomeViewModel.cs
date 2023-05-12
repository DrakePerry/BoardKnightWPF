using BoardKnightWPF.Core;
using BoardKnightWPF.Services;

namespace BoardKnightWPF.ViewModel
{
    public class HomeViewModel : TViewModel
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


        public HomeViewModel (INavigationService navigationService)
        {
            NavigationService = navigationService;
            NavigateHomeCommand = new RelayCommand(o => { NavigationService.NavigateTo<HomeViewModel>(); }, o => true);
            NavigatePlayersCommand = new RelayCommand(o => { NavigationService.NavigateTo<ManagePlayersViewModel>(); }, o => true);
            NavigateBracketCommand = new RelayCommand(o => { NavigationService.NavigateTo<StartBracketViewModel>(); }, o => true);
        }
    }
}
