using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
   public class assetimformation
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string buydate { get; set; }
        public virtual string sort { get; set; }
        public virtual int amount { get; set; }
        public virtual int price { get; set; }
        public virtual string safedepartment { get; set; }
        public virtual string safeplace { get; set; }
        public virtual string usedepatment { get; set; }
        public virtual string depreciation { get; set; }
    }
}
