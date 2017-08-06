using System.Windows.Media.Imaging;
using IsaacDashboard.Model;

namespace IsaacDashboard.Commons.View {
    public class CenteredImageModel : BaseModel {
        private BitmapImage _image;

        public CenteredImageModel(BitmapImage image) {
            _image = image;
        }

        public BitmapImage Image {
            get => _image;
            set {
                if (Equals(value, _image)) return;
                _image = value;
                NotifyPropertyChanged();
            }
        }
    }
}
