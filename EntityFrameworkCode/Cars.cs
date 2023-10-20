using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LechuRestSharp.EntityFrameworkCode
{
    [Table("Cars")]
    internal class Cars
    {
        [Key]
        public int Id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string fuel_type { get; set; }

    }
}
