namespace WeatherApp
{
    partial class MasterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.MasterGridView = new System.Windows.Forms.DataGridView();
            this.Search_Text = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.city_name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterGridView
            // 
            this.MasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.MasterGridView.Location = new System.Drawing.Point(24, 75);
            this.MasterGridView.Name = "MasterGridView";
            this.MasterGridView.RowTemplate.Height = 21;
            this.MasterGridView.Size = new System.Drawing.Size(160, 372);
            this.MasterGridView.TabIndex = 0;
            // 
            // Search_Text
            // 
            this.Search_Text.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Text.Location = new System.Drawing.Point(24, 16);
            this.Search_Text.Name = "Search_Text";
            this.Search_Text.Size = new System.Drawing.Size(160, 25);
            this.Search_Text.TabIndex = 1;
            this.Search_Text.Text = "例:東京";
            this.Search_Text.Click += new System.EventHandler(this.Search_Text_Click);
            this.Search_Text.Enter += new System.EventHandler(this.Search_Text_Enter);
            this.Search_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Text_KeyDown);
            // 
            // Search_Button
            // 
            this.Search_Button.Image = global::WindowsFormsApplication2.Properties.Resources.if__svg_2093656;
            this.Search_Button.Location = new System.Drawing.Point(206, 12);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(62, 32);
            this.Search_Button.TabIndex = 2;
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OK_Button.Location = new System.Drawing.Point(24, 453);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(70, 23);
            this.OK_Button.TabIndex = 3;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Cancel_Button.Location = new System.Drawing.Point(114, 453);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(70, 23);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // city_name_label
            // 
            this.city_name_label.AutoSize = true;
            this.city_name_label.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_name_label.Location = new System.Drawing.Point(82, 54);
            this.city_name_label.Name = "city_name_label";
            this.city_name_label.Size = new System.Drawing.Size(44, 18);
            this.city_name_label.TabIndex = 5;
            this.city_name_label.Text = "地域名";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 488);
            this.Controls.Add(this.city_name_label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Search_Text);
            this.Controls.Add(this.MasterGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterForm";
            this.Text = "エリア設定";
            ((System.ComponentModel.ISupportInitialize)(this.MasterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MasterGridView;
        private System.Windows.Forms.TextBox Search_Text;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label city_name_label;
    }
}