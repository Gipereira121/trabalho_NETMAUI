namespace AppBichoChique;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();

    }

    private async void btnVoltarOnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Home());
        return;
    }

    private async void btnCadastroOnClicked(object sender, EventArgs e)
    {

        string nome = etrNome.Text;
        string cpf = etrCPF.Text;
        string emial = etrEmail.Text;
        string senhaC = etrSenhaC.Text;
        string telefone = etrTelefone.Text;
        string endereco = etrEndereco.Text;
        string numero = etrNumero.Text;
        string cep = etrCEP.Text;
        string bairro = etrBairro.Text;



        if (string.IsNullOrWhiteSpace(nome))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }

        else if (string.IsNullOrWhiteSpace(emial))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }

        else if (string.IsNullOrWhiteSpace(senhaC))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }


        else if (string.IsNullOrWhiteSpace(cpf))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }

        else if (string.IsNullOrWhiteSpace(telefone))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }

        if (string.IsNullOrWhiteSpace(endereco))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }


        if (string.IsNullOrWhiteSpace(numero))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }


        if (string.IsNullOrWhiteSpace(cep))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }


        if (string.IsNullOrWhiteSpace(bairro))
        {
            DisplayAlert("ERRO", "Todos os campos precisam ser preenchidos!", "Ok");
            return;
        }


        else
        {
            DisplayAlert("Cadastro Concluído", "Seu cadastro foi realizado com sucesso!", "Ok");
            await Navigation.PushAsync(new Home());
            return;

            
        }

            
    }




}