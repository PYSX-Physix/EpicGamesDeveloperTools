using Epic_Games_Developer_Tools.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Epic_Games_Developer_Tools.Views;

public sealed partial class MetaHumanCreatorPage : Page
{
    public MetaHumanCreatorViewModel ViewModel
    {
        get;
    }

    public MetaHumanCreatorPage()
    {
        ViewModel = App.GetService<MetaHumanCreatorViewModel>();
        InitializeComponent();
    }
}
