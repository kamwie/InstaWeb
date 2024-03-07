using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstaWeb.Infrastructure.DAL.Entities
{
    class DriverEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DriverId { get; set; }
        public string Name  { get; set; }
        public string Surname { get; set; }
    }
}
