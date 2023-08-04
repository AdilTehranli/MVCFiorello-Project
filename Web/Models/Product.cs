using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models;

public class Product :BaseEntity
{
    public string Name { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public  decimal Price { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<ProductImage> ProductImages { get; set; }

}
