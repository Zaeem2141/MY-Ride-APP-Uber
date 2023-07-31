using System;
using System.Collections.Generic;
using System.IO;
using DLib;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace DriverManager
{
    public class DManager
    {
        string lastId="0";

        public string LastID
        {
            set { lastId = value; }
            get { return lastId; }
        }
        public List<Driver> readDrivers()
        {
            List<Driver> list = new List<Driver>();
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Drivers;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection conn = new SqlConnection(conString);
            string select = $"select * from Driver";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
                Driver driver = new Driver();
                int a= reader.GetInt32(0);
                LastID = Convert.ToString(a);
                driver.ID = LastID;
                driver.Name = reader.GetString(1);
                driver.Age = reader.GetInt32(2);
                driver.Gender = reader.GetString(3);
                driver.Address = reader.GetString(4);
                driver.setVType=reader.GetString(5);
                driver.setMType=reader.GetString(6);
                driver.setLType=reader.GetString(7);
                driver.setLat = float.Parse(reader["Latitude"].ToString());
                driver.setLong = float.Parse(reader["Longitude"].ToString());
                driver.Availibility = bool.Parse(reader["Availibility"].ToString());
                list.Add(driver);
                
            }
            conn.Close();
            return list;



        }
          
        public void SaveDriver(Driver driver)
        {
    string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Drivers;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    SqlConnection conn = new SqlConnection(conString);
            int bit = 0;
            if (driver.Availibility == true)
                bit = 1;
            string insert = $"insert into Driver(Name,Age,Gender,Address,VehicleType,VehicleModel,VehicleLicense,Latitude,Longitude,Availibility) values ('{driver.Name}','{driver.Age}','{driver.Gender}','{driver.Address}','{driver.gettype()}','{driver.getMod()}','{driver.getLic()}','{driver.getLat()}','{driver.getLong()}','{bit}')";
            SqlCommand cmd = new SqlCommand(insert, conn);
    conn.Open();
    int insertedRow = cmd.ExecuteNonQuery();
    if (insertedRow >= 1)
        Console.WriteLine("Driver Registered!");
    else
        Console.WriteLine("Driver Not Registered!");
    conn.Close();
         }

        public void updateDriver(Driver driver , string id)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Drivers;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            int a = int.Parse(id);
            string update = $"update Driver set  Name='{driver.Name}',Age='{driver.Age}',Gender='{driver.Gender}',address='{driver.Address}',VehicleType='{driver.gettype()}',VehicleModel='{driver.getMod()}',VehicleLicense='{driver.getLic()}',Latitude='{driver.getLat()}',Longitude='{driver.getLong()}', Availibility='{driver.Availibility}' where Id={a}";
            SqlCommand cmd = new SqlCommand(update, conn);
            conn.Open();
            int insertedRow = cmd.ExecuteNonQuery();
            if (insertedRow >= 1)
                Console.WriteLine("Driver updated!");
            else
                Console.WriteLine("Driver not updated!");
            conn.Close();
        }

        public void removeDriver(string id)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Drivers;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            int a = int.Parse(id);
            string update = $"delete from Driver where id={a}";
            SqlCommand cmd = new SqlCommand(update, conn);
            conn.Open();
            int insertedRow = cmd.ExecuteNonQuery();
            if (insertedRow >= 1)
                Console.WriteLine("Driver Removed!");
            else
                Console.WriteLine("Driver not Removed!");
            conn.Close();
        }
    }
}
