

namespace Sales.ViewModels
{
    using Sales.Common.Models;
    using System.Collections.ObjectModel;
    public class ProductsViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
    }
}
