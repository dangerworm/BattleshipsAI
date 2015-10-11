using System.Runtime.Serialization;

namespace BattleshipsAI.Models
{
    [DataContract]
    public class MoveResponse
    {
        [DataMember]
        public string Type { get; set; } = "ATTACK";

        [DataMember]
        public string GridReference { get; set; } = "A1";
    }
}