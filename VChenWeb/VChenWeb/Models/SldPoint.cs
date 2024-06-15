using System.ComponentModel.DataAnnotations;

namespace VChenWeb.Models
{
    public class SldPoint
    {
        [Key]
        public string? NOMBR { get; set; }
        public int? POINT { get; set; }
    }
}
