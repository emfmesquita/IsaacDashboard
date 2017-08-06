using System.Xml.Serialization;
using IsaacDashboard.Isaac;

namespace IsaacDashboard.SoundFun.Player {
    public class SoundFunEntity {
        [XmlElement(ElementName = "item")]
        public Item Item { get; set; }

        [XmlElement(ElementName = "file")]
        public string SoundFile { get; set; }
    }
}
