using System;
using System.Collections.Generic;
using System.Text;

namespace WAP_Project.Model
{
    internal class Shop
    {
        public Shop(long shopId, string name, string address, List<Department> departmentList)
        {
            ShopId = shopId;
            Name = name;
            Address = address;
            DepartmentList = departmentList;
        }

        public long ShopId { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public List<Department> DepartmentList { get; set; } = new List<Department>();
    }
}
