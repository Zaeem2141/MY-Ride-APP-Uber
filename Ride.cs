using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLib;
using LLib;
using PLib;
using ALib;

namespace RLib
{
    public class Ride
    {

        Location start_location;
        Location end_location;
        int price;
        Driver driver;
        Passenger passenger;

        public Ride()
        {
            start_location = new Location();
            end_location = new Location();
            driver = new Driver();
            passenger = new Passenger();
            price = 0;
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public void assignPassenger()
        {
            Console.Write("Enter Your  name : ");
            passenger.Name = Console.ReadLine();
            Console.Write("Enter Your  Phone Number : ");
            String phn = Console.ReadLine();
            int ln = phn.Length;
            bool chk = true;
            while (chk)
            {
                for (int i = 0; i < ln; i++)
                {
                    if (phn[i] < '0' || phn[i] > '9')
                    {
                        chk = false;
                        break;
                    }
                }
                if (chk == false)
                {
                    Console.WriteLine("You entered wrong format please enter without any" +
                            " space and - !");
                    phn = Console.ReadLine();
                    ln = phn.Length;
                    chk = true;
                }
                else
                    chk = false;
            }
            passenger.PhoneNo = phn;

        }

        public void getLocations()
        {
            Console.Write("Enter Start Location : ");
            //start_location.Latitude =
            string s = Console.ReadLine();
            int count = 0;
            foreach (string a in s.Split(','))
            {
                if (count == 0)
                {
                    start_location.Latitude = Convert.ToSingle(a);
                    count++;
                }
                else
                {
                    start_location.Longitude = Convert.ToSingle(a);
                }
            }
            count = 0;
            Console.Write("Enter End Location : ");
            //start_location.Latitude =
            s = Console.ReadLine();
            foreach (string a in s.Split(','))
            {
                if (count == 0)
                {
                    end_location.Latitude = Convert.ToSingle(a);
                    count++;
                }
                else
                {
                    end_location.Longitude = Convert.ToSingle(a);
                }
            }

        }

        public void calculatePrice(string type)
        {
            double distance = Math.Sqrt(Math.Pow((end_location.Latitude - start_location.Latitude), 2)
                + Math.Pow((end_location.Longitude - start_location.Longitude), 2));
            int fuel_price = 250, fuel_average = 0;
            if (type == "Bike" || type == "bike")
            {
                fuel_average = 50;
            }
            else if (type == "Rickshaw" || type == "rickshaw")
            {
                fuel_average = 35;
            }
            else if (type == "Car" || type == "car")
            {
                fuel_average = 15;
            }
            price = (int)((distance * fuel_price) / fuel_average);
            if (type == "Bike" || type == "bike")
            {
                price = (int)(price + (price * 0.05));
            }
            else if (type == "Rickshaw" || type == "rickshaw")
            {
                price = (int)(price + (price * 0.1));
            }
            else if (type == "Car" || type == "car")
            {
                price = (int)(price + (price * 0.2));
            }
        }

        public void assignDriver(Admin a)
        {
            List<Driver> drivers = new List<Driver>();
            drivers = a.Drivers;
            int chk = 0, i = 0;
            double distance = 0, min = -1;

            foreach (Driver dr in drivers)
            {
                chk++;
                if (i == 0)
                {
                    distance = Math.Sqrt(Math.Pow((dr.getLat() - start_location.Latitude), 2)
                   + Math.Pow((dr.getLong() - start_location.Longitude), 2));
                    min = distance;
                    i++;
                    driver.Name = dr.Name;
                    driver.Address = dr.Address;
                    driver.Age = dr.Age;
                    driver.Availibility = dr.Availibility;
                    driver.Gender = dr.Gender;
                }
                else
                {
                    distance = Math.Sqrt(Math.Pow((dr.getLat() - start_location.Latitude), 2)
                 + Math.Pow((dr.getLong() - start_location.Longitude), 2));
                    if (distance < min)
                    {
                        min = distance;
                        driver.Name = dr.Name;
                        driver.Address = dr.Address;
                        driver.Age = dr.Age;
                        driver.Availibility = dr.Availibility;
                        driver.Gender = dr.Gender;
                    }
                }

            }
            if (chk == 0)
            {
                Console.WriteLine("Sorry No Rider Available");
            }
            else
            {
                Console.WriteLine("Happy Travel ....!");
                Console.WriteLine("Give Rating out of 5 :");
                int rating = 0;
                rating = System.Convert.ToInt32(Console.ReadLine());
                while (rating < 1 || rating > 5)
                {
                    Console.WriteLine("Please rate between 1 and 5 : ");
                    rating = System.Convert.ToInt32(Console.ReadLine());

                }
                driver.addRating(rating);
            }

        }
    }
}
