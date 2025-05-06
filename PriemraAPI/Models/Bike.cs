using System.Text.Json.Serialization;

namespace PriemraAPI.Models
{
    public class Bike
    {
        [JsonRequired]
        public int bikeId { get; set; }
        public string marca { get; set; }
        public string material { get; set; }
        [JsonIgnore]
        public double costo { get; set; }
        public bool esNueva { get; set; } = true;
 
    }
}
