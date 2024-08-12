using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerables
{
    internal class Employee : IEnumerable<PayItems>
    {
        public string Name { get; set; }
  
        private readonly List<PayItems> _Payitems = new();
        private bool disposedValue;

        public void AddPay1item(string name, int value)
        {
            _Payitems.Add(new PayItems { name = name, value = value });
        }

        public IEnumerator<PayItems> GetEnumerator()
        {
            Console.WriteLine("Getienemerator  Called");
            foreach (var item in _Payitems) 
                yield return item;

        }
        public IEnumerator<PayItems> GetPayItems()
        {

            Console.WriteLine("GetPayItems Called");
            return _Payitems.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
