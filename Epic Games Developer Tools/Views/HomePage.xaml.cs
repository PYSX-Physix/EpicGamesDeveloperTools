using Epic_Games_Developer_Tools.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Epic_Games_Developer_Tools.Views;

public sealed partial class HomePage : Page
{
    public HomeViewModel ViewModel
    {
        get;
    }

    public HomePage()
    {
        ViewModel = App.GetService<HomeViewModel>();
        InitializeComponent();
    }
}
