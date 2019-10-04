using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC.LDSI.Domain.Entities
{
    public class Professor : Entity
    {

        
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Login { get; set; }
        [StringLength(100)]
        public string Senha { get; set; }
        

    }
}
