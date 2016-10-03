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
    /// Interaction logic for SummaryWindow.xaml
    /// </summary>
    public partial class SummaryWindow : Window
    {
        public SummaryWindow()
        {
            TestInventory = Inventory.Instance;
            InitializeComponent();
            writeSummary();
        }

        public Inventory TestInventory { get; set; }
        public void writeSummary()
        {
            foreach (Item item in TestInventory.GetAllItems())
            {
                var data = new RowObject();
                if (item.GetType() == typeof(FittedHat))
                {
                    FittedHat fHat = (FittedHat)item;
                    data = new RowObject { Name = item.Name, Size = fHat.Size, Quantity = Convert.ToString(item.Quantity), Price = "$ " + Convert.ToString(item.Price),
                        RIF_ID = item.RIF_ID, TotalPrice = "$ " + Convert.ToString(item.Price * item.Quantity) };
                }
                else
                {
                    data = new RowObject { Name = item.Name, Size = "", Quantity = Convert.ToString(item.Quantity), Price = "$ " + Convert.ToString(item.Price),
                        RIF_ID = item.RIF_ID, TotalPrice = "$ " + Convert.ToString(item.Price * item.Quantity) };
                }
                summaryDataGrid.Items.Add(data);
            }
            calculateTotal();
        }
        private void calculateTotal()
        {
            decimal runningTotal = 0;

            foreach (RowObject row in summaryDataGrid.Items)
            {
                string cutPrice = row.TotalPrice.Substring(2);
                runningTotal += (Convert.ToDecimal(cutPrice));
            }

            totalTextBox.Text = "$ " + Convert.ToString(runningTotal);
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        public class RowObject
        {
            public string Name { get; set; }
            public string Size { get; set; }
            public string Quantity { get; set; }
            public string RIF_ID { get; set; }
            public string Price { get; set; }
            public string TotalPrice { get; set; }
        }
    }
}
