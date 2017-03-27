using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Common.Constants;
using OnLineShop.Data.Models.Contracts;
using System;

namespace OnLineShop.Data.Models
{
    public class OrderDetail : IDbModel
    {
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [ForeignKey("Size")]
        public int? SizeId { get; set; }

        public virtual Size Size { get; set; }

        [Required]
        [Range(
           ValidationConstants.QuantityMinValue,
           ValidationConstants.QuantityMaxValue,
           ErrorMessage = ValidationConstants.QuаntityOutOfRangeErrorMessage)]
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal SubTotal { get; set; }

        public DateTime OrderedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
