using System;

namespace Pizzaria.mvc.ViewModels {
    /// <summary>
    /// Classe que representa a entidade Produtos
    /// Herda a classe BaseViewModel
    /// </summary>
    public class ProdutoViewModel : BaseViewModel {
        /// <summary>
        /// Descrição do produto
        /// </summary>
        /// <value></value>
        public string Descricao { get; set; }

        /// <summary>
        /// Preço do produto
        /// </summary>
        /// <value></value>
        public decimal Preco { get; set; }

        /// <summary>
        /// Categoria do produto
        /// </summary>
        /// <value></value>
        public string Categoria { get; set; }
    }

}