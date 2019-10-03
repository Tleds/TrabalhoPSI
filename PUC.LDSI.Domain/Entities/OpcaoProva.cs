using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC.LDSI.Domain.Entities
{
    public class OpcaoProva : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public OpcaoAvaliacao Opcao { get; set; }
        public QuestaoProva QuestaoProva { get; set; }
        public bool Resposta { get; set; }
    }
}
