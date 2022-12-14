using System.ComponentModel.DataAnnotations;

namespace AngularNetCrud
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; } = String.Empty;

    }
}
