using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SetupMVC.Models
{
    public class PersonModel
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } = 0;
        public bool IsAliva { get; set; } = true;
    }
}