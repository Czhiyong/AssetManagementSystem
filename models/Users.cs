using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    public class Users
    {
        public virtual int id{get;set;}
        public virtual string name { get; set; }
        public virtual string role { get; set; }
        public virtual int password { get; set; }
        public virtual string email { get; set; }
    }
}
