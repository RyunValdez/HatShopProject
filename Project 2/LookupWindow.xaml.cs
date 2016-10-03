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
    public partial class LookupWindow : Window
    {
        private bool editMode = false;

        public LookupWindow()
        {
            TestInventory = Inventory.Instance;

            InitializeComponent();

            populateSearchWindow();

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

            tempList.ForEach(item => itemListBox.Items.Add(item.RIF_ID + ": " + item.Name));
        }

        private void findSelectedItem()
        {
            string itemString = (string)itemListBox.SelectedValue;

            if (itemString != null) //This event triggers when the reset button is hit because the selected item goes from something to nothing
                                    //we can use it as an opportunity to clear the textboxes if the string recieved is null.
            {
                string ID_str = itemString.Substring(0, itemString.LastIndexOf(':'));

                Item tempItem = TestInventory.GetItembyId(ID_str);
                if (tempItem != null)
                {
                    nameTextBox.Text = tempItem.Name;
                    priceTextBox.Text = tempItem.Price.ToString();
                    quantityTextBox.Text = tempItem.Quantity.ToString();
                    descriptionTextBox.Text = tempItem.Description.ToString();

                    //Only Fitted Hats should fill this textbox
                    if (tempItem.GetType() == typeof(FittedHat))
                    {
                        FittedHat fHat = (FittedHat)tempItem;
                        sizeComboBox.Text = fHat.Size;
                    }
                    else
                    {
                        //Clear the textbox
                        sizeComboBox.Text = "";
                    }
                }
            }
            else
            {
                nameTextBox.Text = "";
                priceTextBox.Text = "";
                quantityTextBox.Text = "";
                descriptionTextBox.Text = "";
                sizeComboBox.Text = "";
            }
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
            //tempList.ForEach(item => itemListBox.Items.Add(item));
        }

        protected void ItemSelected(object sender, SelectionChangedEventArgs e)
        {
            findSelectedItem();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (editMode == false)
            {
                cancelEditButton.Visibility = Visibility.Visible;
                editGroupBox.Visibility = Visibility.Visible;
                editButton.Content = "Save";

                nameTextBox.IsEnabled = true;
                sizeComboBox.IsEnabled = true;
                priceTextBox.IsEnabled = true;
                quantityTextBox.IsEnabled = true;
                descriptionTextBox.IsEnabled = true;
                plusButton.IsEnabled = true;
                minusButton.IsEnabled = true;

                editMode = true;
            }
            else
            {
                string itemString = (string)itemListBox.SelectedValue;
                if (itemString != null)
                {
                    string ID_str = itemString.Substring(0, itemString.LastIndexOf(':'));

                    Item tempItem = TestInventory.GetItembyId(ID_str);
                    if (tempItem != null)
                    {
                        tempItem.Name = nameTextBox.Text;
                        tempItem.Price = Convert.ToDecimal(priceTextBox.Text);
                        tempItem.Quantity = Convert.ToInt16(quantityTextBox.Text);
                        tempItem.Description = descriptionTextBox.Text;

                        //Only Fitted Hats should fill this textbox
                        if (tempItem.GetType() == typeof(FittedHat))
                        {
                            FittedHat fHat = (FittedHat)tempItem;
                            fHat.Size = sizeComboBox.Text;
                            TestInventory.ReplaceItem(ID_str, fHat);
                        }
                        else
                        {
                            TestInventory.ReplaceItem(ID_str, tempItem);
                        }
                        //Write the change to the DB
                        JsonReader JReader = new JsonReader();
                        JReader.WriteJsonItem(TestInventory.GetAllItems());
                        var confirmEdit = MessageBox.Show("Item Edited Successfully!");
                    }
                }

                cancelEditButton.Visibility = Visibility.Hidden;
                editGroupBox.Visibility = Visibility.Hidden;
                editButton.Content = "Edit";

                nameTextBox.IsEnabled = false;
                sizeComboBox.IsEnabled = false;
                priceTextBox.IsEnabled = false;
                quantityTextBox.IsEnabled = false;
                descriptionTextBox.IsEnabled = false;
                plusButton.IsEnabled = false;
                minusButton.IsEnabled = false;

                editMode = false;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //Code for PLus Button
        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt16(quantityTextBox.Text);

            quantityTextBox.Text = (++i).ToString();
        }
        //Code for minus button
        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt16(quantityTextBox.Text);

            quantityTextBox.Text = (--i).ToString();
        }

        private void cancelEditButton_Click(object sender, RoutedEventArgs e)
        {
            findSelectedItem();

            cancelEditButton.Visibility = Visibility.Hidden;
            editGroupBox.Visibility = Visibility.Hidden;
            editButton.Content = "Edit";

            nameTextBox.IsEnabled = false;
            sizeComboBox.IsEnabled = false;
            priceTextBox.IsEnabled = false;
            quantityTextBox.IsEnabled = false;
            descriptionTextBox.IsEnabled = false;
            plusButton.IsEnabled = false;
            minusButton.IsEnabled = false;

            editMode = false;
        }
    }
}
       
    


