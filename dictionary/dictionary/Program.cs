using System;
using System.Collections;
using System.Collections.Generic;

namespace dictionaryCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            customer customer1 = new customer() { ID = 100, Name = "Ana", Salary = 4000 };
            customer customer2 = new customer() { ID = 101, Name = "Harry", Salary = 1200 };
            customer customer3 = new customer();
            customer3.ID = 103;
            customer3.Name = "sania";
            customer3.Salary = 3000;

            // Dictionary<string, int> dictcust = new Dictionary<string, int>();
            // dictcust.Add(customer1.Name, customer1.ID);  
            //Adding customer objects to Dictionary

            Dictionary<int,customer> dictcust = new Dictionary<int,customer>();
            dictcust.Add(customer1.ID, customer1);
            dictcust.Add(customer2.ID, customer2);
            dictcust.Add(customer3.ID, customer3);

            
            customer cust100= dictcust[100];
            //customer cust100 = dictcust[customer1.ID];

            Console.WriteLine("ID :{0} , Name :{1}, Salary :{2}", customer1.ID, customer1.Name, customer1.Salary);

            foreach(KeyValuePair<int,customer> kvp in dictcust)
            {
                Console.WriteLine("key:{0}" , kvp.Key);
                customer cust = kvp.Value;
                Console.WriteLine("ID :{0},Name : {1},Salary :{2}",cust.ID,cust.Name,cust.Salary);

            }
            foreach (int kvp in dictcust.Keys)
            {
                Console.WriteLine("key:{0}", kvp);

            }
            foreach (customer kvp in dictcust.Values)
            {
                Console.WriteLine("ID :{0},Name : {1},Salary :{2}", kvp.ID, kvp.Name, kvp.Salary);

            }

            Console.ReadLine();


            ////////////////HASH TABLE
            ///

            Hashtable hash1 = new Hashtable();
            hash1.Add(1 , 4);
            hash1.Add(2 , 7);
            hash1.Add(3, "a");
            hash1.Add(7, "c#");

            ICollection store = hash1.Keys;

            foreach(var item in store )
            {
                Console.Write(item + "-" + hash1[item]);
            }











        }





    }

    public class customer                 //customer class 
    {
        public int ID { get; set; }       // class Properties
        public string Name { get; set; }
        public int Salary { get; set; }   
    }
}
