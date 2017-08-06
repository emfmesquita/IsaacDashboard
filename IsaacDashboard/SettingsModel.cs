using System.Windows;
using System.Windows.Media;
using IsaacDashboard.Model;
using IsaacDashboard.Serializer;
using IsaacDashboard.Utils;
using static IsaacDashboard.Serializer.IsaacDashSerializer;

namespace IsaacDashboard {
    public class SettingsModel : BaseModel {
        private Color _backgroundColor;
        private Color _foregroundColor;
        private bool _showTransformationImage;
        private bool _showBlacklistedIcon;
        private Color _blacklistedIconColor;

        public SettingsModel() {
            BackgroundColor = Settings.GeneralSettings.BackgroundColor;
            ForegroundColor = Settings.GeneralSettings.TextColor;
            ShowTransformationImage = Settings.TransformationTrackerSettings.ShowTransformationImage ?? true;
            ShowBlacklistedIcon = Settings.TransformationTrackerSettings.ShowBlacklistedIcon ?? true;
            BlacklistedIconColor = Settings.TransformationTrackerSettings.BlacklistedIconColor;
        }

        public Color BackgroundColor {
            get => _backgroundColor;

            set {
                if (value == _backgroundColor) return;
                _backgroundColor = value;
                _backgroundColorDebouncer.Tick(value);
                Application.Current.Resources["BackgroundColor"] = new SolidColorBrush(value);
                NotifyPropertyChanged();
            }
        }

        public Color ForegroundColor {
            get => _foregroundColor;

            set {
                if (value == _foregroundColor) return;
                _foregroundColor = value;
                _foregroundColorDebouncer.Tick(value);
                Application.Current.Resources["ForegroundColor"] = new SolidColorBrush(value);
                NotifyPropertyChanged();
            }
        }

        public bool ShowTransformationImage {
            get => _showTransformationImage;

            set {
                if (value == _showTransformationImage) return;
                _showTransformationImage = value;
                IsaacDashSerializer.Settings.TransformationTrackerSettings.ShowTransformationImage = value;
                IsaacDashSerializer.MarkToSave();
                NotifyPropertyChanged();
            }
        }

        public bool ShowBlacklistedIcon {
            get => _showBlacklistedIcon;

            set {
                if (value == _showBlacklistedIcon) return;
                _showBlacklistedIcon = value;
                IsaacDashSerializer.Settings.TransformationTrackerSettings.ShowBlacklistedIcon = value;
                IsaacDashSerializer.MarkToSave();
                NotifyPropertyChanged();
            }
        }

        public Color BlacklistedIconColor {
            get => _blacklistedIconColor;

            set {
                if (value == _blacklistedIconColor) return;
                _blacklistedIconColor = value;
                _blacklistedIconColorDebouncer.Tick(value);
                NotifyPropertyChanged();
            }
        }

        private readonly Debouncer<Color> _backgroundColorDebouncer = new Debouncer<Color>(300,
            color => {
                IsaacDashSerializer.Settings.GeneralSettings.BackgroundColor = color;
                IsaacDashSerializer.MarkToSave();
            });

        private readonly Debouncer<Color> _foregroundColorDebouncer = new Debouncer<Color>(300,
            color => {
                IsaacDashSerializer.Settings.GeneralSettings.TextColor = color;
                IsaacDashSerializer.MarkToSave();
            });

        private readonly Debouncer<Color> _blacklistedIconColorDebouncer = new Debouncer<Color>(500,
            color => {
                IsaacDashSerializer.Settings.TransformationTrackerSettings.BlacklistedIconColor = color;
                IsaacDashSerializer.MarkToSave();
                //if (TransformationTracker.TransformationTracker.BlockIconImageModel != null) {
                //    TransformationTracker.TransformationTracker.UpdateBlockImageColor(color);
                //}
                //TransformationTracker.TransformationTracker.UpdateBlockImageColor(color);
            });
    }
}
