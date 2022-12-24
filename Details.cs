using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Details
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfWheet> typesOfWheet;
        public List<TypesOfPulses> typesOfPulses;
    }

    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfWheet
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfPulses
    {
        public string name;
        public int weight;
        public int price;
    }
}
