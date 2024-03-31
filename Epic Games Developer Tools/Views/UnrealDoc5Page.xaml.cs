using Epic_Games_Developer_Tools.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Epic_Games_Developer_Tools.Views;

public sealed partial class UnrealDoc5Page : Page
{
    public UnrealDoc5ViewModel ViewModel
    {
        get;
    }

    public UnrealDoc5Page()
    {
        ViewModel = App.GetService<UnrealDoc5ViewModel>();
        InitializeComponent();
    }
}
