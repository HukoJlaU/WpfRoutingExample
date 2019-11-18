using WpfRouting.Core.Routing.Abstract;
using WpfRouting.Lib;
using WpfRouting.ViewModels.Abstract;
using WpfRouting.Views;

namespace WpfRouting.ViewModels
{
    public class SecondViewModel : RoutableViewModelBase
    {
        private RelayCommand _toFirstPageCommand;

        public SecondViewModel(IScreen screen) : base(screen)
        {
        }

        public RelayCommand ToFirstPageCommand => _toFirstPageCommand ??
                                                  (_toFirstPageCommand = new RelayCommand(
                                                      obj =>
                                                      {
                                                          HostScreen.NavigationFrame.Navigate(
                                                              new MenuView(new MenuViewModel(HostScreen)));
                                                      }));
    }
}