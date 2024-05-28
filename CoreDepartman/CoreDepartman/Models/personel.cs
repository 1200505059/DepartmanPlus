using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
	public class personel
	{
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sehir { get; set; }
        public departmanlar department { get; set; }
        public int departmentid { get; set; }
    }
}
