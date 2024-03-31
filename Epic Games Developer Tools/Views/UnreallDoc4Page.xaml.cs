using Epic_Games_Developer_Tools.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Epic_Games_Developer_Tools.Views;

public sealed partial class UnreallDoc4Page : Page
{
    public UnreallDoc4ViewModel ViewModel
    {
        get;
    }

    public UnreallDoc4Page()
    {
        ViewModel = App.GetService<UnreallDoc4ViewModel>();
        InitializeComponent();
    }
}
