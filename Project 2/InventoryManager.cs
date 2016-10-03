using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class InventoryManager
    {
        public Inventory TestInventory;
        public JsonReader JReader;

        public InventoryManager(Inventory i)
        {
            TestInventory = i;
            JReader = new JsonReader();
        }
        public void CreateMerch(string rif_ID, string name, decimal price, int quantity, string description)
        {
            Merchandise Item = new Merchandise(rif_ID, name, price, quantity, description);
            if (Item != null)
            {
                TestInventory.AddToInventory(Item);
                JReader.WriteJsonItem(TestInventory.GetAllItems());
            }
        }

        public void CreateSnapBack(string rif_ID, string name, decimal price, int quantity, string description)
        {
            SnapBackHat Item = new SnapBackHat(rif_ID, name, price, quantity, description);
            if (Item != null)
            {
                TestInventory.AddToInventory(Item);
                JReader.WriteJsonItem(TestInventory.GetAllItems());
            }

        }
        public void CreateFitted(string rif_ID, string name, decimal price, int quantity, string description, string size)
        {
            FittedHat Item = new FittedHat(rif_ID, name, price, quantity, description, size);
            if (Item != null)
            {
                TestInventory.AddToInventory(Item);
                JReader.WriteJsonItem(TestInventory.GetAllItems());
            }
        }
        public void EditItem(string rif_ID, Item editedItem)
        {

        }
    }
}
