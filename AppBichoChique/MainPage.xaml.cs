namespace AppBichoChique;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        Shell.SetFlyoutBehavior(this, FlyoutBehavior.Disabled);
        Shell.SetTabBarIsVisible(this, false);
    }

    private async void btnLoginOnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }

    private async void btnCadastroOnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Cadastro());
    }

}
