using System.ComponentModel;

namespace Models
{
    public class PercelTypesModel
    {
        public int Id { get; set; }
        [DisplayName("Percel Type Name")]
        public string TypeName { get; set; }

    }
}
