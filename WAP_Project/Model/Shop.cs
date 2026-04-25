using System;
using System.Collections.Generic;
using System.Text;
using WAP_Project.Exceptions;

namespace WAP_Project.Model
{
    public class Shop
    {
        public Shop(long shopId, string name, string address, string manager)
        {
            ShopId = shopId;
            Name = name;
            Address = address;
            //DepartmentList = departmentList;
            Manager = manager;
        }

        public long ShopId { get; set; }
        public String Name { get; set; }
        private string _address;
        public String Address { get 
            {
                return _address;
            } 
            set 
            {
                if (!value.Contains(","))
                {
                    throw new InvalidAddressException(value);

                }
                _address = value;
            } 
        }
        public String Manager { get; set; }
        //public List<Department> DepartmentList { get; set; } = new List<Department>();
    }
}
