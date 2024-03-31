using Epic_Games_Developer_Tools.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Epic_Games_Developer_Tools.Views;

public sealed partial class UnrealDocumentationPage : Page
{
    public UnrealDocumentationViewModel ViewModel
    {
        get;
    }

    public UnrealDocumentationPage()
    {
        ViewModel = App.GetService<UnrealDocumentationViewModel>();
        InitializeComponent();
    }
}
