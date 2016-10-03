using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Project_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestInventory = Inventory.Instance;

            loadItemDB();
        }

        public Inventory TestInventory { get; set; }
        private InventoryManager TestInventoryManager { get; set; }

        private void lookupButton_Click(object sender, RoutedEventArgs e)
        {
            LookupWindow lookupWin = new LookupWindow();
            lookupWin.Show();
            this.Close();
        }

        private void createItemButton_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWin = new CreateWindow();
            createWin.Show();
            this.Close();
        }

        private void loadItemDB()
        {
            JsonReader reader = new JsonReader();
            List<Item> tempList = reader.ReadJsonItem();

            TestInventory.DeleteInventory();
            TestInventory.AddToInventory(tempList);           
        }

        private void sellButton_Click(object sender, RoutedEventArgs e)
        {
            SaleWindow saleWin = new SaleWindow();
            saleWin.Show();
            this.Close();
        }

        private void summaryButton_Click(object sender, RoutedEventArgs e)
        {
            SummaryWindow sumWin = new SummaryWindow();
            sumWin.Show();
            this.Close();
        }
    }

}
