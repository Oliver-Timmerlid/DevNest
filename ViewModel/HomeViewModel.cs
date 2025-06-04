using CommunityToolkit.Mvvm.ComponentModel;

namespace DevNest.ViewModel;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    string welcomeText = "Welcome to Home!";
}
