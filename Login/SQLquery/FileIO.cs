using Login.ModelView;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Login.SQLquery
{
    public class FileIO
    {

        public static List<ItemImage> LoadJson()
        {

            List<ItemImage> items;
           /* string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Names.txt");
            Debug.WriteLine("PATH: "+path);*/
            using (StreamReader r = new StreamReader("../../imageInfo.json"))
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
