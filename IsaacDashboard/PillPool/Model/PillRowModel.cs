using System.Windows.Media.Imaging;
using IsaacDashboard.Model;
using IsaacDashboard.Utils;

namespace IsaacDashboard.PillPool.Model {
    public class PillRowModel : BaseModel {
        private string _pillImageResource;
        private BitmapImage _pillImage;
        private string _label;

        public BitmapImage PillImage {
            get => _pillImage;
            set {
                if (Equals(value, _pillImage)) return;
                _pillImage = value;
                NotifyPropertyChanged();
            }
        }

        public string PillImageResource {
            get => _pillImageResource;
            set {
                if (value == _pillImageResource) return;
                _pillImageResource = value;
                PillImage = string.IsNullOrEmpty(_pillImageResource) ? null : ImageUtils.GetImage(_pillImageResource);
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
