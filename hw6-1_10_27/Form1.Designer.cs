namespace hw6_1_10_27 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            DrawBtn = new Button();
            ChooseBtn = new Button();
            Bar = new TrackBar();
            PicBox = new PictureBox();
            ShowLabel2 = new Label();
            ShowLabel1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 86);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 133);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // DrawBtn
            // 
            DrawBtn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DrawBtn.Location = new Point(114, 425);
            DrawBtn.Name = "DrawBtn";
            DrawBtn.Size = new Size(200, 35);
            DrawBtn.TabIndex = 2;
            DrawBtn.Text = "繪製拼圖板";
            DrawBtn.UseVisualStyleBackColor = true;
            // 
            // ChooseBtn
            // 
            ChooseBtn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseBtn.Location = new Point(594, 425);
            ChooseBtn.Name = "ChooseBtn";
            ChooseBtn.Size = new Size(200, 35);
            ChooseBtn.TabIndex = 3;
            ChooseBtn.Text = "選擇圖片";
            ChooseBtn.UseVisualStyleBackColor = true;
            ChooseBtn.Click += ChooseBtn_Click;
            // 
            // Bar
            // 
            Bar.LargeChange = 1;
            Bar.Location = new Point(626, 374);
            Bar.Maximum = 1;
            Bar.Name = "Bar";
            Bar.Size = new Size(151, 45);
            Bar.TabIndex = 4;
            Bar.Value = 1;
            Bar.ValueChanged += Bar_ValueChanged;
            // 
            // PicBox
            // 
            PicBox.Location = new Point(556, 86);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(270, 270);
            PicBox.TabIndex = 5;
            PicBox.TabStop = false;
            // 
            // ShowLabel2
            // 
            ShowLabel2.AutoSize = true;
            ShowLabel2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowLabel2.Location = new Point(783, 374);
            ShowLabel2.Name = "ShowLabel2";
            ShowLabel2.Size = new Size(41, 20);
            ShowLabel2.TabIndex = 8;
            ShowLabel2.Text = "顯示";
            // 
            // ShowLabel1
            // 
            ShowLabel1.AutoSize = true;
            ShowLabel1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowLabel1.Location = new Point(563, 374);
            ShowLabel1.Name = "ShowLabel1";
            ShowLabel1.Size = new Size(57, 20);
            ShowLabel1.TabIndex = 9;
            ShowLabel1.Text = "不顯示";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 511);
            Controls.Add(ShowLabel1);
            Controls.Add(ShowLabel2);
            Controls.Add(PicBox);
            Controls.Add(Bar);
            Controls.Add(ChooseBtn);
            Controls.Add(DrawBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button DrawBtn;
        private Button ChooseBtn;
        private TrackBar Bar;
        private PictureBox PicBox;
        private Label ShowLabel2;
        private Label ShowLabel1;
    }
}