using System;
using System.Collections.Generic;
using Pizzaria.mvc.Repositorio;
using Pizzaria.mvc.Util;
using Pizzaria.mvc.ViewModels;

namespace Pizzaria.mvc.ViewsControllers {
    public static class UsuarioViewControllers {
        /// <summary>
        /// Tela de cadastro de usuário
        /// </summary>
        public static void CadastrarUsuario () {
            string email, nome, senha;

            do {
                System.Console.WriteLine ("Informe seu nome");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome inválido");
                }

            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Informe seu e-mail");
                email = Console.ReadLine ();

                if (string.IsNullOrEmpty (email)) {
                    System.Console.WriteLine ("Email inválido");
                }

            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Informe a senha ");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha)) {
                    System.Console.WriteLine ("Senha inválida");
                }

            } while (!ValidacaoUtil.ValidarSenha (senha));

            #region Controller
            //Cria um objeto do Tipo UsuarioViewModel
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            //Atribui os valores as propriedades
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            //Criar um objeto do Tipo UsuarioRepositorio
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

            //Insere um novo usuario
            usuarioRepositorio.Inserir (usuarioViewModel);

            //Mostra mansagem ao usuario
            System.Console.WriteLine ("Usuario Cadastrado");

            #endregion
        }

        #region View
        public static void Listar () {
            //Crio um objeto do tipo UsuarioRepositorio
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            //Retorna a lista de usuarios cadastrados
            List<UsuarioViewModel> lsUsuarios = usuarioRepositorio.Listar ();

            //Percorre a lista de usuários retorna
            foreach (UsuarioViewModel item in lsUsuarios) {
                //Mostra na tela os dados do usuarioF
                System.Console.WriteLine ($"{item.Id} - {item.Nome} - {item.Email}");
            }
        }

        public static UsuarioViewModel Logar () {
            string email, senha;

            do {
                System.Console.WriteLine ("Informe seu e-mail");
                email = Console.ReadLine ();

                if (string.IsNullOrEmpty (email)) {
                    System.Console.WriteLine ("Email inválido");
                }

            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Informe a senha ");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha)) {
                    System.Console.WriteLine ("Senha inválida");
                }

            } while (!ValidacaoUtil.ValidarSenha (senha));

            #endregion

            #region Controller 
            //Cria o objeto do tipo UsuarioRepositorio
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            //Valida e email e senha do Usuario
            UsuarioViewModel usuario = new UsuarioRepositorio ().Login (email, senha);

            //Verifica se o email ou senha estão certos

            if (usuarioRepositorio != null) {
                return usuario;
            } else {
                //Se não exitir mostra mensagem e retorna null
                System.Console.WriteLine ("Email ou senha inválidos");
                return null;
            }

            #endregion
        }
    }
}