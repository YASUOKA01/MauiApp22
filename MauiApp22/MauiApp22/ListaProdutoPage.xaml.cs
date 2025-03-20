namespace MauiApp22;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		List<Produto> lista = Produto.Lista;

		InitializeComponent();

        lstProduto.ItemsSource = lista;

    }

    private void ViewCell_Tapped(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ProdutoPage() { 
			BindingContext = ((ViewCell)sender).BindingContext });
	}

}