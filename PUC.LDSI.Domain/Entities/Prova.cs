using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC.LDSI.Domain.Entities
{
    public class Prova : Entity
    {

        [ForeignKey("Avaliacao")]
        public int AvaliacaoId { get; set; }
        [ForeignKey("Aluno")]
        public int AlunoId { get; set; }
        [Column(TypeName ="decimal(10,4)")]
        public Decimal NotaEmitida { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Aluno Aluno { get; set; }
        public DateTime DataProva { get; set; }
        

    }
}
