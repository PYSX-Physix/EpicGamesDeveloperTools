using Epic_Games_Developer_Tools.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Epic_Games_Developer_Tools.Views;

public sealed partial class DeveloperPortalPage : Page
{
    public DeveloperPortalViewModel ViewModel
    {
        get;
    }

    public DeveloperPortalPage()
    {
        ViewModel = App.GetService<DeveloperPortalViewModel>();
        InitializeComponent();
    }
}
