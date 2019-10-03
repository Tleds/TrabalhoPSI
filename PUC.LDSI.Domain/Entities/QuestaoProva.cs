using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class QuestaoProva : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Questao Questao { get; set; }
        public Prova Prova { get; set; }
        [Column(TypeName ="DECIMAL(5,2)")]
        public Decimal Nota { get; set; }

    }
}
