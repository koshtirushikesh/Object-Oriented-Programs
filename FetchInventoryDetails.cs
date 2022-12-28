using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class FetchInventoryDetails
    {
        public Details Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    Details abc = JsonConvert.DeserializeObject<Details>(json);
                    return JsonConvert.DeserializeObject<Details>(json);
                }catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}
