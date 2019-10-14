using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Aula_MVC.Models
{
    public class BancoContexto : DbContext
    {
        public BancoContexto() : base("ConnDB") { } //chama essa conexao com banco

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Topico> Topicos { get; set; }
    }
}