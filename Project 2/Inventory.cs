using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class Inventory : IEnumerable<Item>
    {
        private List<Item> InventoryList { get; set; }

        private static Inventory instance;

        private Inventory()
        {
            InventoryList = new List<Item>();
        }

        public static Inventory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Inventory();
                }
                return instance;
            }
        }

        public void AddToInventory(Item item)
        {
            InventoryList.Add(item);
        }

        public void AddToInventory(List<Item> itemList)
        {
            InventoryList.AddRange(itemList);
        }

        public void DeleteInventory()
        {
            InventoryList.Clear();
        }


        //Iterate backwards because at certain points in the code we need to modify the lists while iterating
        public Item GetItembyId(string ID_str)
        {
            for (var i = InventoryList.Count - 1; i >= 0; i--)
            {
                if (ID_str == InventoryList[i].RIF_ID)
                {
                    return InventoryList[i];
                }
            }
            //this could be a little dangerous if the code is expecting an Item
            return null;
        }

        public Item GetItembyName(string name)
        {
            for (var i = InventoryList.Count - 1; i >= 0; i--)
            {
                if (name == InventoryList[i].Name)
                {
                    return InventoryList[i];
                }
            }
            //this could be a little dangerous if the code is expecting an Item
            return null;
        }

        public List<Item> GetAllItems()
        {
            return InventoryList;
        }

        public void ReplaceItem(string rifID, Item newItem)
        {
            for(int i = 0; i < InventoryList.Count; i++)
            {
                if(InventoryList[i].RIF_ID == rifID)
                {
                    InventoryList[i] = newItem;
                    return;
                }
            }
        }

        public IEnumerator<Item> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
