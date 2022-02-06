using Bai_1.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1.Model
{
    class FileIO
    {
        public static List<ImageViewModel> LoadJson()
        {

            List<ImageViewModel> items;
            /* string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Names.txt");
             Debug.WriteLine("PATH: "+path);*/
            using (StreamReader r = new StreamReader("../../ImageData.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ImageViewModel>>(json);

                foreach (ImageViewModel a in items)
                {
                    Console.WriteLine("{0} {1}", a.Word, a.Image);
                }

            }
            return items;

            }
        }
    }
