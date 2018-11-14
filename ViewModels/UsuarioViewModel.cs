namespace Pizzaria.mvc.ViewModels {
    /// <summary>
    /// Classe responsável pelas informações de Usuário
    /// </summary>
    public class UsuarioViewModel : BaseViewModel {
        /// <summary>
        /// Email do usuário
        /// </summary>
        /// <value></value>
        public string Email { get; set; }

        /// <summary>
        /// Senha do suário
        /// </summary>
        /// <value></value>
        public string Senha { get; set; }


    }
}