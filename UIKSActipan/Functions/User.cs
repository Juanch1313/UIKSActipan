using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIKSActipan.Functions
{
    public class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastNames { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string position { get; set; }

        public User() { }

        public User(int id, string first, string last, string user, string pass, string position)
        {
            this.id = id;
            this.firstName = first;
            this.lastNames = last;
            this.user = user;
            this.password = pass;
            this.position = position;
        }
    }
}
