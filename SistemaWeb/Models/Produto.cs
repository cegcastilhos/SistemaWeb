using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }  


    }
}
