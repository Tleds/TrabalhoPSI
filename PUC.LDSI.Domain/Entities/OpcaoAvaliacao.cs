using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC.LDSI.Domain.Entities
{
    public class OpcaoAvaliacao : Entity
    {

        
        public Questao Questao { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        [Column(TypeName = "bit")]
        public bool Verdadeira { get; set; }

    }
}
