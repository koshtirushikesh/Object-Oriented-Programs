using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Details
    {
        
        public List<StockManagment> stockManagment;
    }

    public class StockManagment
    {
        public string StockNames;
        public int NumberShare;
        public int Price;
    }
}
