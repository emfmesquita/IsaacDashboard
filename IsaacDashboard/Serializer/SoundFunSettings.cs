using System.Xml.Serialization;
using IsaacDashboard.SoundFun.Player;

namespace IsaacDashboard.Serializer {

    public class SoundFunSettings {
        [XmlArray("entities")]
        [XmlArrayItem("entity")]
        public SoundFunEntity[] Entities { get; set; }
    }
}
