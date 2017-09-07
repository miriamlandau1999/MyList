using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_24
{
    class PersonEqualityComparer: ISimpleComparer
    {
        public bool AreEqual(object a, object b)
        {
    
            Person p1 = (Person) a;
            Person p2 = (Person) b;
            if (p1.FirstName != p2.FirstName)
            {
                return false;
            }
            if (p1.LastName != p2.LastName)
            {
                return false;
            }
            if (p1.Age != p2.Age)
            {
                return false;
            }
            return true; 
        }
    }
}
