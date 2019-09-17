using System;
using System.Collections.Generic;
using System.Text;

namespace TecajAPI
{
    public class RootObject
    {
        public Rates rates { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
    }
}
