using System.Windows.Controls;
using WpfRouting.Core.Routing.Abstract;
using WpfRouting.ViewModels;

namespace WpfRouting.Views
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IScreen
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame = NavFrame;
            NavigationFrame.Navigate(new MenuView(new MenuViewModel(this)));
        }

        public Frame NavigationFrame { get; }
    }
}