using System;
using System.Collections.Generic;
using System.Text;

namespace WAP_Project.Exceptions
{
    internal class InvalidAddressException : Exception
    {
        public InvalidAddressException(string address)
        {
            Address = address;
        }

        public string Address {  get; set; }

        public override string Message 
        { get 
            {  
                return "Address" + Address + "is invalid."; 
            }  
        }
    }
}
