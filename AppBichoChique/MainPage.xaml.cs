namespace AppBichoChique
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLoginOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.Login());
        }

        private async void btnCadastroOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.Cadastro());
        }

    }

}
