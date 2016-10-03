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
    /// Interaction logic for LookupWindow.xaml
    /// </summary>
    public partial class SaleWindow : Window
    {
        public SaleWindow()
        {
            TestInventory = Inventory.Instance;

            InitializeComponent();

            populateSearchWindow();

        }

        public Inventory TestInventory { get; set; }
        private InventoryManager TestInventoryManager { get; set; }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void populateSearchWindow()
        {
            List<Item> tempList = new List<Item>();
            tempList = TestInventory.GetAllItems();

            tempList.ForEach(item => itemListBox.Items.Add(item.RIF_ID + ": " +item.Name));
        }

        private void calculateTotal()
        {
            decimal runningTotal = 0;

            foreach (RowObject row in saleDataGrid.Items)
            {
                string cutPrice = row.Price.Substring(2);
                runningTotal += (Convert.ToDecimal(cutPrice));
            }

            totalTextBox.Text = "$ " + Convert.ToString(runningTotal);
        }

        private void addSelectedItem()
        {
            string itemString = (string)itemListBox.SelectedValue;

            if (itemString != null) //This event triggers when the reset button is hit because the selected item goes from something to nothing
            {
                string ID_str = itemString.Substring(0, itemString.LastIndexOf(':'));

                Item tempItem = TestInventory.GetItembyId(ID_str);
                if (tempItem != null)
                {
                    foreach (RowObject row in saleDataGrid.Items)
                        {
                            //Already buying one of these items
                            if (row.Name == tempItem.Name)
                            {
                                int saleQuantity = Convert.ToInt16(row.Quantity);
                                //Selling too much
                                if (saleQuantity >= tempItem.Quantity)
                                {
                                    var overSold = MessageBox.Show("Item no longer in stock");
                                }
                                else
                                {
                                    saleQuantity += 1;
                                    decimal salePrice = tempItem.Price * saleQuantity;
                                    var newData = new RowObject { Name = tempItem.Name, Quantity = Convert.ToString(saleQuantity), Price = "$ " + Convert.ToString(salePrice) };

                                    saleDataGrid.Items.Remove(row);
                                    saleDataGrid.Items.Add(newData);
                                    calculateTotal();
                                }
                                return;
                            }
                        }
                    //If the code reaches here, you haven't found an existing row
                    var data = new RowObject { Name = tempItem.Name, Quantity = "1", Price = "$ " + Convert.ToString(tempItem.Price) };

                    saleDataGrid.Items.Add(data);
                    calculateTotal();
                }
            }
        }

        public class RowObject
        {
            public string Name { get; set; }
            public string Quantity { get; set; }
            public string Price { get; set; }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            itemListBox.Items.Clear();

            string ID_str = rifTextBox.Text;
            List<Item> tempList = new List<Item>();

            Item tempItem = TestInventory.GetItembyId(ID_str);
            if (tempItem != null)
            {
                tempList.Add(tempItem);
            }

            tempList.ForEach(item => itemListBox.Items.Add(item.RIF_ID + ": " + item.Name));
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            itemListBox.Items.Clear();
            rifTextBox.Clear();

            List<Item> tempList = new List<Item>();
            tempList = TestInventory.GetAllItems();

            tempList.ForEach(item => itemListBox.Items.Add(item.RIF_ID + ": " + item.Name));
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            addSelectedItem();
        }

        private void sellButton_Click(object sender, RoutedEventArgs e)
        {
            string runningTotal = totalTextBox.Text;
            var itemSold = MessageBox.Show("Sale Total: " + runningTotal);

            //Running through the list of sold items
            foreach (RowObject row in saleDataGrid.Items)
            {
                int decrementQuantity = Convert.ToInt16(row.Quantity);
                string rowName = row.Name;

                Item tempItem = TestInventory.GetItembyName(rowName);
                if (tempItem != null)
                {
                    tempItem.Quantity = tempItem.Quantity - decrementQuantity;
                    TestInventory.ReplaceItem(tempItem.RIF_ID, tempItem);
                }
            }

            //Write the change to the DB
            JsonReader JReader = new JsonReader();
            JReader.WriteJsonItem(TestInventory.GetAllItems());

            //return to main page
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            string itemString = (string)itemListBox.SelectedValue;

            if (itemString != null) //This event triggers when the reset button is hit because the selected item goes from something to nothing
            {
                string ID_str = itemString.Substring(0, itemString.LastIndexOf(':'));

                Item tempItem = TestInventory.GetItembyId(ID_str);
                if (tempItem != null)
                {
                    foreach (RowObject row in saleDataGrid.Items)
                    {
                        //Already buying one of these items
                        if (row.Name == tempItem.Name)
                        {
                            int saleQuantity = Convert.ToInt16(row.Quantity);
                               
                            saleQuantity -= 1;
                            if (saleQuantity <= 0)
                            {
                                saleDataGrid.Items.Remove(row);
                            }
                            else
                            {
                                decimal salePrice = Convert.ToDecimal(tempItem.Price) * saleQuantity;
                                var newData = new RowObject { Name = tempItem.Name, Quantity = Convert.ToString(saleQuantity), Price = "$ " + Convert.ToString(salePrice) };

                                saleDataGrid.Items.Remove(row);
                                saleDataGrid.Items.Add(newData);
                            }
                            calculateTotal();
                            return;
                        }
                    }
                }
            }
        }
    }
}
       
    


