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
            components = new System.ComponentModel.Container();
            TimeLabel = new Label();
            StepLabel = new Label();
            DrawBtn = new Button();
            ChooseBtn = new Button();
            Bar = new TrackBar();
            PicBox = new PictureBox();
            ShowLabel2 = new Label();
            ShowLabel1 = new Label();
            Timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.Location = new Point(410, 120);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(94, 20);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "Time: 00:00";
            // 
            // StepLabel
            // 
            StepLabel.AutoSize = true;
            StepLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StepLabel.Location = new Point(410, 180);
            StepLabel.Name = "StepLabel";
            StepLabel.Size = new Size(90, 20);
            StepLabel.TabIndex = 1;
            StepLabel.Text = "移動步數: 0";
            // 
            // DrawBtn
            // 
            DrawBtn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DrawBtn.Location = new Point(124, 425);
            DrawBtn.Name = "DrawBtn";
            DrawBtn.Size = new Size(200, 35);
            DrawBtn.TabIndex = 2;
            DrawBtn.Text = "繪製拼圖板";
            DrawBtn.UseVisualStyleBackColor = true;
            DrawBtn.Click += DrawBtn_Click;
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
            PicBox.BackColor = SystemColors.Control;
            PicBox.Location = new Point(555, 85);
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
            // Timer1
            // 
            Timer1.Interval = 1000;
            Timer1.Tick += Timer1_Tick;
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
            Controls.Add(StepLabel);
            Controls.Add(TimeLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TimeLabel;
        private Label StepLabel;
        private Button DrawBtn;
        private Button ChooseBtn;
        private TrackBar Bar;
        private PictureBox PicBox;
        private Label ShowLabel2;
        private Label ShowLabel1;
        private System.Windows.Forms.Timer Timer1;
    }
}