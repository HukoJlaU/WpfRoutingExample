using System.Windows.Controls;
using WpfRouting.ViewModels.Abstract;

namespace WpfRouting.Core.Mvvm.Abstract.Controls
{
    public abstract class MvvmUserControl : UserControl
    {
        public MvvmUserControl(ViewModelBase viewModel)
        {
            DataContext = viewModel;
        }
    }
}