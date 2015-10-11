using BattleshipsAI.Enums;
using BattleshipsAI.Helpers;
using System.Runtime.Serialization;

namespace BattleshipsAI.Models
{
    [DataContract]
    public class PlaceResponse
    {
        [DataMember]
        public string GridReference { get; set; } = "A1";

        [DataMember]
        public string Orientation { get; set; } = Ship.Orientation.Horizontal.GetString();
    }
}
