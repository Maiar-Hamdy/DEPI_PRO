using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mailo.Data.Enums;

namespace Mailo.Models
{
	public class Payment
	{
		[Key]
		public int ID { get; set; }
        [DisplayName("Payment Date")]
        public DateTime PaymentDate { get; set; }
        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; }
		[DisplayName("Payment Method")]
		[EnumDataType(typeof(PaymentMethod))]
		public PaymentMethod PaymentMethod { get; set; }
        [DisplayName("Payment Status")]
        [EnumDataType(typeof(PaymentStatus))]
		public PaymentStatus PaymentStatus { get; set; }
		[ForeignKey("user")]
		public int UserID { get; set; }
		public User user { get; set; }
        [ForeignKey("order")]
        public int OrderID { get; set; }
        public virtual Order order { get; set; }
    } 
}
