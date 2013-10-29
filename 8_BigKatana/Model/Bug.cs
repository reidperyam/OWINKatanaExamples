using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigKatana.Model
{
    public class Bug
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string state { get; set; }
    }
}