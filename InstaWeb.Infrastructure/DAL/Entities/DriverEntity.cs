using System.ComponentModel.DataAnnotations.Schema;

namespace InstaWeb.Infrastructure.DAL.Entities
{
    class DriverEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DriverId { get; set; }
        public string Name  { get; set; }
        public string Surname { get; set; }

    }
}
