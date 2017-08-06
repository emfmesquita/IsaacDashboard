using System.Windows.Controls;
using System.Windows.Data;
using IsaacDashboard.PillPool.Model;

namespace IsaacDashboard.PillPool {
    /// <summary>
    /// Interaction logic for PillRow.xaml
    /// </summary>
    public partial class PillRow : UserControl {
        public PillRow() {
            InitializeComponent();
            Model = new PillRowModel();
            CreateBindings();
        }

        public PillRowModel Model { get; }

        private void CreateBindings() {
            PillImage.SetBinding(Image.SourceProperty, new Binding("PillImage") {
                Source = Model,
                Mode = BindingMode.OneWay
            });
            PillLabel.SetBinding(ContentProperty, new Binding("Label") {
                Source = Model,
                Mode = BindingMode.OneWay
            });
        }
    }
}
