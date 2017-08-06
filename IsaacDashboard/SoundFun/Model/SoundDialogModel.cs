using System.Collections.Generic;
using System.ComponentModel;
using IsaacDashboard.Isaac;
using IsaacDashboard.Model;

namespace IsaacDashboard.SoundFun.Model {
    public class SoundDialogModel : BaseModel {
        public event PropertyChangedEventHandler ItemChanged;

        private Item _item;
        private List<Item> _items = new List<Item>();

        private string _file = "";

        private bool _saveButtonEnabled;

        public Item Item {
            get => _item;

            set {
                if (value == _item) return;
                _item = value;
                ItemChanged?.Invoke(this, new PropertyChangedEventArgs("Item"));
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

        public void SetItems(List<Item> items) {
            _items = items;
            NotifyPropertyChanged("Items");
        }

        public List<Item> Items => _items;

        public bool SaveButtonEnabled {
            get => _saveButtonEnabled;

            set {
                if (value == _saveButtonEnabled) return;
                _saveButtonEnabled = value;
                NotifyPropertyChanged();
            }
        }
    }
}
