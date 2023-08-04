using Web.Models;

namespace Web.ViewModels
{
    public class HomeVM
    {
        public  List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductsImage { get; set; }
    }
}
