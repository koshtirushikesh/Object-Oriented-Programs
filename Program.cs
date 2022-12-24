namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\rushi\\source\\repos\\InventoryManagement\\Inventory.json";
            
            FetchInventoryDetails fetchInventoryDetails= new FetchInventoryDetails();

            Details data=fetchInventoryDetails.Read(path);

            for (int i=0;i<data.typesOfRice.Count;i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);

                
            }

            for (int i = 0; i < data.typesOfWheet.Count; i++)
            {
                Console.WriteLine(data.typesOfWheet[i].name);
                Console.WriteLine(data.typesOfWheet[i].weight);
                Console.WriteLine(data.typesOfWheet[i].price);
                

            }

            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);
                
            }



        }
    }
}