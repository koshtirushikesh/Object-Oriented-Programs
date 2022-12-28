using System;
using System.Runtime.Serialization.Formatters;

namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\rushi\\source\\repos\\InventoryManagement\\Inventory.json";
            
            FetchInventoryDetails fetchInventoryDetails= new FetchInventoryDetails();
            Details details = new Details();
            Details data=fetchInventoryDetails.Read(path);
            int totalstock = 0;
            for (int i = 0; i < data.stockManagment.Count; i++)
            {
                Console.WriteLine(data.stockManagment[i].StockNames);
                Console.WriteLine(data.stockManagment[i].NumberShare);
                Console.WriteLine(data.stockManagment[i].Price);

                int num = data.stockManagment[i].NumberShare * data.stockManagment[i].Price;
                
                Console.WriteLine("value of each stocke: " + num);
                totalstock += num;
            }
            Console.WriteLine("total value of stock:= " + totalstock);
        }
    }
}