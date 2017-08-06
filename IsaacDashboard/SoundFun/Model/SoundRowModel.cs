using System.Windows.Media;
using IsaacDashboard.Isaac;
using IsaacDashboard.Model;

namespace IsaacDashboard.SoundFun.Model {
    public class SoundRowModel : BaseModel {

        private Item _item;
        private string _file = "";
        private Brush _fileLabelForeGround;

        public SoundRowModel() {
            FileLabelForeground = Brushes.Black;
        }

        public Item Item {
            get => _item;

            set {
                if (value == _item) return;
                _item = value;
                NotifyPropertyChanged();
            }
        }

        public string File {
            get => _file;

            set {
                if (value == _file) return;
                _file = value;
                NotifyPropertyChanged();
            }
        }

        public void FileFound() {
            FileLabelForeground = Brushes.Black;
        }

        public void FileNotFound() {
            FileLabelForeground = Brushes.Red;
        }

        public Brush FileLabelForeground {
            get => _fileLabelForeGround;

            private set {
                if (value == _fileLabelForeGround) return;
                _fileLabelForeGround = value;
                NotifyPropertyChanged();
            }
        }
    }
}
