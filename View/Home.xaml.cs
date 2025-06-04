using DevNest.ViewModel;

namespace DevNest.View;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
        BindingContext = new HomeViewModel();
    }
}
