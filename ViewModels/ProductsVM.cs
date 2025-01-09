using examenSeptembre2022.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfApplication1.ViewModels;

namespace examenSeptembre2022.ViewModels
{
    public class ProductsVM : INotifyPropertyChanged
    {

        private ObservableCollection<ProductModel> _ProductsList;
        private readonly NorthwindContext northwindContext = new NorthwindContext();
        private ProductModel _SelectedProduct;
        private DelegateCommand _UpdateProduct;
        private ObservableCollection<ProductSales> _ProductSales;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<ProductModel> ProductList
        {
            get
            {
                if(_ProductsList == null)
                {
                    _ProductsList = loadProducts();
                }
                return _ProductsList;
            }
        }

        public ObservableCollection<ProductModel> loadProducts()
        {
            ObservableCollection<ProductModel> products = new ObservableCollection<ProductModel>();
            foreach(Product product in northwindContext.Products)
            {
                products.Add(new ProductModel(product));
            }

            return products;
        }

        public ProductModel SelectedProduct
        {
            get { return _SelectedProduct; }
            set { _SelectedProduct = value; OnPropertyChanged("SelectedProduct"); }
        }

        public DelegateCommand UpdateCommand
        {
            get
            {
                if(_UpdateProduct == null)
                {
                    _UpdateProduct = new DelegateCommand(ChangeValue);
                }
                return _UpdateProduct;
            }
        }

        private void ChangeValue()
        {
            var product = northwindContext.Products.FirstOrDefault(p => p.ProductId == SelectedProduct.ProductId);

            if(product != null)
            {
                product.ProductName = SelectedProduct.ProductName;
                product.QuantityPerUnit = SelectedProduct.QuantityPerUnit;

                northwindContext.SaveChanges();
                OnPropertyChanged("ProductList");

            }
        }

        public ObservableCollection<ProductSales> ProductSalesList
        {
            get
            {
                if(_ProductSales == null)
                {
                    _ProductSales = loadProductsSales();
                }
                return _ProductSales;
            }
        }

        public ObservableCollection<ProductSales> loadProductsSales()
        {
            var sales = from orderDetail in northwindContext.OrderDetails
                        group orderDetail by orderDetail.ProductId into productGroup
                        select new ProductSales
                        {
                            ProductId = productGroup.Key,
                            TotalSales = productGroup.Sum(od => od.UnitPrice * od.Quantity)
                        };

            ObservableCollection<ProductSales> productSalesList = new ObservableCollection<ProductSales>(sales);

            return productSalesList;
        }
    }
}
