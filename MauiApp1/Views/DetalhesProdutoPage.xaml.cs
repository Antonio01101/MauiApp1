using Microsoft.Maui.Controls;
using MauiApp1.Models;

namespace MauiApp1.Views
{
    public partial class DetalhesProdutoPage : ContentPage
    {
        public DetalhesProdutoPage(Produto produto)
        {
            InitializeComponent();
            BindingContext = produto;
        }
    }
}
