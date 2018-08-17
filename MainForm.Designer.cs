namespace WeatherApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WeatherText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.setting_button = new System.Windows.Forms.Button();
            this.today_temperature = new System.Windows.Forms.Label();
            this.tomorrow_temperature = new System.Windows.Forms.Label();
            this.dayafter_temperature = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chenge_image_button = new System.Windows.Forms.Button();
            this.TodayTelop = new System.Windows.Forms.Label();
            this.TomorrowTelop = new System.Windows.Forms.Label();
            this.DayAfterTomorrowTelop = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherText
            // 
            this.WeatherText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WeatherText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeatherText.Cursor = System.Windows.Forms.Cursors.Default;
            this.WeatherText.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeatherText.Location = new System.Drawing.Point(44, 326);
            this.WeatherText.Multiline = true;
            this.WeatherText.Name = "WeatherText";
            this.WeatherText.ReadOnly = true;
            this.WeatherText.Size = new System.Drawing.Size(487, 137);
            this.WeatherText.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(97, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "今日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(440, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "明後日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(268, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "明日";
            // 
            // setting_button
            // 
            this.setting_button.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.setting_button.Location = new System.Drawing.Point(197, 474);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(153, 30);
            this.setting_button.TabIndex = 10;
            this.setting_button.Text = "エリア設定";
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.setting_button_Click);
            // 
            // today_temperature
            // 
            this.today_temperature.AutoSize = true;
            this.today_temperature.Location = new System.Drawing.Point(74, 329);
            this.today_temperature.Name = "today_temperature";
            this.today_temperature.Size = new System.Drawing.Size(0, 12);
            this.today_temperature.TabIndex = 11;
            // 
            // tomorrow_temperature
            // 
            this.tomorrow_temperature.AutoSize = true;
            this.tomorrow_temperature.Location = new System.Drawing.Point(259, 329);
            this.tomorrow_temperature.Name = "tomorrow_temperature";
            this.tomorrow_temperature.Size = new System.Drawing.Size(0, 12);
            this.tomorrow_temperature.TabIndex = 12;
            // 
            // dayafter_temperature
            // 
            this.dayafter_temperature.AutoSize = true;
            this.dayafter_temperature.Location = new System.Drawing.Point(450, 329);
            this.dayafter_temperature.Name = "dayafter_temperature";
            this.dayafter_temperature.Size = new System.Drawing.Size(0, 12);
            this.dayafter_temperature.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(432, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(252, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(86, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chenge_image_button
            // 
            this.chenge_image_button.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chenge_image_button.Location = new System.Drawing.Point(378, 474);
            this.chenge_image_button.Name = "chenge_image_button";
            this.chenge_image_button.Size = new System.Drawing.Size(153, 30);
            this.chenge_image_button.TabIndex = 14;
            this.chenge_image_button.Text = "デザイン変更";
            this.chenge_image_button.UseVisualStyleBackColor = true;
            this.chenge_image_button.Click += new System.EventHandler(this.chenge_image_button_Click);
            // 
            // TodayTelop
            // 
            this.TodayTelop.AutoSize = true;
            this.TodayTelop.BackColor = System.Drawing.Color.Transparent;
            this.TodayTelop.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TodayTelop.ForeColor = System.Drawing.Color.Tomato;
            this.TodayTelop.Location = new System.Drawing.Point(80, 281);
            this.TodayTelop.Name = "TodayTelop";
            this.TodayTelop.Size = new System.Drawing.Size(127, 31);
            this.TodayTelop.TabIndex = 15;
            this.TodayTelop.Text = "TodayTelop";
            this.TodayTelop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TomorrowTelop
            // 
            this.TomorrowTelop.AutoSize = true;
            this.TomorrowTelop.BackColor = System.Drawing.Color.Transparent;
            this.TomorrowTelop.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TomorrowTelop.ForeColor = System.Drawing.Color.Tomato;
            this.TomorrowTelop.Location = new System.Drawing.Point(246, 281);
            this.TomorrowTelop.Name = "TomorrowTelop";
            this.TomorrowTelop.Size = new System.Drawing.Size(169, 31);
            this.TomorrowTelop.TabIndex = 16;
            this.TomorrowTelop.Text = "TomorrowTelop";
            this.TomorrowTelop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayAfterTomorrowTelop
            // 
            this.DayAfterTomorrowTelop.AutoSize = true;
            this.DayAfterTomorrowTelop.BackColor = System.Drawing.Color.Transparent;
            this.DayAfterTomorrowTelop.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DayAfterTomorrowTelop.ForeColor = System.Drawing.Color.Tomato;
            this.DayAfterTomorrowTelop.Location = new System.Drawing.Point(426, 281);
            this.DayAfterTomorrowTelop.Name = "DayAfterTomorrowTelop";
            this.DayAfterTomorrowTelop.Size = new System.Drawing.Size(259, 31);
            this.DayAfterTomorrowTelop.TabIndex = 17;
            this.DayAfterTomorrowTelop.Text = "DayAfterTomorrowTelop";
            this.DayAfterTomorrowTelop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DayAfterTomorrowTelop);
            this.Controls.Add(this.TomorrowTelop);
            this.Controls.Add(this.TodayTelop);
            this.Controls.Add(this.chenge_image_button);
            this.Controls.Add(this.dayafter_temperature);
            this.Controls.Add(this.tomorrow_temperature);
            this.Controls.Add(this.today_temperature);
            this.Controls.Add(this.setting_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.WeatherText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "White Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeatherText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button setting_button;
        private System.Windows.Forms.Label today_temperature;
        private System.Windows.Forms.Label tomorrow_temperature;
        private System.Windows.Forms.Label dayafter_temperature;
        private System.Windows.Forms.Button chenge_image_button;
        private System.Windows.Forms.Label TodayTelop;
        private System.Windows.Forms.Label TomorrowTelop;
        private System.Windows.Forms.Label DayAfterTomorrowTelop;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

