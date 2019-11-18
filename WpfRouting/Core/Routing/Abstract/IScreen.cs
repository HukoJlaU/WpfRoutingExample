using System.Windows.Controls;

namespace WpfRouting.Core.Routing.Abstract
{
    public interface IScreen
    {
        Frame NavigationFrame { get; }
    }
}