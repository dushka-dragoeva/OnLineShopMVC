using OnLineShop.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnLineShop.Data.Models
{
    public class Order:IDbModel
    {
        private IEnumerable<OrderDetail> orderDetails;

        public Order()
        {
            this.orderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual User User { get; set; }
       
        public decimal TotalAmount { get; set; }

        public bool HasBeenConfirmed { get; set; }

        public bool HasBeenShipped { get; set; }

        public bool HasBeenClosed { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails
        {
            get
            {
                return this.orderDetails;
            }
            set
            {
                this.orderDetails = value;
            }
        }

        public bool IsDeleted { get; set; }
    }
}
