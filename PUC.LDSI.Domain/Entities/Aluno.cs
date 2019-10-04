using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC.LDSI.Domain.Entities
{
   public class Aluno : Entity
    {
        //Setar todas as foreign key em todas as classes
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Matricula { get; set; }
        public Turma Turma { get; set; }
        [StringLength(100)]
        public string Senha { get; set; }

    }
}
