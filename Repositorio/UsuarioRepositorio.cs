using System;
using System.Collections.Generic;
using Pizzaria.mvc.ViewModels;

namespace Pizzaria.mvc.Repositorio {
    /// <summary>
    /// Classe responsável pela leitura e gravação de dados
    /// referentes ao usuário
    /// </summary>

    //list<tipo dados> nome variavel = new list < tipo dados>
    public class UsuarioRepositorio {

        //Criaçao do objeto List<UsuarioViewModel> que faz parte do namespace System.Collection.Generic
        static List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel> ();

        /// <summary>
        /// Método para inserir um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto UsuarioViewModel( nome, email, senha)</param>
        /// <returns>Retorna um UsuarioViewModel atualizado</returns>
        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {
            //Atribui um valor ao Id, verifica a quantidade de itens na lista e soma 1
            usuario.Id = lsUsuarios.Count + 1;
            //Atribui a Data e Hora atual do sitema
            usuario.DataCriacao = DateTime.Now;
            //Adiciona o usuário a Lista
            lsUsuarios.Add (usuario);
            //retorna o usuário
            return usuario;
        }

        /// <summary>
        /// Lista de todos os usuários
        /// </summary>
        /// <returns>Retorna um List<UsuariosViewModel></returns>

        public List<UsuarioViewModel> Listar () {
            return lsUsuarios;
        }

        /// <summary>
        /// Verifica se o usuário é válido
        /// </summary>
        /// <param name="email">Email do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Retorna um usuário caso seja válido e retorna null caso seja inválido</returns>

        public UsuarioViewModel Login (string email, string senha) {
            //Percorre a lista de Usuários
            foreach (UsuarioViewModel item in lsUsuarios) {
                //Verifica se o item/objeto email e senha são iguais aos como parametro
                if (item.Email == email && item.Senha == senha) {
                    //retorna o item/UsuarioViewModel
                    return item;
                }
            }
            //Caso não encontre o usuário retorna null
            return null;

        }
    }
}