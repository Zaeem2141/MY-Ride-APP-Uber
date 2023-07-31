using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALib;
using DriverManager;
using RLib;
using DLib;

namespace MyRide_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Admin ad = new Admin();
            DManager mng = new DManager();
            bool ans = true;
            while (ans)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("\t\t\t\t---------------------------------------------");
                Console.WriteLine("\t\t\t\t|             Welcome To MyRide             |");
                Console.WriteLine("\t\t\t\t---------------------------------------------");
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\t\t  1. Book a Ride");
                Console.WriteLine("\t\t\t\t\t  2. Enter as Driver");
                Console.WriteLine("\t\t\t\t\t  3. Enter As Admin");
                Console.WriteLine("\t\t\t\t\t  4. Exit");
                Console.WriteLine("\n\t\t\t\t   Press 1 to 4 to select an option\n");
                Console.Write("\t\t\t\t");
                choice = System.Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        char ch = 'a';
                        Ride ride = new Ride();
                        ride.assignPassenger();
                        ride.getLocations();
                        Console.Write("Enter Ride Type : ");
                        ride.calculatePrice(Console.ReadLine());
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("---------------THANK YOU --------------");
                        Console.Write("Price for this Ride is : " + ride.Price);
                        Console.WriteLine("\nEnter 'Y' if you want to book the ride , ENter" +
                            " 'N' if you want to cancel the operation : ");
                        ch = char.Parse(Console.ReadLine());

                        if (ch == 'y' || ch == 'Y')
                        {
                            ride.assignDriver(ad);

                        }
                        else
                        {
                            Console.WriteLine("Thanks For using our APP ");
                        }
                        ans = true;
                        int a = 0;
                        Console.WriteLine("\n\n \t\t\t\t\t\t 1.Return to main menue \n" +
                       "  2. exit \n");
                        a = System.Convert.ToInt32(Console.ReadLine());
                        if (a == 2)
                            Environment.Exit(0);
                        break;
                    case 2:
                        Console.WriteLine("Enter Id : ");
                        string d = Console.ReadLine();
                        Console.WriteLine("Enter Name : ");
                        string n = Console.ReadLine();
                        bool reg = false;
                        foreach (Driver driver in ad.Drivers)
                        {
                            if (driver.ID == d && driver.Name == n)
                            {
                                reg = true;
                                Console.WriteLine("Hello " + n + " !");
                                driver.updateLocation(1);
                                Console.WriteLine("\n\n");
                                Console.WriteLine(" 1. Change Availibility ");
                                Console.WriteLine(" 2. Change Location ");
                                int chk;
                                Console.WriteLine("Enter your choice : ");
                                chk = System.Convert.ToInt32(Console.ReadLine());
                                switch (chk)
                                {
                                    case 1:
                                        driver.updateAvailibility();
                                        break;
                                    case 2:
                                        driver.updateLocation(0);
                                        break;
                                }
                                mng.updateDriver(driver,d);
                                break;
                            }
                        }

                       
                        if (reg == false)
                        {

                            Console.WriteLine("Sorry ! Driver is not registered ");
                        }
                        int ay = 0;
                        Console.WriteLine("\n\n \t\t\t\t\t\t 1.Return to main menue \n" +
                       "  2. exit \n");
                        ay = System.Convert.ToInt32(Console.ReadLine());
                        if (ay == 2)
                            Environment.Exit(0);
                        ans = true;
                        break;
                    case 3:
                        bool main = true;
                        while (main)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n\n\n\n\n");
                            Console.WriteLine("\t\t\t\t---------------------------------------------");
                            Console.WriteLine("\n\t\t\t\t|          1. Add Driver                   |");
                            Console.WriteLine("\t\t\t\t|           2. Remove Driver               | ");
                            Console.WriteLine("\t\t\t\t|           3. Update Driver               |");
                            Console.WriteLine("\t\t\t\t|           4. Search Driver               |");
                            Console.WriteLine("\t\t\t\t|           5. Exit as Admin Driver        |");
                            Console.WriteLine("\n\t\t\t\t|            Enter your choice             |");
                            Console.WriteLine("\t\t\t\t---------------------------------------------");
                            Console.Write("\t\t\t\t\t");
                            choice = System.Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.Clear();
                                    ad.addDriver();
                                    int at = 0;
                                    Console.WriteLine("\n\n \t\t\t\t\t\t 1.Return to main menue \n" +
                                   " \t\t\t\t\t\t 2. Return to admin \n \t\t\t\t\t\t 3. Exit");
                                    at = System.Convert.ToInt32(Console.ReadLine());
                                    if (at == 3)
                                        Environment.Exit(0);
                                    else if (at == 1)
                                    {
                                        main = false;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    ad.RemoveDriver();
                                    int ab = 0;
                                    Console.WriteLine("\n\n \t\t\t\t\t\t 1.Return to main menue \n" +
                                   " \t\t\t\t\t\t 2. Return to admin \n \t\t\t\t\t\t 3. Exit");
                                    ab = System.Convert.ToInt32(Console.ReadLine());
                                    if (ab == 3)
                                        Environment.Exit(0);
                                    else if (ab == 1)
                                    {
                                        main = false;
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    ad.updateDriver();
                                    int ac = 0;
                                    Console.WriteLine("\n\n \t\t\t\t\t\t 1.Return to main menue \n" +
                                   " \t\t\t\t\t\t 2. Return to admin \n \t\t\t\t\t\t 3. Exit");
                                    ac = System.Convert.ToInt32(Console.ReadLine());
                                    if (ac == 3)
                                        Environment.Exit(0);
                                    else if (ac == 1)
                                    {
                                        main = false;
                                    }
                                    break;
                                case 4:
                                    Console.Clear();
                                    ad.searchDriver();
                                    int ae = 0;
                                    Console.WriteLine("\n\n \t\t\t\t\t\t 1.Return to main menue \n" +
                                   " \t\t\t\t\t\t 2. Return to admin \n \t\t\t\t\t\t 3. Exit");
                                    ae = System.Convert.ToInt32(Console.ReadLine());
                                    if (ae == 3)
                                        Environment.Exit(0);
                                    else if (ae == 1)
                                    {
                                        main = false;
                                    }
                                    break;
                                case 5:
                                    main = false;
                                    break;
                            }

                        }
                        break;
                    case 4:

                        Console.WriteLine("Thanks For using our APP ");
                        Environment.Exit(0);
                        break;

                }
            }
        
    }
    }
}
