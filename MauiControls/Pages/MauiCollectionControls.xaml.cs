using MauiControls.Models;
using MauiControls.NewFolder;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}

    private async void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
        await DisplayAlert("Alerta Cinto Segurança", "Você selecionou / deselecionou este acessório", "Ok");
    }

    //  private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    //  {
    //if (e.CurrentItem != null && e.PreviousItem != null)
    //{
    //	Foto anterior = e.PreviousItem as Foto;
    //	Foto proximo = e.CurrentItem as Foto;
    //	await DisplayAlert("CarouselView", $"anterior = {anterior.Nome} \n\npróximo = {proximo.Nome}", "OK");
    //}
    //  }
}