using System.Windows.Media.Imaging;
using IsaacDashboard.Model;
using IsaacDashboard.Utils;

namespace IsaacDashboard.Commons.View {
    public class ExtraWindowModel : BaseModel {

        private BitmapImage _icon;
        private string _title;
        private string _iconResource;

        public ExtraWindowModel(string iconResource, string title) {
            IconResource = iconResource;
            Title = title;
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

        public string Title {
            get => _title;
            set {
                if (value == _title) return;
                _title = value;
                NotifyPropertyChanged();
            }
        }
    }
}
