using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiForTraining.Model
{
    public class User
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public int Age { get; set; }
        public String Location { get; set; }
    }
}
