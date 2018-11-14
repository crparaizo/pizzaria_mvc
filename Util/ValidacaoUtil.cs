namespace Pizzaria.mvc.Util {
    /// <summary>
    /// Classe responsável pela validação do sistema
    /// </summary>
    public static class ValidacaoUtil {

        /// <summary>
        /// Método responsável por validar o email
        /// </summary>
        /// <param name="email">Email a ser validado</param>
        /// <returns>Retorna true para email válido e false para email inválido</returns>
        public static bool ValidarEmail (string email) {
            //Se email recebido tiver @ e . retorn true
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Valida a senha informada
        /// </summary>
        /// <param name="senha">Senha passada</param>
        /// <returns>Retorna true caso a senha esteja ok e false caso possua erro</returns>

        public static bool ValidarSenha (string senha) {
            //Verifica se a senha pessada é maior que 6 caracteres
            if (senha.Length >= 6) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida a categoria informada
        /// </summary>
        /// <param name="categoria">Categoria deve ser pizza ou bebida</param>
        /// <returns>Retorna true caso a categoria seja pizza/bebida ou false não seja

        public static bool ValidarCategoria (string categoria) {
            if (categoria.ToLower () == "pizza" || categoria.ToLower () == "bebida") {
                return true;
            }
            return false;
        }

    }
}