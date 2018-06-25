using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    [ComplexType]
    public class Address
    {
        [StringLength(80)]
        [Column("Straat")]
        public string Straat { get; set; }
        [StringLength(5)]
        [Column("Huisnr")]
        public string HuisNr { get; set; }
        [StringLength(10)]
        [Column("Postcode")]
        public string PostCode { get; set; }
        [StringLength(80)]
        [Column("Gemeente")]
        public string Gemeente { get; set; }
    }
}
