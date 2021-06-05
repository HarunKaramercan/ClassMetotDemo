using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            Customer Customer1 = new Customer();
            Customer1.Id = "1";
            Customer1.Name = "Sinan";
            Customer1.Surname = "Özoğlu";
            Customer1.City = "İstanbul";
            Customer Customer2 = new Customer();
            Customer2.Id = "2";
            Customer2.Name = "Sema";
            Customer2.Surname = "Kaçan";
            Customer2.City = "Ankara";
            Customer Customer3 = new Customer();
            Customer3.Id = "3";
            Customer3.Name = "Kemal";
            Customer3.Surname = "Boyarslan";
            Customer3.City = "Manisa";

            Customer[] c1 = new Customer[] { Customer1 };
            CustomerManager Cust = new CustomerManager();
            Cust.Add(Customer1);
            Cust.List(c1);
            Cust.Delete(Customer1);


            Customer[] c2 = new Customer[] { Customer2 };
            CustomerManager Cust2 = new CustomerManager();
            Cust2.Add(Customer2);
            Cust2.List(c2);
            Cust2.Delete(Customer2);

            Customer[] c3 = new Customer[] { Customer3 };
            CustomerManager Cust3 = new CustomerManager();
            Cust2.Add(Customer3);
            Cust2.List(c3);
            Cust2.Delete(Customer3);



        }
    }
}
