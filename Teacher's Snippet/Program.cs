using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_s_Snippet
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSet set = new SimpleSet(new PersonComparer());
            Person p1 = new Person { Name = "Avrumi", Age = 35 };
            Person p2 = new Person { Name = "Avrumi", Age = 35 };


            set.Add(p1);
            set.Add(p2);

            for (int i = 0; i < set.Count; i++)
            {
                object o = set.Get(i);
                Console.WriteLine(o);
            }

            Console.ReadKey(true);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }

    public interface ISimpleEqualityComparer
    {
        bool AreEqual(object x, object y);
    }

    public class PersonComparer : ISimpleEqualityComparer
    {
        public bool AreEqual(object x, object y)
        {
            Person p1 = (Person)x;
            Person p2 = (Person)y;
            return p1.Name == p2.Name && p1.Age == p2.Age;
        }
    }

    public class SimpleSet
    {
        private object[] _array = new object[8];
        private int _index = 0;
        private ISimpleEqualityComparer _comparer;
        public SimpleSet(ISimpleEqualityComparer comparer)
        {
            _comparer = comparer;
        }

        public bool Add(object x)
        {
            for (int i = 0; i < _index; i++)
            {
                //if (_array[i] == x)
                if (_comparer.AreEqual(_array[i], x))
                {
                    return false;
                }
            }

            _array[_index] = x;
            _index++;

            return true;
        }

        public int Count
        {
            get { return _index; }
        }

        public object Get(int index)
        {
            return _array[index];
        }
    }
}

