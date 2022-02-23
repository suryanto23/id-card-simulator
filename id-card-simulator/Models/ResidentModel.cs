using System.ComponentModel.DataAnnotations.Schema;

namespace id_card_simulator.Models
{
    public class ResidentModel
    {
        public Guid Id { get; set; }
        [Column(TypeName = "varchar(50)")]        
        public string Nin { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string PlaceOfBirth { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Gender { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Religion { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string MarriedStatus { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Profession { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Nationality { get; set; }
        public DateTime IssuedDate { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string Image { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string Province { get; set; }
        public int Neighborhood { get; set; }
        public int Hamlet { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string UrbanDistrict { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string SubDistrict { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string BloodType { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
