using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Zoo.Models
{
    public class Zoo
    {
        public int id { get; set; }
        public string name { get; set; }

        public string descri { get; set; }

        public string hour { get; set; }

        public Zoo()
        {

        }
        public Zoo(int id, string name, string descri, string hour)
        {
            this.id = id;
            this.name = name;
            this.descri = descri;
            this.hour = hour;
        }
    }
}
