using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ModelView
{
    
    public class ImageViewModel: ObservationObject
    {
        private string _word;
        private string _image;

        public List<int> listImage { get; set; }
        public List<ItemImage> items { get; set; }
        public ImageViewModel()
        {
            listImage = new List<int>();
        }

        public string Word
        {
            get
            {
               
                if (!string.IsNullOrEmpty(_word))
                {
                    return _word;
                }
                return null;
            }
            set
            {
                _word = value;
                onPropertyChange("Word");
            }
        }

        public string Image
        {
            get
            {
                Debug.WriteLine("--+----" + _image);
                if (!string.IsNullOrEmpty(_image))
                {
                    return string.Format("../Image/{0}.jpg",_image);
                }
                return null;
            }
            set
            {
                _image = value;
                onPropertyChange("Image");
            }
        }

        public bool checkWord(string word)
        {
            return items[listImage.Last()].word.ToLower() == word.ToLower();
        }
    }
}
