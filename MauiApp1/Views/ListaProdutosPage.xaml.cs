using MauiApp1.Models;
using Microsoft.Maui.Controls;
using MauiApp1.Views;
using MauiApp1.ViewModels;
namespace MauiApp1.Views

{
    public partial class ListaProdutosPage : ContentPage
    {
        public ListaProdutosPage()
        {
            InitializeComponent();
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Produto produto)
            {
                await Navigation.PushAsync(new DetalhesProdutoPage(produto));
            }
        }
    }
}
