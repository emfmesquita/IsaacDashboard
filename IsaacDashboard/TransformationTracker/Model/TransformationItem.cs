﻿using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows;
using System.Windows.Media.Imaging;
using IsaacDashboard.Commons.View;
using IsaacDashboard.Utils;
using static IsaacDashboard.Utils.ResourcesUtil;

namespace IsaacDashboard.TransformationTracker.Model {
    public class TransformationItem : GeneralImageModel {

        private const float UnlitImageBrightness = 0.3F;
        private const float UnlitImageContrast = 0.8F;
        private const string BlockImageResource = "IsaacDashboard.Images.block.png";

        private bool _touched;
        private bool _blocked;
        private float _blockScale = 1;
        private bool _showTooltip;

        private static readonly Dictionary<string, BitmapImage> UnlitImageCache = new Dictionary<string, BitmapImage>();

        public TransformationItem(string i18N, string resource, int x = 0, int y = 0, float scale = 1) : base(resource, i18N, x, y) {
            ItemImageModel = new GeneralImageModel(resource);
            Touched = CreationMode.On;
            Scale = scale;
        }

        public TransformationItem(string i18N, int id, int x = 0, int y = 0, float scale = 1, float blockScale = 1) : this(i18N, UnmoddedItemResource(id), x, y, scale) {
            BlockImageModel = new GeneralImageModel(BlockImageResource) {
                Visibility = Visibility.Hidden
            };
            Id = id;
            BlockScale = blockScale;
            Blocked = CreationMode.BlockModeOn;
        }

        public GeneralImageModel ItemImageModel { get; }
        public GeneralImageModel BlockImageModel { get; }
        public int Id { get; }

        public int AbsoluteX => 50 + X - Width / 2;
        public int AbsoluteY => 50 + Y - Height / 2;
        public System.Windows.Point Center => new System.Windows.Point(50 + X, 50 + Y);

        public bool Touched {
            get => _touched;
            set {
                _touched = value;
                var image = ImageUtils.GetImage(Resource);
                if (image != null) {
                    ItemImageModel.Image = _touched ? image : UnlitImage(Resource);
                }
            }
        }

        public bool Blocked {
            get => _blocked;
            set {
                _blocked = value;
                if (BlockImageModel == null) return;
                BlockImageModel.Visibility = _blocked ? Visibility.Visible : Visibility.Hidden;
            }
        }

        public override float Scale {
            get => base.Scale;

            set {
                base.Scale = value;
                ItemImageModel.Scale = value;
                if (BlockImageModel == null) return;
                BlockImageModel.Scale = value * _blockScale;
            }
        }

        public float BlockScale {
            get => _blockScale;

            set {
                _blockScale = value;
                if (BlockImageModel == null) return;
                BlockImageModel.Scale = Scale * _blockScale;
            }
        }

        public bool ShowTooltip {
            get => _showTooltip;

            set {
                if (value == _showTooltip) return;
                _showTooltip = value;
                ItemImageModel.Tooltip = _showTooltip ? Tooltip : null;
            }
        }

        private static BitmapImage UnlitImage(string resource) {
            if (UnlitImageCache.ContainsKey(resource)) return UnlitImageCache[resource];
            var bitmapImage = ImageUtils.GetImage(resource);
            if (bitmapImage == null) {
                return null;
            }
            var image = ImageUtils.ToBitmap(bitmapImage);
            image = ImageUtils.AdjustBrightnessContrast(image, UnlitImageBrightness, UnlitImageContrast);
            UnlitImageCache.Add(resource, ImageUtils.ToBitmapImage(new Bitmap(image)));
            return UnlitImageCache[resource];
        }

        public override string ToString() {
            var scale = Scale.ToString("N", new CultureInfo("en-US"));
            var blockScale = BlockScale.ToString("N", new CultureInfo("en-US"));
            return $"                new TransformationItem(\"{Tooltip}\", {Id}, {X}, {Y}, {scale}F, {blockScale}F),";
        }
    }
}
