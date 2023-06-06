using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager();

            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine("Id : " + item.Id + " Category Name :  " + item.CategoryName);
              
            }
            Console.Read();
        }
    }
}
