using Bai_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1.ViewModels
{
    class ImageViewModel: OservationObject
    {
        private string _word;
        private string _image;

        public List<int> listImage { get; set; }
        public List<ImageViewModel> items { get; set; }

        public ImageViewModel()
        {
            listImage = new List<int>();
        }
        public void setImage()
        {
            if (items != null)
            {
                if (items.Count == listImage.Count)
                {
                    return;
                }
            }
          
            items = FileIO.LoadJson();

            Random random = new Random();
            int index = 0;

            do
            {
                index = random.Next(0, 10);

            } while (listImage.Contains(index));

            listImage.Add(index);
            Word = items[index].Word;
            Image = items[index].Image;
            
        }


        public string Word
        {
            get
            {
                if (string.IsNullOrEmpty(_word))
                {
                    return "";
                }
                return _word;
            }
            set
            {
                _word = value;
                onPropertyChanged("Word");
            }
        }

        public string Image
        {
            get
            {
                if (!string.IsNullOrEmpty(_image))
                {
                    return string.Format("../Image/{0}", _image);

                }
                return "";
            }
            set
            {
                _image = value;
                onPropertyChanged("Image");
            }
        }
    }
}
