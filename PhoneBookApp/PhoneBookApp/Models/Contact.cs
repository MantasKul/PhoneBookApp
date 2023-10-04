﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Models
{
    public class Contact
    {
        public Contact() { }

        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
