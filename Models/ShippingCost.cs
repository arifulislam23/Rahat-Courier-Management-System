using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ShippingCost
    {
        public int Id { get; set; }
        [DisplayName("Shipping Cost")]
        public decimal Cost { get; set; }
        [ForeignKey("PercelType")]
        public int PercelTypeId { get; set; }
        public PercelTypesModel? PercelType { get; set; }
    }
}
