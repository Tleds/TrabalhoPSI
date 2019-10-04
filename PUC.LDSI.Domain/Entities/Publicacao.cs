using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC.LDSI.Domain.Entities
{
    public class Publicacao : Entity
    {
        
        public Avaliacao Avaliacao { get; set; }
        [Column(TypeName="DATETIME")]
        public DateTime DataPublicacao { get; set; }
        public Turma Turma { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime DataInicio { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime DataFim { get; set; }
        [Column(TypeName = "INT")]
        public int ValorProva { get; set; }

    }
}
