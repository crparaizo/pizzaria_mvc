using System;
using Pizzaria.mvc.Repositorio;
using Pizzaria.mvc.Util;
using Pizzaria.mvc.ViewModels;
using Pizzaria.mvc.ViewsControllers;

namespace Pizzaria.mvc {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0, opcaoLogado = 0;

            do {
                MenuUtil.MenuDeslogado ();

                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                        {
                            UsuarioViewControllers.CadastrarUsuario ();
                            break;
                        }
                    case 2:
                        {
                            UsuarioViewModel usuarioViewModel = UsuarioViewControllers.Logar ();

                            if (usuarioViewModel != null) {
                                System.Console.WriteLine ("Seja bem vindo" + "\t" + usuarioViewModel.Nome);
                                do {
                                    //Mostra o menu do usuário logado
                                    MenuUtil.MenuLogado ();

                                    //Aguarda opção de 

                                    opcaoLogado = int.Parse (Console.ReadLine ());

                                    //Escolhe a opção do usuário

                                    switch (opcaoLogado) {
                                        case 0:
                                            {
                                                System.Console.WriteLine ("Tchau");
                                                break;
                                            }
                                        case 1:
                                            {
                                                ProdutoViewControllers.CadastrarProduto ();
                                                break;
                                            }
                                        case 2:
                                            {
                                                ProdutoViewControllers.ListarProdutos ();
                                                break;
                                            }

                                        default:
                                            {
                                                System.Console.WriteLine ("Opção inválida");
                                                break;
                                            }
                                    }
                                    //Fica no laço enquanto opção diferente de 0
                                } while (opcaoLogado != 0);

                            }
                            break;

                        }

                    case 3:
                        {
                            UsuarioViewControllers.Listar ();
                            break;
                        }
                    case 0:
                        {
                            System.Console.WriteLine ("Tchau");
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine ("Opção inválida");
                            break;
                        }
                }
            } while (opcaoDeslogado != 0);
            UsuarioViewControllers.CadastrarUsuario ();
            UsuarioViewControllers.Listar ();

        }
    }
}