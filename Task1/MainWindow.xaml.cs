using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                Price = 30.0,
                Image = "Data/bread.jpg",
                Category = ProductCategory.Food
            });
            products.Add(new Product()
            {
                ProductName = "Утюг",
                Price = 2300.0,
                Image = "Data/iron.jpg",
                Category = ProductCategory.HouseholdAppliances
            });
            products.Add(new Product()
            {
                ProductName = "Молоко",
                Price = 80.0,
                Image = "Data/milk.jpg",
                Category = ProductCategory.Food
            });
            products.Add(new Product()
            {
                ProductName = "Яблоки",
                Price = 130.0,
                Image = "Data/apple.jpg",
                Category = ProductCategory.Food
            });
            products.Add(new Product()
            {
                ProductName = "Микроволновка",
                Price = 7400.0,
                Image = "Data/microwave.jpg",
                Category = ProductCategory.HouseholdAppliances
            });
            products.Add(new Product()
            {
                ProductName = "Мясорубка",
                Price = 9000.0,
                Image = "Data/meat_grinder.jpg",
                Category = ProductCategory.HouseholdAppliances
            });
            listBox.ItemsSource = products;
        }
    }
}