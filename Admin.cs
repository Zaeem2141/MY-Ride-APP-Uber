using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLib;
using DriverManager;

namespace ALib
{
    public class Admin
    {
        List<Driver> drivers;
        DManager mg;
        int lastid;

        public Admin()
        {
            drivers = new List<Driver>();
            mg = new DManager();
           drivers = mg.readDrivers();
            lastid = (int.Parse(mg.LastID));
        }

        public List<Driver> Drivers
        {
            set { drivers = value; }
            get { return drivers; }
        }
        public void addDriver()
        {
            Driver driver = new Driver();
            Console.WriteLine("Enter the following details of the driver : \n\n");
            lastid++;
            driver.ID = Convert.ToString(lastid);
            Console.Write("Enter Name : ");
            driver.Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            driver.Age = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Gender : ");
            driver.Gender = Console.ReadLine();
            Console.Write("Enter Address : ");
            driver.Address = Console.ReadLine();
            Console.Write("Enter Vehicle Type : ");
            driver.setLType = Console.ReadLine();
            Console.Write("Enter Vehicle Model : ");
            driver.setMType = Console.ReadLine();
            Console.Write("Enter Vehicle License Plate : ");
            driver.setVType = Console.ReadLine();

            Console.WriteLine("Thanks for registering \n\n");
            mg.SaveDriver(driver);
            drivers.Add(driver);
        }
        public void updateDriver()
        {
            Console.WriteLine("Enter Id : ");
            string d = Console.ReadLine();
            string id = "", na = "", ge = "", ad = "", ty = "", mo = "", li = "";
            int ag = 0;
            foreach (Driver driver in drivers)
            {
                if (driver.ID == d)
                {
                    Console.WriteLine("\n--------- Driver with ID " + d + " Exists---------");
                    Console.WriteLine("Enter the following details of the driver : \n\n");

                    Console.Write("Enter Name : ");
                    na = Console.ReadLine();
                    if (na != "")
                    {
                        driver.Name = na;
                    }
                    Console.Write("Enter Age : ");
                    ge = Console.ReadLine();
                    if (ge != "")
                        ag = System.Convert.ToInt32(ge);
                    if (ag != 0)
                    {
                        driver.Age = ag;
                    }
                    ge = "";
                    Console.Write("Enter Gender : ");
                    ge = Console.ReadLine();
                    if (ge != "")
                    {
                        driver.Gender = ge;
                    }
                    Console.Write("Enter Address : ");
                    ad = Console.ReadLine();
                    if (ad != "")
                    {
                        driver.Address = ad;
                    }
                    Console.Write("Enter Vehicle Type : ");
                    ty = Console.ReadLine();
                    if (ty != "")
                    {
                        driver.setVType = ty;
                    }
                    Console.Write("Enter Vehicle Model : ");
                    mo = Console.ReadLine();
                    if (mo != "")
                    {
                        driver.setMType = mo;
                    }

                    Console.Write("Enter Vehicle License Plate : ");
                    li = Console.ReadLine();
                    if (li != "")
                    {
                        driver.setLType = li;
                    }
                    mg.updateDriver(driver, d);
                    break;
                }
            }
           
           
        }
        public void RemoveDriver()
        {
            Console.WriteLine("Enter Id : ");
            string d = Console.ReadLine();
            foreach (Driver driver in drivers)
            {
                if (driver.ID == d)
                {
                    drivers.Remove(driver);
                    break;
                }
            }
            mg.removeDriver(d);
            Console.WriteLine("\n Congratulations! its removed ");
        }
        public void searchDriver()
        {
            string id = "", na = "", ge = "", ad = "", ty = "", mo = "", li = "";
            int ag = 0;
            Console.WriteLine("Enter the following details of the driver : \n\n");
            Console.Write("Enter ID : ");
            id = Console.ReadLine();
            Console.Write("Enter Name : ");
            na = Console.ReadLine();
            Console.Write("Enter Age : ");
            ge = Console.ReadLine();
            if (ge != "")
                ag = System.Convert.ToInt32(ge);
            Console.Write("Enter Gender : ");
            ge = Console.ReadLine();
            Console.Write("Enter Address : ");
            ad = Console.ReadLine();
            Console.Write("Enter Vehicle Type : ");
            ty = Console.ReadLine();
            Console.Write("Enter Vehicle Model : ");
            mo = Console.ReadLine();
            Console.Write("Enter Vehicle License Plate : ");
            li = Console.ReadLine();
            int a = 0;
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Name         Age          Gender          V.Type           V.Model           V.License ");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            foreach (Driver driver in drivers)
            {

                if (driver.ID == id)
                {
                    a++;
                    
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (driver.Name == na)
                {
                    a++;
                    
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (driver.Gender == ge)
                {
                    a++;
                    
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (driver.Name == na)
                {
                    a++;
                    
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (driver.Age == ag)
                {
                    a++;
                    
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (driver.Address == ad)
                {
                    a++;
                    
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (driver.gettype() == ty)
                {
                    a++;
                    
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (driver.getMod() == mo)
                {
                    a++;
                   
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (driver.getLic() == li)
                {
                    a++;
    
                    Console.WriteLine(driver.Name + "           " + driver.Age + "            " + driver.Gender + "      "
                        + driver.gettype() + "            " + driver.getMod() + "           " + driver.getLic());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
            }

            if (a == 0) Console.WriteLine("No such driver exist");
        }
    }
}
