using System.ComponentModel.DataAnnotations;

namespace ProjetoConta.Api.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
