using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_24
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleList MyList = new SimpleList(new PersonEqualityComparer());
            Person p1 = new Person { FirstName = "Leah'le", LastName = "Lefkowitz", Age = 19 };
            Person p2 = new Person { FirstName = "Miriam", LastName = "Landau", Age = 17 };
            Person p3 = new Person { FirstName = "Gitty", LastName = "Landau", Age = 12 };
            Person p4 = new Person { FirstName = "Sury", LastName = "Landau", Age = 9 };
            Person p5 = new Person { FirstName = "Miriam", LastName = "Landau", Age = 17 };
            Person p6 = new Person { FirstName = "Miriam", LastName = "Landau", Age = 17 };
            Person p7 = new Person { FirstName = "Miriam", LastName = "Landau", Age = 17 };
            Person p8 = new Person { FirstName = "Henchy", LastName = "Landau", Age = 1 };
            Person p9 = new Person { FirstName = "Menachem", LastName = "Lefkowitz", Age = 23 };
            MyList.Add(p9);
            MyList.Add(p1);
            MyList.Add(p2);
            MyList.Add(p3);
            MyList.Add(p4);
            MyList.Add(p5);
            MyList.Add(p6);
            MyList.Add(p7);
            MyList.Add(p8);
            MyList.PrintList();
            Console.ReadKey(true);
        }  
    }
}
