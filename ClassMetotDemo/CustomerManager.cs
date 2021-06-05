using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void List(Customer[] Customers)
        {
            foreach (var list in Customers)
            {
                Console.WriteLine("\nCustomer Id :" + list.Id+"\nName :"+ list.Name+ "\nSurname :" + list.Surname+ "\nCity :" + list.City);
                Console.WriteLine("Customer Listed");
            }
        }
        public void Add(Customer csadd)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Customer Added Id "+csadd.Id);
        }
        public void Delete(Customer csdelete)
        {
            Console.WriteLine("Customer Deleted Id "+csdelete.Id);
        }
    }
}
