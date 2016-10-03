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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_2
{
    /// <summary>
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public CreateWindow()
        {
            TestInventory = Inventory.Instance;

            TestInventoryManager = new InventoryManager(TestInventory);

            InitializeComponent();

            //Fill ComboBox with the available hat sizes
            sizeComboBox.Items.Add("6 5/8");
            sizeComboBox.Items.Add("6 3/4");
            sizeComboBox.Items.Add("6 7/8");
            sizeComboBox.Items.Add("7");
            sizeComboBox.Items.Add("7 1/8");
            sizeComboBox.Items.Add("7 1/4");
            sizeComboBox.Items.Add("7 3/8");
            sizeComboBox.Items.Add("7 1/2");
            sizeComboBox.Items.Add("7 5/8");
            sizeComboBox.Items.Add("7 3/4");
            sizeComboBox.Items.Add("7 7/8");
            sizeComboBox.Items.Add("8");
    }

        //Not sure if this block is how we should be instantiating objects.
        public Inventory TestInventory { get; set; }
        private InventoryManager TestInventoryManager { get; set; }
        public string Rif_ID { get; set; }
        public string ItemName { get; set; } //Cannot be Name, need to update models
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }

        private void clickCreateItem(object sender, RoutedEventArgs e)
        {
            Rif_ID = RIF_ID_Text.Text;
            ItemName = ItemNameText.Text;
            Price = Convert.ToDecimal(PriceText.Text);
            Quantity = Convert.ToInt16(QuantityText.Text);
            Description = DescriptionText.Text;

            if (merchButton.IsChecked == true)
            {
                TestInventoryManager.CreateMerch(Rif_ID, ItemName, Price, Quantity, Description);
            }
            else if (snapBackButton.IsChecked == true)
            {
                TestInventoryManager.CreateSnapBack(Rif_ID, ItemName, Price, Quantity, Description);
            }
            else
            {
                //Not sure if this is right
                Size = sizeComboBox.SelectedValue.ToString();
                TestInventoryManager.CreateFitted(Rif_ID, ItemName, Price, Quantity, Description, Size);
            }

            var confirmCreate = MessageBox.Show("Item Created Successfully!");

            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
    }
}
