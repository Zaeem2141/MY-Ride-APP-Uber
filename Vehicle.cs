using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLib
{
    public class Vehicle
    {
        string type;
        string model;
        string license_plate;

        public Vehicle()
        {
            type = model = license_plate = "";
        }

        public string Type
        {
            set { type = value; }
            get { return type; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public string Licenseplate
        {
            get { return license_plate; }
            set { license_plate = value; }
        }
    }
}
