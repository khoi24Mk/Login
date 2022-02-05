using Login.SQLquery;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ModelView
{
    public class UsernameViewModel :ObservationObject
    {
        private string _name;
        private string _notify;

        public string Notify
        {
            get
            {
                return _notify;
            }
            set
            {
                Debug.WriteLine("NOTIFY");
                _notify = value;
                Debug.WriteLine(_notify);
            }
        }

        public string Name{
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _name = "";
                    return;
                }
                
                
                bool TempChecking = queryOperation.SQLcheckUsername(value);
                if (TempChecking)
                {
                    _name = "";
                }
                else
                {
                    _name = "This name has used";
                }
                onPropertyChange("Name");
            }
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    return "";
                }
                return _name;
            }
        }
        public UsernameViewModel() { }


    }
}
