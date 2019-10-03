using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Questao : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Avaliacao Avaliacao { get; set; }
        [Column(TypeName="INT")]
        public int Tipo { get; set; }
        [StringLength(255)]
        public string Enunciado { get; set; }

    }
}
