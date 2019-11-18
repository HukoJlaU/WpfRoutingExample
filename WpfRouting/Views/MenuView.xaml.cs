using WpfRouting.Core.Mvvm.Abstract.Controls;
using WpfRouting.ViewModels.Abstract;

namespace WpfRouting.Views
{
    public partial class MenuView : MvvmUserControl
    {
        public MenuView(ViewModelBase dataContext) : base(dataContext)
        {
            InitializeComponent();
        }
    }
}