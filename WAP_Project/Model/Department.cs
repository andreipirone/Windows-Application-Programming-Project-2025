using System;
using System.Collections.Generic;
using System.Text;

namespace WAP_Project.Model
{
    internal class Department
    {
        public Department(long departmentId, long shopId, string name, string description, string mangaer, List<Sale> saleList)
        {
            DepartmentId = departmentId;
            ShopId = shopId;
            Name = name;
            Description = description;
            Mangaer = mangaer;
            SaleList = saleList;
        }

        public long DepartmentId { get; set; }
        public long ShopId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mangaer { get; set; }
        List<Sale> SaleList { get; set; } = new List<Sale>();
    }
}
