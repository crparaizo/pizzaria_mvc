using System;
using System.Collections.Generic;
using Pizzaria.mvc.Repositorio;
using Pizzaria.mvc.Util;
using Pizzaria.mvc.ViewModels;

namespace Pizzaria.mvc.ViewsControllers {
    /// <summary>
    /// Classe responável pelo View e Cintroller do Produto
    /// </summary>
    public class ProdutoViewControllers {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio ();

        /// <summary>
        /// Cadastra um produto
        /// </summary>
        public static void CadastrarProduto () {
            string nome, descricao, preco, categoria;

            #region View
            //Recebe o nome do produto
            do {
                System.Console.WriteLine ("Informe o nome do produto");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome do produto inválido");
                }

            } while (string.IsNullOrEmpty (nome));
            //Recebe a descrição do produto

            do {
                System.Console.WriteLine ("Informe a descrição do produto");
                descricao = Console.ReadLine ();

                if (string.IsNullOrEmpty (descricao)) {
                    System.Console.WriteLine ("Descrição inválido");
                }

            } while (string.IsNullOrEmpty (descricao));
            //Recebe a preço do produto

            do {
                System.Console.WriteLine ("Informe o preço do produto");
                preco = Console.ReadLine ();

                if (string.IsNullOrEmpty (preco)) {
                    System.Console.WriteLine ("Preço inválido");
                }

            } while (string.IsNullOrEmpty (preco));
            //Recebe a categoria

            do {
                System.Console.WriteLine ("Informe a categoria do produto");
                categoria = Console.ReadLine ();

                if (string.IsNullOrEmpty (categoria)) {
                    System.Console.WriteLine ("Categoria inválido");
                }

            } while (!ValidacaoUtil.ValidarCategoria (categoria));

            #endregion

            #region Controller
            //Cria o objeto ProdutoViewModel
            ProdutoViewModel produtoViewModel = new ProdutoViewModel ();
            //Atribui os valores ao objeto produtoViewModel
            produtoViewModel.Nome = nome;
            produtoViewModel.Descricao = descricao;
            produtoViewModel.Preco = decimal.Parse (preco);
            produtoViewModel.Categoria = categoria;

            produtoRepositorio.Inserir (produtoViewModel);

            System.Console.WriteLine ("Produto Cadastrado");
            #endregion
        }

        /// <summary>
        /// Lista um produto
        /// </summary>
        public static void ListarProdutos () {
            List<ProdutoViewModel> lsProdutos = produtoRepositorio.Listar ();

            foreach (ProdutoViewModel item in lsProdutos) {
                System.Console.WriteLine ($"{item.Id} - {item.Nome} - {item.Preco.ToString("c")}");

            }
            int idProduto = 0;

            do {
                System.Console.WriteLine ("Informe o Id do Produto para mais informações ou 0 para sair");
                //obtém o id do produto
                idProduto = int.Parse (Console.ReadLine ());

                //caso seja 0 sai do laço

                if (idProduto == 0) {
                    break;
                }
                //declara um objeto ProdutoViewModel e busca o produto pelo id
                ProdutoViewModel produtoViewModel = produtoRepositorio.BuscarPorId (idProduto);

                //Verifica se o produto existe

                if (produtoViewModel != null) {
                    //caso exista mostra todos os dados do produto
                    System.Console.WriteLine ($@"
                    {produtoViewModel.Id}
                    {produtoViewModel.Nome}
                    {produtoViewModel.Descricao}
                    {produtoViewModel.Preco.ToString("c")}
                    {produtoViewModel.Categoria}");
                } else {
                    //caso não exista informa ao usuario
                    System.Console.WriteLine ("Produto não encontrado");
                }
            } while (idProduto != 0);
        }
    }
}