using System;

namespace NancyOwinTutorial
{
    public class CarNotFoundException : Exception
    {
        public CarNotFoundException(string message) : base(message) { }
    }
}