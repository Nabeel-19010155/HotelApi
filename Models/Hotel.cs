//19010155 - Nabeel Jadwat
//ICE 4 - LAC 4
//Hotel API
namespace HotelApi.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string Location {get; set;}
        public int Rating {get; set;}
        public string ImageUrl {get; set;}

        public Hotel() {}

        public Hotel(int id, string name, string site, string city, int rating, string url) {
            Id = id;
            Name = name;
            Website = site;
            Location = city;
            Rating = rating;
            ImageUrl = url;
        }
    }
}