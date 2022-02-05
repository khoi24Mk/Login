using Login.SQLquery;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ModelView
{
    public class MainViewModel: ObservationObject
    {
        public PasswordComfirmViewModel Pass { get; set; }
        public UsernameViewModel Username { get; set; }


         
        public MainScreen MyMainScreen { get; set; }
        public MainFlag MyMainFlag { get; set; }

        public ImageViewModel ImageViewModel { get; set; }
        List<int> listImage { get; set; }

        public MainViewModel()
        {
            Pass = new PasswordComfirmViewModel();
            Username = new UsernameViewModel();

            MyMainFlag = new MainFlag();
            MyMainScreen = new OptionViewModel();
            ImageViewModel = new ImageViewModel();
            listImage = new List<int>();
        }
        public void setImage()
        {
            List<ItemImage> items = FileIO.LoadJson();

            Random random = new Random();
            int index = 0;

            do
            {
                index = random.Next(0, 10);

            } while (listImage.Contains(index));

            listImage.Add(index);
            ImageViewModel.Word = items[index].word;
            ImageViewModel.Image = items[index].image;

        }
        public void setScreen(string _status)
        {
            if(_status == "OPTION")
            {
                Debug.WriteLine("LEARN");
                MyMainScreen = new OptionViewModel();
                
            }
            else if (_status == "learn")
            {
                Debug.WriteLine("LEARN");
                MyMainScreen = new LearnViewModel();

            }
            else
            {
                Debug.WriteLine("TEST");
                MyMainScreen = new TestViewModel();
            }
            onPropertyChange("MyMainScreen");
        }

        public void setFlag(string flag)
        {
            if(flag == "true")
            {
                MyMainFlag = new CorrectFlagViewModel();
            }
            else
            {
                MyMainFlag = new IncorrectFlagViewModel();
            }
        }
    }
}
