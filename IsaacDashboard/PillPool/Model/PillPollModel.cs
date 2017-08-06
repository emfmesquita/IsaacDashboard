using System.Windows;
using IsaacDashboard.Model;

namespace IsaacDashboard.PillPool.Model {
    public class PillPollModel : BaseModel {
        private Visibility _lastPillVisibility = Visibility.Hidden;

        public Visibility LastPillVisibility {
            get => _lastPillVisibility;

            set {
                if (value == _lastPillVisibility) return;
                _lastPillVisibility = value;
                NotifyPropertyChanged();
            }
        }
    }
}
