using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{

	public class departmanlar
	{
        [Key]
        public int id { get; set; }
        public string departmanAd { get; set; }
        public string Aciklama { get; set; }

        public List<personel> personels { get; set; }
    }
}
