﻿using IsaacDashboard.Model;

namespace IsaacDashboard {
    public class StatusBarModel : BaseModel {
        private string _status = "";

        public StatusBarModel() {
            Status = "Isaac proccess not found. Still searching...";
        }

        public string Status {
            get => _status;

            set {
                if (value == _status) return;
                _status = value;
                NotifyPropertyChanged();
            }
        }
    }
}
