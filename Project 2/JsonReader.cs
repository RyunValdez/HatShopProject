using Project_2.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Project_2
{
    public class JsonReader
    {
        public List<Employee> ReadJsonEmployee()
        {
            string text = File.ReadAllText(Settings.Default.JsonFile);

            //Employees
            var employeeList = JObject.Parse(text).SelectToken("Employee").ToObject<List<Employee>>();

            return employeeList;
        }

        public List<Item> ReadJsonItem()
        {
            List<Item> itemList = new List<Item>();

            string text = File.ReadAllText(Settings.Default.JsonFile);

            //Fitted hats
            itemList.AddRange(JObject.Parse(text).SelectToken("FittedHat").ToObject<List<FittedHat>>());
            //Snap backs
            itemList.AddRange(JObject.Parse(text).SelectToken("SnapBackHat").ToObject<List<SnapBackHat>>());
            //Merchandise
            itemList.AddRange(JObject.Parse(text).SelectToken("Merchandise").ToObject<List<Merchandise>>());

            return itemList;
        }

        public void WriteJsonItem(List<Item> itemList)
        {
            string fittedHatJson = "\"FittedHat\": [";
            string snapBackHatJson = "\"SnapBackHat\": [";
            string merchJson = "\"Merchandise\": [";

            foreach (Item item in itemList)
            {
                if(item.GetType() == typeof(FittedHat))
                {
                    fittedHatJson = fittedHatJson + JsonConvert.SerializeObject(item) + ',';
                }
                else if(item.GetType() == typeof(SnapBackHat))
                {
                    snapBackHatJson = snapBackHatJson + JsonConvert.SerializeObject(item) + ',';
                }
                else if(item.GetType() == typeof(Merchandise))
                {
                    merchJson = merchJson + JsonConvert.SerializeObject(item) + ',';
                }
            }

            fittedHatJson = fittedHatJson.TrimEnd(',');
            snapBackHatJson = snapBackHatJson.TrimEnd(',');
            merchJson = merchJson.TrimEnd(',');

            fittedHatJson += ']';
            snapBackHatJson += ']';
            merchJson += ']';


            string json = '{' + fittedHatJson + ',' + snapBackHatJson + ',' +merchJson + '}';

            System.IO.File.WriteAllText(@Settings.Default.JsonFile, json);
        }
    }
}