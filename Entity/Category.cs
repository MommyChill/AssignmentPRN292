using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Category
    {
        public int cateID { get; set; }
        public string cateName { get; set; }
        
        public bool status { get; set; }

        public Category(int cateID, string cateName, bool status)
        {
            this.cateID = cateID;
            this.cateName = cateName;
            this.status = status;
        }

        public Category()
        {
        }
    }
}
