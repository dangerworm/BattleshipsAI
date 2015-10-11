using System.Runtime.Serialization;

namespace BattleshipsAI
{
    [DataContract]
    public class StartRequest
    {
        [DataMember]
        public int MaxTurns { get; set; }

        [DataMember]
        public string GridSize { get; set; }

        [DataMember]
        public string[] Players { get; set; }

        [DataMember]
        public string[] Ships { get; set; }

        [DataMember]
        public int MineCount { get; set; }
    }
}