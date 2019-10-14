using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Aula_MVC.Models
{
    public class Aluno
    {
        [Key]
        public int IDAluno { get; set; }

        [DisplayName("Professor")]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage ="Nome é obrigatorio")]
        [MaxLength(50), MinLength(5)]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage = "Email é obrigatorio")]
        [StringLength(250)]
        public string Email { get; set; }

        [Range(1980, 2020, ErrorMessage ="Ano deve ser entre 1980 a 2020")]
        public int Ano { get; set; }

        public bool Aprovado { get; set; }

        public DateTime Inscricao { get; set; }

        //lazy loading = add virtual
        public virtual Professor Professor { get; set; }
    }
}