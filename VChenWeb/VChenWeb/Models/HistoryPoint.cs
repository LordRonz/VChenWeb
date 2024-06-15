using System.ComponentModel.DataAnnotations;

namespace VChenWeb.Models
{
    public class HistoryPoint
    {
        [Key]
        public DateTime? TGFAK { get; set; }
        public string? NOMBR { get; set; }
        public int? POINT { get; set; }
    }
}
