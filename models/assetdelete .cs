using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    public class assetdelete
    {
         public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string safedepartment { get; set; }
        public virtual string deleteperson { get; set; }
        public virtual string deletedate { get; set; }
        public virtual string type { get; set; }
    }
}
