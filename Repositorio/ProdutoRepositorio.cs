using System;
using System.Collections.Generic;
using Pizzaria.mvc.ViewModels;

namespace Pizzaria.mvc.Repositorio {
    /// <summary>
    /// Classe responsável pela gravação e leitura dos dados do Produto
    /// </summary>
    /// 
    public class ProdutoRepositorio {
        static List<ProdutoViewModel> lsProduto = new List<ProdutoViewModel> ();

        public ProdutoViewModel Inserir (ProdutoViewModel produto) {

            //Atribui ao Id a quantidade de itens da lista + 1
            produto.Id = lsProduto.Count + 1;
            //Atribui a Data de Criação ao objeto
            produto.DataCriacao = DateTime.Now;
            //Atribui o produto na lista
            lsProduto.Add (produto);
            //Retorna o produto
            return produto;
        }

        /// <summary>
        /// Retorna a lista de produtos
        /// </summary>
        /// <returns>Retorna um List</returns>

        public List<ProdutoViewModel> Listar () {
            return lsProduto;
        }

        /// <summary>
        /// Busca um produto pelo seu Id
        /// </summary>
        /// <param name="Id">Id do produto</param>
        /// <returns>Retorna um Produto</returns>

        public ProdutoViewModel BuscarPorId (int Id) {
            foreach (ProdutoViewModel item in lsProduto) {
                if (item.Id == Id) {
                    return item;
                }
            }
            return null;
        }
    }
}