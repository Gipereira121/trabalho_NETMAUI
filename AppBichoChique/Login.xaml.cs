using System.Text.RegularExpressions;

namespace AppBichoChique;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        Shell.SetFlyoutBehavior(this, FlyoutBehavior.Disabled);
        Shell.SetTabBarIsVisible(this, false);
    }

    private async void btnLogarOnClicked(object sender, EventArgs e)
    {
        
        string senha = etrSenha.Text;


        if (string.IsNullOrWhiteSpace(senha))
        {
            DisplayAlert("ERRO", "Emial ou Senha Inválidos!", "Ok");
            return;
        }

        await Navigation.PushAsync(new Home());
    }

}