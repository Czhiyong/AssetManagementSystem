using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
namespace models
{
    public class Text
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }

        
    }
}
