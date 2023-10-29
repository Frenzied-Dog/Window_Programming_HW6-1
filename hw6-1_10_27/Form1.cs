using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace hw6_1_10_27 {
    public partial class Form1 : Form {
        Image? img;

        public Form1() {
            InitializeComponent();
        }

        public static Bitmap Resize_img(Image image, int width, int height) {

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using ImageAttributes wrapMode = new();
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            }

            return destImage;
        }

        private void ChooseBtn_Click(object sender, EventArgs e) {
            using OpenFileDialog OFD = new();
            OFD.Filter = "圖片檔案 (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有檔案 (*.*)|*.*";
            OFD.Title = "選擇圖片";
            OFD.Multiselect = false;
            OFD.InitialDirectory = ".";

            if (OFD.ShowDialog() == DialogResult.OK) {
                string path = OFD.FileName;
                img = Resize_img(Image.FromFile(path), 270, 270);

                PicBox.Image = img;
            }
        }

        private void Bar_ValueChanged(object sender, EventArgs e) {
            PicBox.Visible = Bar.Value == 1;
        }
    }
}