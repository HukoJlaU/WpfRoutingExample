using WpfRouting.Core.Routing.Abstract;
using WpfRouting.Lib;
using WpfRouting.ViewModels.Abstract;
using WpfRouting.Views;

namespace WpfRouting.ViewModels
{
    public class MenuViewModel : RoutableViewModelBase
    {
        private RelayCommand _goNextCommand;

        public MenuViewModel(IScreen screen) : base(screen)
        {
        }

        public RelayCommand GoNextCommand => _goNextCommand ??
                                             (_goNextCommand = new RelayCommand(
                                                 obj =>
                                                 {
                                                     HostScreen.NavigationFrame.Navigate(
                                                         new SecondView(new SecondViewModel(HostScreen)));
                                                 }));
    }
}