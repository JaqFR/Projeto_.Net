﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Aula_MVC.Models
{
    public class Professor
    {
        [Key] //Column(Order = 0)
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "Informe o nome do professor.")] //Column(Order = 1)
        [MinLength(8, ErrorMessage = "Tamanho minino de 8 caracteres")]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}",
            ApplyFormatInEditMode = true,
            NullDisplayText = "sem remuneraçao")]
        [Range(1200, 25000, ErrorMessage = "Salario deve ser entre 1200 e 25000")]
        public decimal? Salario { get; set; }

        [Display(Name = "Twitter/Blog")]
        //[Column("ContatoDigital", Order = 5)]
        public string TwitterBlog { get; set; }

        public string Materia { get; set; }

        public bool Disponivel { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Admissao { get; set; }

        //chave estrangeira
        public List<Aluno> Alunos { get; set; }

        public List<Topico> Topicos { get; set; }        
    }
}