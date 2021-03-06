﻿using System;
using System.Windows;
using System.Windows.Data;
using IsaacDashboard.Serializer;

namespace IsaacDashboard.Commons.View {
    /// <summary>
    /// Interaction logic for ExtraWindow.xaml
    /// </summary>
    public partial class ExtraWindow : StatefulWindow {

        private readonly Action _closeAction;

        public ExtraWindow(ExtraWindowModel model, WindowSettings settings, Action closeAction) {
            Settings = settings;
            InitializeComponent();
            Model = model;
            LoadSettings();
            CreateBindings();
            _closeAction = closeAction;
        }

        public void Show(UIElement content) {
            Content = content;
            Show();
        }

        public ExtraWindowModel Model { get; }

        private void CreateBindings() {
            Window.SetBinding(TitleProperty, new Binding("Title") {
                Source = Model,
                Mode = BindingMode.OneWay
            });
            Window.SetBinding(IconProperty, new Binding("Icon") {
                Source = Model,
                Mode = BindingMode.OneWay
            });
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e) {
            Content = null;
            _closeAction();
        }
    }
}
