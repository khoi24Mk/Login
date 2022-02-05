using Login.ModelView;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.SQLquery
{
    public class FileIO
    {

        public static List<ItemImage> LoadJson()
        {

            List<ItemImage> items;
            using (StreamReader r = new StreamReader("imageInfo.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ItemImage>>(json);

                foreach (ItemImage a in items)
                {
                    Console.WriteLine("{0} {1}", a.word, a.image);
                }

            }
            return items;

        }
    }
}
