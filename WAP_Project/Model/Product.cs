using System;
using System.Collections.Generic;
using System.Text;

namespace WAP_Project.Model
{
    internal class Product
    {
        public Product(long productId, long departmentId, string name, string description, float price)
        {
            ProductId = productId;
            DepartmentId = departmentId;
            Name = name;
            Description = description;
            Price = price;
        }

        public long ProductId {  get; set; }
        public long DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
