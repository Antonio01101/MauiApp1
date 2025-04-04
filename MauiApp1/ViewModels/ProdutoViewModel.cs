using System.Collections.ObjectModel;
using MauiApp1.Models;
namespace MauiApp1.ViewModels;

public class ProdutoViewModel
{
    public ObservableCollection<Produto> Produtos { get; set; }

    public ProdutoViewModel()
    {
        Produtos = new ObservableCollection<Produto>
        {
            new Produto { Id = 1, Nome = "Celular", Preco = 1200 },
            new Produto { Id = 2, Nome = "Notebook", Preco = 3500 },
            new Produto { Id = 3, Nome = "Tablet", Preco = 800 },
            new Produto { Id = 4, Nome = "Fone de Ouvido", Preco = 200 },
            new Produto { Id = 5, Nome = "Smartwatch", Preco = 500 },
            new Produto { Id = 6, Nome = "Monitor", Preco = 700 }
        };
    }
}
