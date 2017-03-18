using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Common.Constants;
using OnLineShop.Data.Models.Contracts;

namespace OnLineShop.Data.Models
{
    public class OrderDetail : IDbModel
    {
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int ProductId { get; set; }

        [Required]
        [Range(
           ValidationConstants.QuantityMinValue,
           ValidationConstants.QuantitiMaxValue,
           ErrorMessage = ValidationConstants.QuаntityOutOfRangeErrorMessage)]
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public bool IsDeleted { get; set; }
    }
}
