using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaExpress.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "{0} deverá ser informado")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "{0} deve ter no minímo {1} e no maximo {2} caracteres")]
        public string Name { get; set; }

        [Display(Name = "Descrição do Produto")]
        [Required(ErrorMessage = "{0} deverá ser informada")]
        [MinLength(20, ErrorMessage = "{0} deve ter no minímo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "{0} deve ter no maximo {1} caracteres")]
        public string Description { get; set; }

        [Display(Name = "Descrição Longa do Produto")]
        [Required(ErrorMessage = "{0} deverá ser informada")]
        [MinLength(20, ErrorMessage = "{0} deve ter no minímo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "{0} deve ter no maximo {1} caracteres")]
        public string LongDescription { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Informe {0}")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "{0} deve estar entre {1} e {2} Reais")]
        public decimal Price { get; set; }

        [Display(Name = "Caminho da Imagem Normal")]
        [StringLength(200, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }

        [Display(Name = "Caminho da Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string ThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool Favorite { get; set; }

        [Display(Name = "Estoque")]
        public bool Stock { get; set; }

        public int CategoryId {  get; set; }
        
        public virtual Category Category { get; set; }
    }
}
