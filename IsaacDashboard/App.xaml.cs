using System.Windows;
using IsaacDashboard.Serializer;

namespace IsaacDashboard {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        public App() {
            IsaacDashSerializer.Load();
        }
    }
}
