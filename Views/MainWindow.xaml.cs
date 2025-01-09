using examenSeptembre2022.ViewModels;
using System.Windows;

namespace examenSeptembre2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ProductsVM();
        }
    }
}