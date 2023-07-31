using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLib
{
    public class Passenger
    {
        string name;
        string phoneNo;

        public Passenger()
        {
            name = "";
            phoneNo = "";
        }
        public string Name
        {
            set { name = value; }
            get { return name; }

        }
        public string PhoneNo
        {
            set { phoneNo = value; }
            get { return phoneNo; }

        }
    }
}
