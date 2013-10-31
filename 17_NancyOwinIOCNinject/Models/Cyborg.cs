using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyOwinIOCNinject
{
    public class Cyborg : IPerson
    {
        private string _idNumber;
        private string _creationDate;

        public Cyborg(string idNumber, string creationDate)
        {
            _idNumber     = idNumber;
            _creationDate = creationDate;
        }

        public string Name
        {
            get { return _idNumber; }
        }

        public string Birthday
        {
            get { return _creationDate; }
        }
    }
}