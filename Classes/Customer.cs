﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        public int ID { get; set; }
        string _firstName;
        public string FirstName
        {
            get
            { return "Mr. " + _firstName; }
            set
            { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
