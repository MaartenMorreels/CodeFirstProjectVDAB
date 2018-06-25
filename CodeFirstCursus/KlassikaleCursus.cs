using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    public class KlassikaleCursus : Cursus
    {
        [Column(TypeName="date")]
        public DateTime StartDatum { get; set; }
        [Column(TypeName = "date")]
        public DateTime EindDatum { get; set; }
    }
}
