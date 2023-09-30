using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaExpress.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe {0} da Categoria")]
        [StringLength(100, ErrorMessage = "Tamanho maximo é {1} Caracteres")] 
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe {0} da Categoria")]
        [StringLength(200, ErrorMessage = "Tamanho maximo é {1} Caracteres")]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
