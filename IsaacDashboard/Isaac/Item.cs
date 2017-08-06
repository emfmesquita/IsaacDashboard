using System.Xml.Serialization;

namespace IsaacDashboard.Isaac {
    public class Item {
        public Item() {
            // empty
        }

        public Item(int id) {
            Id = id;
        }

        public Item(string i18N, int id) {
            I18N = i18N;
            Id = id;
        }

        [XmlAttribute("name")]
        public string I18N { get; set; }
        [XmlAttribute("id")]
        public int Id { get; set; }

        public override string ToString() {
            return I18N;
        }
    }
}
