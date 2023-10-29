using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace hw6_1_10_27 {
    public partial class Form1 : Form {
        Bitmap? img;
        Button[] PuzzleBtns = new Button[9];
        Image[] ans = new Image[9];
        Image[] rand_imgs = new Image[9];
        Random rnd = new();
        int time = 0, step = 0;


        public Form1() {
            InitializeComponent();
            for (int i = 0; i < 9; i++) {
                PuzzleBtns[i] = new Button {
                    Size = new Size(90, 90),
                    Location = new Point(85 + 91 * (i % 3), 90 + 91 * (i / 3)),
                    Tag = i,
                    Visible = true
                };
                PuzzleBtns[i].Click += PuzzleBtn_Click;
                Controls.Add(PuzzleBtns[i]);
            }
            PuzzleBtns[8].Visible = false;
        }

        // https://stackoverflow.com/a/24199315
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

        private void PuzzleBtn_Click(object sender, EventArgs e) {
            step++;
            StepLabel.Text = $"移動步數: {step}";
            int tag = (int)((Button)sender).Tag;
            int empty = 8;
            for (int i = 0; i < 9; i++) {
                if (!PuzzleBtns[i].Visible) {
                    empty = i;
                    break;
                }
            }

            // swap image in rnd_imgs[tag] & rnd_imgs[empty]
            (rand_imgs[empty], rand_imgs[tag]) = (rand_imgs[tag], rand_imgs[empty]);
            PuzzleBtns[empty].Image = rand_imgs[empty];
            PuzzleBtns[tag].Image = rand_imgs[tag];
            PuzzleBtns[empty].Visible = true;
            PuzzleBtns[tag].Visible = false;

            // if rand_imgs == ans, win
            if (rand_imgs.SequenceEqual(ans)) {
                Timer1.Stop();
                MessageBox.Show($"你獲勝了!\n完成時間: {(time / 60 >= 10 ? (time / 60).ToString() : $"0{time / 60}")}:{(time % 60 >= 10 ? (time % 60).ToString() : $"0{time % 60}")}\n移動步數: {step}");

                foreach (Button btn in PuzzleBtns) {
                    btn.Enabled = false;
                }
            }
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

                for (int i = 0; i < 9; i++) {
                    Image crop = img.Clone(new Rectangle(i % 3 * 90, i / 3 * 90, 90, 90), img.PixelFormat);
                    ans[i] = crop;
                }
            }
        }

        private void DrawBtn_Click(object sender, EventArgs e) {
            if (img == null) {
                MessageBox.Show("請先選擇圖片!", "提示");
                return;
            }

            rand_imgs = ans.OrderBy(item => rnd.Next()).ToArray();
            for (int i = 0; i < 9; i++) {
                PuzzleBtns[i].Enabled = true;
                PuzzleBtns[i].Visible = true;
                PuzzleBtns[i].Image = rand_imgs[i];
            }
            PuzzleBtns[8].Visible = false;
            time = 0;
            step = 0;
            TimeLabel.Text = $"Time: 00:00";
            StepLabel.Text = $"移動步數: 0";
            Timer1.Stop();
            Timer1.Start();
        }

        private void Bar_ValueChanged(object sender, EventArgs e) {
            PicBox.BackColor = Bar.Value == 1 ? SystemColors.Control : SystemColors.ButtonShadow;
            PicBox.Image = Bar.Value == 1 ? img : null;
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            time++;
            TimeLabel.Text = $"Time: {(time / 60 >= 10 ? (time / 60).ToString() : $"0{time / 60}")}:{(time % 60 >= 10 ? (time % 60).ToString() : $"0{time % 60}")}";
        }
    }
}