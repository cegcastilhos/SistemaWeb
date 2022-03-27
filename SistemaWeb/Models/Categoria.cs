using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Categoria
    {
        [Key]
        public  int Id { get; set; }

        public string Descricao { get; set; }
    }
}
