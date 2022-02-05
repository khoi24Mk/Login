using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ModelView
{
    public class PasswordComfirmViewModel: ObservationObject
    {
        private string _password;

        public string Password
        {
            get
            {
                if (string.IsNullOrEmpty(_password))
                {
                    return "";
                }
                return _password;
            }
            set
            {
                _password = value;
                onPropertyChange("Password");
            }
        }
    }
}
