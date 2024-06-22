using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Core_Proje_1.Models
{
    public class personel
    {
        [Key]
        public int perid { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [StringLength(30)]
        public string ad { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [StringLength(30)]
        public string soyad { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string sehir { get; set; }

        public int departid { get; set; }
    }
}
