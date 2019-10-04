using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Turma : Entity
    {

        
        [StringLength(100)]
        public string Nome { get; set; }
    }
}
