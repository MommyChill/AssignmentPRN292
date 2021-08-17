using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Product
    {
        private string pid, pname;
        private int quantity;
        private double price;
        private string image, description;
        // chú ý giá trị trả về của kiểu bit trong ODA là true/false
        // không phải là 1,0 như java
        private bool status;
        private int cateID;

        public Product(string pid, string pname, int quantity, double price, string image, string description, bool status, int cateID)
        {
            this.pid = pid;
            this.pname = pname;
            this.quantity = quantity;
            this.price = price;
            this.image = image;
            this.description = description;
            this.status = status;
            this.cateID = cateID;
        }

        public string Pid { get => pid; set => pid = value; }
        public string Pname { get => pname; set => pname = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        public bool Status { get => status; set => status = value; }
        public int CateID { get => cateID; set => cateID = value; }

    }
}
