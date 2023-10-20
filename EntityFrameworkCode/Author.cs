using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LechuRestSharp.EntityFrameworkCode
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AuthorName { get; set; }
    }
}
