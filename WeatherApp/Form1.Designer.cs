namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_condition = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.lab_detail = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.Windspeed = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_tempmin = new System.Windows.Forms.Label();
            this.lab_tempmax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_temp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_feelslike = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCity
            // 
            this.TbCity.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.TbCity.Location = new System.Drawing.Point(193, 84);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(250, 26);
            this.TbCity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "City:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(449, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 37);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_condition
            // 
            this.lab_condition.AutoSize = true;
            this.lab_condition.BackColor = System.Drawing.Color.Transparent;
            this.lab_condition.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_condition.ForeColor = System.Drawing.Color.White;
            this.lab_condition.Location = new System.Drawing.Point(113, 204);
            this.lab_condition.Name = "lab_condition";
            this.lab_condition.Size = new System.Drawing.Size(110, 19);
            this.lab_condition.TabIndex = 5;
            this.lab_condition.Text = "Conditions:";
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.ErrorImage = null;
            this.pic_icon.InitialImage = null;
            this.pic_icon.Location = new System.Drawing.Point(117, 129);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(100, 50);
            this.pic_icon.TabIndex = 15;
            this.pic_icon.TabStop = false;
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.BackColor = System.Drawing.Color.Transparent;
            this.lab_detail.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_detail.ForeColor = System.Drawing.Color.White;
            this.lab_detail.Location = new System.Drawing.Point(113, 236);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(61, 19);
            this.lab_detail.TabIndex = 16;
            this.lab_detail.Text = "Detail";
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunrise.ForeColor = System.Drawing.Color.White;
            this.Sunrise.Location = new System.Drawing.Point(113, 278);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(82, 19);
            this.Sunrise.TabIndex = 17;
            this.Sunrise.Text = "Sunrise:";
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.BackColor = System.Drawing.Color.Transparent;
            this.Sunset.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunset.ForeColor = System.Drawing.Color.White;
            this.Sunset.Location = new System.Drawing.Point(113, 312);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(77, 19);
            this.Sunset.TabIndex = 18;
            this.Sunset.Text = "Sunset:";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrise.ForeColor = System.Drawing.Color.White;
            this.lab_sunrise.Location = new System.Drawing.Point(201, 278);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(46, 19);
            this.lab_sunrise.TabIndex = 19;
            this.lab_sunrise.Text = "N/A";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunset.ForeColor = System.Drawing.Color.White;
            this.lab_sunset.Location = new System.Drawing.Point(201, 312);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(46, 19);
            this.lab_sunset.TabIndex = 20;
            this.lab_sunset.Text = "N/A";
            // 
            // Windspeed
            // 
            this.Windspeed.AutoSize = true;
            this.Windspeed.BackColor = System.Drawing.Color.Transparent;
            this.Windspeed.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Windspeed.ForeColor = System.Drawing.Color.White;
            this.Windspeed.Location = new System.Drawing.Point(475, 278);
            this.Windspeed.Name = "Windspeed";
            this.Windspeed.Size = new System.Drawing.Size(116, 19);
            this.Windspeed.TabIndex = 21;
            this.Windspeed.Text = "Wind Speed:";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.ForeColor = System.Drawing.Color.White;
            this.Pressure.Location = new System.Drawing.Point(475, 312);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(96, 19);
            this.Pressure.TabIndex = 22;
            this.Pressure.Text = "Pressure:";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.BackColor = System.Drawing.Color.Transparent;
            this.lab_windspeed.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_windspeed.ForeColor = System.Drawing.Color.White;
            this.lab_windspeed.Location = new System.Drawing.Point(594, 278);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(46, 19);
            this.lab_windspeed.TabIndex = 23;
            this.lab_windspeed.Text = "N/A";
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pressure.ForeColor = System.Drawing.Color.White;
            this.lab_pressure.Location = new System.Drawing.Point(581, 312);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(46, 19);
            this.lab_pressure.TabIndex = 24;
            this.lab_pressure.Text = "N/A";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(774, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 26);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = "x";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(475, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Temp Min:";
            // 
            // lab_tempmin
            // 
            this.lab_tempmin.AutoSize = true;
            this.lab_tempmin.BackColor = System.Drawing.Color.Transparent;
            this.lab_tempmin.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tempmin.ForeColor = System.Drawing.Color.White;
            this.lab_tempmin.Location = new System.Drawing.Point(581, 204);
            this.lab_tempmin.Name = "lab_tempmin";
            this.lab_tempmin.Size = new System.Drawing.Size(46, 19);
            this.lab_tempmin.TabIndex = 27;
            this.lab_tempmin.Text = "N/A";
            // 
            // lab_tempmax
            // 
            this.lab_tempmax.AutoSize = true;
            this.lab_tempmax.BackColor = System.Drawing.Color.Transparent;
            this.lab_tempmax.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tempmax.ForeColor = System.Drawing.Color.White;
            this.lab_tempmax.Location = new System.Drawing.Point(581, 236);
            this.lab_tempmax.Name = "lab_tempmax";
            this.lab_tempmax.Size = new System.Drawing.Size(46, 19);
            this.lab_tempmax.TabIndex = 28;
            this.lab_tempmax.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(475, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Temp Max:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(475, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Temperature:";
            // 
            // lab_temp
            // 
            this.lab_temp.AutoSize = true;
            this.lab_temp.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_temp.ForeColor = System.Drawing.Color.White;
            this.lab_temp.Location = new System.Drawing.Point(610, 142);
            this.lab_temp.Name = "lab_temp";
            this.lab_temp.Size = new System.Drawing.Size(46, 19);
            this.lab_temp.TabIndex = 31;
            this.lab_temp.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(475, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Feels Like:";
            // 
            // lab_feelslike
            // 
            this.lab_feelslike.AutoSize = true;
            this.lab_feelslike.BackColor = System.Drawing.Color.Transparent;
            this.lab_feelslike.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_feelslike.ForeColor = System.Drawing.Color.White;
            this.lab_feelslike.Location = new System.Drawing.Point(587, 173);
            this.lab_feelslike.Name = "lab_feelslike";
            this.lab_feelslike.Size = new System.Drawing.Size(46, 19);
            this.lab_feelslike.TabIndex = 33;
            this.lab_feelslike.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_feelslike);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_temp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab_tempmax);
            this.Controls.Add(this.lab_tempmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.lab_windspeed);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Windspeed);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.lab_detail);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.lab_condition);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lab_condition;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label Windspeed;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_tempmin;
        private System.Windows.Forms.Label lab_tempmax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_temp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_feelslike;
    }
}

