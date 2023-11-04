using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ConsignmentNumber { get; set; } = ConsignmentNumberGenerator.GenerateRandomString(6);
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerPhoneNumber { get; set; }
        [Required]
        public string RecipientName { get; set; }
        [Required]
        public string RecipientAddress { get; set; }
        [Required]
        public string RecipientPhoneNumber { get; set; }
        [ForeignKey("PercelTypes")]
        public int PercelTypeId { get; set; }
        public PercelTypesModel? PercelTypes { get; set; }

        [ForeignKey("ShippingCosts")]
        public int ShippingCostId { get; set; }
        public ShippingCost? ShippingCosts { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
    }
    public static class ConsignmentNumberGenerator
    {
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCD123456789";
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, length)
               .Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }
    }
}
