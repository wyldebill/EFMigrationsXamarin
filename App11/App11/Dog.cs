using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App11
{
    public class Dog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string NEWPROPERTYVIAMIGRATE { get; set; }

        public string ANOTHERNEWPROP { get; set; }
    }
}
