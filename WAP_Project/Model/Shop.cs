using System;
using System.Collections.Generic;
using System.Text;
using WAP_Project.Exceptions;

namespace WAP_Project.Model
{
    internal class Shop
    {
        public Shop(long shopId, string name, string address, string manager, List<Department> departmentList)
        {
            ShopId = shopId;
            Name = name;
            Address = address;
            DepartmentList = departmentList;
            Manager = manager;
        }

        public long ShopId { get; set; }
        public String Name { get; set; }
        public String Address { get 
            {
                return Address;
            } 
            set 
            {
                if (!value.Contains(","))
                {
                    throw new InvalidAddressException(value);

                }
                Address = value;
            } 
        }
        public String Manager { get; set; }
        public List<Department> DepartmentList { get; set; } = new List<Department>();
    }
}
