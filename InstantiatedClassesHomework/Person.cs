using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassesHomework
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Person
    {
        public string Name => _name;
        public int Age => _age;
        public Gender Gender => _gender;
        public Address Address => _address;

        string _name;
        int _age;
        Gender _gender;
        Address _address;

        public Person(string name, int age, Gender gender, Address address) 
        {
            _name = name;
            _age = age;
            _gender = gender;
            _address = address;
        }

        public void MakeASpeech() 
        {
            Console.WriteLine($@"Hi, my name is {_name}!
I'm {_age} years old.
My gender is {_gender.ToString()}.
I live on a {_address.StreetName} {_address.StreetNumber} street.");
        }
    }
}
