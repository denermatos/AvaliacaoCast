using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConta.Application.Models
{
    public class ContaViewModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
