using WpfRouting.Core.Routing.Abstract;

namespace WpfRouting.ViewModels.Abstract
{
    public abstract class RoutableViewModelBase : ViewModelBase
    {
        protected RoutableViewModelBase(IScreen screen)
        {
            HostScreen = screen;
        }

        public IScreen HostScreen { get; }
    }
}