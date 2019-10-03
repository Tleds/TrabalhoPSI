using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC.LDSI.Domain.Entities
{
    public class Prova : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Avaliacao")]
        public int AvaliacaoId { get; set; }
        [ForeignKey("Aluno")]
        public int AlunoId { get; set; }
        [Column(TypeName ="decimal(10,4)")]
        public decimal NotaEmitida { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Aluno Aluno { get; set; }
        public DateTime DataProva { get; set; }
        public Decimal NotaObtida { get; set; }

    }
}
