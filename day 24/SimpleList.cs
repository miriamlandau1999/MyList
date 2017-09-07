using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_24
{
    class SimpleList
    {
        private int _index = 0;
        private object[] _array = new object[8];
        private ISimpleComparer _comparer;
        public SimpleList(ISimpleComparer comparer)
        {
            _comparer = comparer;
        }
        public bool Add(object o)
        {
            for (int i = 0; i < _index; i++)
            {
                if (_comparer.AreEqual(_array[i], o))
                {
                    return false;
                }
            }
            _array[_index] = o;
            _index++;
            TestIfFull();
            return true;
        }
        public object Get(int index)
        {
            return _array[index];
        }
        public int Count()
        {
            return _index;
        }
        private void CreateDoubleArray()
        {
            object[] temp = new object[_array.Length *2];
            for (int i = 0; i < _array.Length; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        private void TestIfFull()
        {
            if (_index == _array.Length)
            {
                CreateDoubleArray();
            }
        }
        public void PrintList()
        {
            foreach(object o in _array)
            {
                Console.WriteLine(o);
            }
        }
    }
}
