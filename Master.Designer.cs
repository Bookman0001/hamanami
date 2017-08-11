namespace WindowsFormsApplication2
{
    partial class Master
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plus_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.city_code_text = new System.Windows.Forms.TextBox();
            this.city_name_text = new System.Windows.Forms.TextBox();
            this.registration_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // plus_button
            // 
            this.plus_button.Location = new System.Drawing.Point(232, 168);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(37, 23);
            this.plus_button.TabIndex = 1;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // minus_button
            // 
            this.minus_button.Location = new System.Drawing.Point(275, 168);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(37, 23);
            this.minus_button.TabIndex = 2;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // city_code_text
            // 
            this.city_code_text.Location = new System.Drawing.Point(69, 213);
            this.city_code_text.Name = "city_code_text";
            this.city_code_text.Size = new System.Drawing.Size(100, 19);
            this.city_code_text.TabIndex = 3;
            this.city_code_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_code_text_KeyPress);
            // 
            // city_name_text
            // 
            this.city_name_text.Location = new System.Drawing.Point(212, 213);
            this.city_name_text.Name = "city_name_text";
            this.city_name_text.Size = new System.Drawing.Size(100, 19);
            this.city_name_text.TabIndex = 4;
            // 
            // registration_button
            // 
            this.registration_button.Location = new System.Drawing.Point(149, 249);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(81, 23);
            this.registration_button.TabIndex = 5;
            this.registration_button.Text = "Registration";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(261, 249);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(51, 23);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(90, 198);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(56, 12);
            this.id_label.TabIndex = 7;
            this.id_label.Text = "都市コード";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(240, 198);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(41, 12);
            this.name_label.TabIndex = 8;
            this.name_label.Text = "都市名";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 297);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.city_name_text);
            this.Controls.Add(this.city_code_text);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Master";
            this.Text = "エリア設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Master_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.TextBox city_code_text;
        private System.Windows.Forms.TextBox city_name_text;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
    }
}