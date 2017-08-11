namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weather_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.location_name = new System.Windows.Forms.Label();
            this.setting_button = new System.Windows.Forms.Button();
            this.today_temperature = new System.Windows.Forms.Label();
            this.tomorrow_temperature = new System.Windows.Forms.Label();
            this.dayafter_temperature = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // weather_text
            // 
            this.weather_text.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.weather_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weather_text.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weather_text.Location = new System.Drawing.Point(45, 298);
            this.weather_text.Multiline = true;
            this.weather_text.Name = "weather_text";
            this.weather_text.Size = new System.Drawing.Size(473, 107);
            this.weather_text.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(70, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "今日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(450, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "明後日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(259, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "明日";
            // 
            // location_name
            // 
            this.location_name.AutoSize = true;
            this.location_name.BackColor = System.Drawing.Color.Transparent;
            this.location_name.ForeColor = System.Drawing.Color.Black;
            this.location_name.Location = new System.Drawing.Point(253, 21);
            this.location_name.Name = "location_name";
            this.location_name.Size = new System.Drawing.Size(35, 12);
            this.location_name.TabIndex = 9;
            this.location_name.Text = "label1";
            this.location_name.UseWaitCursor = true;
            // 
            // setting_button
            // 
            this.setting_button.Location = new System.Drawing.Point(207, 469);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(153, 23);
            this.setting_button.TabIndex = 10;
            this.setting_button.Text = "設定";
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
            this.pictureBox3.Location = new System.Drawing.Point(418, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(221, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(32, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.CvyjqJAVYAETPsv;
            this.ClientSize = new System.Drawing.Size(579, 532);
            this.Controls.Add(this.dayafter_temperature);
            this.Controls.Add(this.tomorrow_temperature);
            this.Controls.Add(this.today_temperature);
            this.Controls.Add(this.setting_button);
            this.Controls.Add(this.location_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.weather_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "天気予報";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weather_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label location_name;
        private System.Windows.Forms.Button setting_button;
        private System.Windows.Forms.Label today_temperature;
        private System.Windows.Forms.Label tomorrow_temperature;
        private System.Windows.Forms.Label dayafter_temperature;
    }
}

