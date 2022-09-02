using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace MvcDatabinding.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Implement the code here
            Product student = new Product();
            Program p = new Program();
            p.AddStudent(student);
        }

        public void AddStudent(Product student)
        { //Do not change the method signature

            //Add the student details to database.

            student.ProductId = 4;
            student.Name = "alan";
            student.Price = 1000;
            

            ProductsContext clc = new ProductsContext();

            clc.ProductsTable.Add(student);
            clc.SaveChanges();

        }

    }
}