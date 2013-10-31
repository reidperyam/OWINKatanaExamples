using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyOwinIOCNinject
{
    public class Person : IPerson
    {
        private string _name;
        private string _birthday;

        public Person(string name, string birthday)
        {
            _name     = name;
            _birthday = birthday;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Birthday
        {
            get { return _birthday; }
        }
    }
}