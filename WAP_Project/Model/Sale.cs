using System;
using System.Collections.Generic;
using System.Text;

namespace WAP_Project.Model
{
    internal enum Payment
    {
        Cash,
        Card
    }

    internal class Sale
    {
        public Sale(long transactionID, long shopId, long departmentId, DateTime time, float amount, Payment paymentType, List<Product> productList)
        {
            TransactionID = transactionID;
            ShopId = shopId;
            DepartmentId = departmentId;
            Time = time;
            Amount = amount;
            PaymentType = paymentType;
            this.productList = productList;
        }

        public long TransactionID {  get; set; }
        public long ShopId {  get; set; }
        public long DepartmentId { get; set; }
        public DateTime Time {  get; set; }
        public float Amount { get; set; }
        public Payment PaymentType { get; set; }
        public List<Product> productList { get; set; } = new List<Product>();

        


    }
}
