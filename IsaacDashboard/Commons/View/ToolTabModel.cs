using System.Windows.Media.Imaging;
using IsaacDashboard.Model;
using IsaacDashboard.Utils;

namespace IsaacDashboard.Commons.View {
    public class ToolTabModel : BaseModel {
        private BitmapImage _icon;
        private string _iconResource;
        private string _label;

        public ToolTabModel(string iconResource, string label) {
            IconResource = iconResource;
            Label = label;
        }

        public BitmapImage Icon {
            get => _icon;
            set {
                if (Equals(value, _icon)) return;
                _icon = value;
                NotifyPropertyChanged();
            }
        }

        public string IconResource {
            get => _iconResource;
            set {
                if (value == _iconResource) return;
                _iconResource = value;
                if (string.IsNullOrEmpty(_iconResource)) return;
                Icon = ImageUtils.GetImage(_iconResource);
            }
        }

        public string Label {
            get => _label;
            set {
                if (value == _label) return;
                _label = value;
                NotifyPropertyChanged();
            }
        }
    }
}
