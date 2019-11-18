using WpfRouting.Core.Mvvm.Abstract.Controls;
using WpfRouting.ViewModels.Abstract;

namespace WpfRouting.Views
{
    public partial class SecondView : MvvmUserControl
    {
        public SecondView(ViewModelBase viewModel) : base(viewModel)
        {
            InitializeComponent();
        }
    }
}