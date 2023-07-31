using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLib
{
    public class Location
    {

        float latitude;
        float longitude;

        public Location()
        {
            latitude = 0;
            longitude = 0;
        }

        public float Latitude
        {
            set { latitude = value; }
            get { return latitude; }
        }

        public float Longitude
        {
            set { longitude = value; }
            get { return longitude; }
        }
    }
}
