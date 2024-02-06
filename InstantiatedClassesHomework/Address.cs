using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassesHomework
{
    public class Address
    {
        public string StreetName => _streetName;
        public int StreetNumber => _streetNumber;

        string _streetName;
        int _streetNumber;

        public Address(string streetName, int streetNumber) 
        {
            _streetName = streetName;
            _streetNumber = streetNumber;
        }
    }
}
