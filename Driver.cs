using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLib;
using LLib;

namespace DLib
{
    public class Driver
    {
        string id;
        string name;
        string gender;
        int age;
        string address;
        string phoneNo;
        Vehicle vehicle;
        Location curr_location;
        List<int> rating;
        bool availibility;

        public Driver()
        {
            id = name = gender = address = phoneNo = "";
            age = 0;
            vehicle = new Vehicle();
            curr_location = new Location();
            availibility = false;
            rating = new List<int>();
        }

        public float setLat
        {
            set { curr_location.Latitude = value; }
        }

        public float setLong
        {
            set { curr_location.Longitude = value; }
        }
        public string gettype()
        {
            return vehicle.Type;
        }
        public string getMod()
        {
            return vehicle.Model;
        }
        public string getLic()
        {
            return vehicle.Licenseplate;
        }
        public float getLat()
        {
            return curr_location.Latitude;
        }
        public float getLong()
        {
            return curr_location.Longitude;
        }

        public void addRating(int rat)
        {
            rating.Add(rat);
        }

        public string setVType
        {
            set { vehicle.Type = value; }
            get { return vehicle.Type; }
        }
        public string setMType
        {
            set { vehicle.Model = value; }
            get { return vehicle.Model; }
        }
        public string setLType
        {
            set { vehicle.Licenseplate = value; }
            get { return vehicle.Licenseplate; }
        }

        public Vehicle Vehicle { get { return vehicle; } }

        public string ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        public bool Availibility
        {
            set { availibility = value; }
            get { return availibility; }
        }

        public float getRating()
        {
            int sum = 0, l = 0;
            foreach (int i in rating)
            {
                sum += rating[i];
                l++;
            }
            return sum / l;
        }

        public void updateLocation(int chk)
        {

            Console.Write("Enter Location : ");
            string s = Console.ReadLine();
            int count = 0;
            foreach (string a in s.Split(','))
            {
                if (count == 0)
                {
                    curr_location.Latitude = Convert.ToSingle(a);
                    count++;
                }
                else
                {
                    curr_location.Longitude = Convert.ToSingle(a);
                }
            }
            if (chk == 0)
                Console.WriteLine("Thanks ! Its updated ");
            else
                Console.WriteLine("Thanks ! Its Entered ");
        }

        public void updateAvailibility()
        {
            Console.WriteLine("Enter Your Availibility :");
            Console.WriteLine("1. Ture ");
            Console.WriteLine("2. False ");
            int ch = System.Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                availibility = true;
            }
            else
            {
                availibility = false;
            }
        }
    }
}
