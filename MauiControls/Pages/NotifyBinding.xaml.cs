using MauiControls.Models;

namespace MauiControls.Pages;

public partial class NotifyBinding : ContentPage
{
    Produto produto = new Produto();


    public NotifyBinding()
	{
		InitializeComponent();
        produto = new Produto
        {
            Nome = "iPhone 5",
            Preco = 5000.00m,
            Estoque = 5
        };

        BindingContext = produto;
	}

    private async void btnAtualiza_Clicked(object sender, EventArgs e)
    {
        produto.Nome = "Galaxy Samsung 10";
        produto.Preco = 6000.00m;
        produto.Estoque = 3;

        await DisplayAlert("Produto atualizado", $"{produto.Nome} - {produto.Preco}" +
            $"{produto.Estoque}", "OK");
    }
}