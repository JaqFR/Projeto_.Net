using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Aula_MVC.Models
{
    public class InicializarBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {
            //criar alguns dados no banco
            new List<Professor>
            {
                new Professor
                {
                    Nome= "Jose Silva",
                    Materia= "Matematica",
                    Salario= 3000,
                    Telefone= "45678908",
                    TwitterBlog= "http://google.com.br",
                    Disponivel= true,
                    Admissao= new DateTime (2012,05,01),
                    Alunos= new List<Aluno> {
                                new Aluno {
                                    NomeAluno= "Julio Silva",
                                    Email= "julio@gmail.com",
                                    Aprovado= false,
                                    Ano= 2011,
                                    Inscricao= new DateTime(2011, 8, 12),
                                },
                                new Aluno {
                                    NomeAluno= "Rafael Silva",
                                    Email= "rafael@gmail.com",
                                    Aprovado= false,
                                    Ano= 2011,
                                    Inscricao= new DateTime(2011, 7, 12),
                                }
                    },
                    Topicos= new List<Topico> {
                                    new Topico { Descricao= "topico 1" },
                                    new Topico { Descricao= "topico 2" }
                                    },
                },

                new Professor
                {
                    Nome= "Maria Silva",
                    Materia= "Portugues",
                    Salario= 3000,
                    Telefone= "45678908",
                    TwitterBlog= "http://google.com.br",
                    Disponivel= true,
                    Admissao= new DateTime (2012, 05, 01),
                    Alunos= new List<Aluno> {
                                new Aluno {
                                    NomeAluno= "Amanda Silva",
                                    Email= "amanda@gmail.com",
                                    Aprovado= false,
                                    Ano= 2011,
                                    Inscricao= new DateTime(2011, 8, 12),
                                },
                                new Aluno {
                                    NomeAluno= "Silvio Silva",
                                    Email= "silvio@gmail.com",
                                    Aprovado= false,
                                    Ano= 2011,
                                    Inscricao= new DateTime(2011, 7, 12),
                                }
                    },
                    Topicos= new List<Topico> {
                                    new Topico { Descricao= "gramatica" },
                                    new Topico { Descricao= "linguagem" }
                                    },
                },

            }.ForEach(p => context.Professores.Add(p));

            base.Seed(context);
        }
    }
}