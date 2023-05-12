using BoardKnightWPF.Core;
using BoardKnightWPF.ViewModel;
using System;

namespace BoardKnightWPF.Services
{
    public interface INavigationService
    {
        TViewModel CurrentView { get; }
        void NavigateTo<T>() where T : TViewModel;
    }


    public class NavigationService : ObservableObject, INavigationService
    {
        private TViewModel _currentView;
        private readonly Func<Type, TViewModel> _viewModelFactory;

        public TViewModel CurrentView 
        {
            get => _currentView;
            private set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public NavigationService(Func<Type, TViewModel> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigateTo<TVM>() where TVM : TViewModel
        {
            TViewModel viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentView = viewModel;    

        }
    }
}
