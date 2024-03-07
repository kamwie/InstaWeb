using System.ComponentModel.DataAnnotations.Schema;

namespace InstaWeb.Infrastructure.DAL.Entities
{
    class AdressEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdressId { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }

    }
}
