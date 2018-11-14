using System;

namespace Pizzaria.mvc.ViewModels {
    /// <summary>
    /// Classe base que será herdada pelas outras classes
    /// Definida como abstract para não poder ser instanciada 
    /// </summary>
    public abstract class BaseViewModel {
        /// <summary>
        /// Id do objeto
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// Nome do objeto
        /// </summary>
        /// <value></value>
        public string Nome { get; set; }

        /// <summary>
        /// Data de criação do objeto
        /// </summary>
        /// <value></value>
        public DateTime DataCriacao { get; set; }
    }
}