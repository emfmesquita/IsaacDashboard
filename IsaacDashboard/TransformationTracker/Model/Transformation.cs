using System.Collections.Generic;
using System.Windows;
using IsaacDashboard.Commons.View;
using IsaacDashboard.Model;
using IsaacDashboard.Utils;

namespace IsaacDashboard.TransformationTracker.Model {
    public class Transformation : BaseModel {
        private string _transformationLabel;
        private Visibility _visibility = Visibility.Visible;
        private Visibility _ringVisibility = CreationMode.On ? Visibility.Visible : Visibility.Hidden;
        private string _count;
        private bool _showTransformationImage;
        private string _itemTooltip;

        public Transformation(string name, string i18N, int memoryOffset, int x = 0, int y = 0, float scale = 1.0F) {
            Name = name;
            MemoryOffset = memoryOffset;
            I18N = i18N;
            var transfotmationImageResource = $"IsaacDashboard.Images.Transformations.{name}.png";
            TransformationImageModel = new GeneralImageModel(transfotmationImageResource, i18N, x, y) {
                Scale = scale,
                Visibility = Visibility.Hidden
            };
            TransformationLabel = $"{I18N}: {_count}";
        }

        public List<TransformationItem> Items { get; set; }

        public string Name { get; }
        public int MemoryOffset { get; }
        public GeneralImageModel TransformationImageModel { get; }
        public string I18N { get; }

        public bool ShowTransformationImage {
            get => _showTransformationImage;

            set {
                if (value == _showTransformationImage) return;
                _showTransformationImage = value;
                TransformationImageModel.Visibility = _showTransformationImage ? Visibility.Visible : Visibility.Hidden;
                Items.ForEach(item => {
                    item.Visibility = _showTransformationImage ? Visibility.Hidden : Visibility.Visible;
                });
            }
        }

        public string Count {
            get => _count;

            set {
                if (value == _count) return;
                _count = value;
                TransformationLabel = $"{I18N}: {_count}";
            }
        }

        public string TransformationLabel {
            get => _transformationLabel;

            set {
                if (value == _transformationLabel) return;
                _transformationLabel = value;
                NotifyPropertyChanged();
            }
        }

        public Visibility Visibility {
            get => _visibility;

            set {
                if (value == _visibility) return;
                _visibility = value;
                NotifyPropertyChanged();
            }
        }

        public Visibility RingVisibility {
            get => _ringVisibility;

            set {
                if (value == _ringVisibility) return;
                _ringVisibility = value;
                NotifyPropertyChanged();
            }
        }

        public string ItemTooltip {
            get => _itemTooltip;

            set {
                if (value == _itemTooltip) return;
                _itemTooltip = value;
                NotifyPropertyChanged();
            }
        }
    }
}
