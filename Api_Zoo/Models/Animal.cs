using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Zoo.Models
{
    public class Animal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string classname { get; set; }
        public string descri { get; set; }
        public Animal()
        {

        }
        public Animal(int id, string name, string classname, string descri)
        {
            this.id = id;
            this.name = name;
            this.classname = classname;
            this.descri = descri;
        }
    }
}
