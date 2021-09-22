using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Zoo.Models
{
    public class News
    {
        public int id { get; set; }
        public string title { get; set; }
        public string descri { get; set; }
    
       public News()
        {

        }
        public News(int id, string title, string descri)
        {
            this.id = id;
            this.title = title;
            this.descri = descri;
        }
    }

   
}
