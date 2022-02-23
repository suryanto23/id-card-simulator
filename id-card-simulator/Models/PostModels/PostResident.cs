namespace id_card_simulator.Models.PostModels
{
    public class PostResident
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nin { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Religion { get; set; }
        public string MarriedStatus { get; set; }
        public string Profession { get; set; }
        public string Nationality { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int Neighborhood { get; set; }
        public int Hamlet { get; set; }
        public string UrbanDistrict { get; set; }
        public string SubDistrict { get; set; }
        public string BloodType { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
