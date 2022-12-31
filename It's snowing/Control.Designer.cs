namespace It_s_snowing
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.Start_Button = new System.Windows.Forms.Button();
            this.SnowThickness_Label = new System.Windows.Forms.Label();
            this.LoadSnow_Label = new System.Windows.Forms.Label();
            this.Language_Label = new System.Windows.Forms.Label();
            this.SnowThickness_Button0 = new It_s_snowing.Properties.ToggleButton();
            this.LoadSnow_Button1 = new It_s_snowing.Properties.ToggleButton();
            this.Language_Button2 = new It_s_snowing.Properties.ToggleButton();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.ForeColor = System.Drawing.Color.White;
            this.Start_Button.Location = new System.Drawing.Point(34, 137);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(125, 23);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "Show";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // SnowThickness_Label
            // 
            this.SnowThickness_Label.AutoSize = true;
            this.SnowThickness_Label.ForeColor = System.Drawing.Color.White;
            this.SnowThickness_Label.Location = new System.Drawing.Point(12, 9);
            this.SnowThickness_Label.Name = "SnowThickness_Label";
            this.SnowThickness_Label.Size = new System.Drawing.Size(82, 13);
            this.SnowThickness_Label.TabIndex = 2;
            this.SnowThickness_Label.Text = "Snow thickness";
            // 
            // LoadSnow_Label
            // 
            this.LoadSnow_Label.AutoSize = true;
            this.LoadSnow_Label.ForeColor = System.Drawing.Color.White;
            this.LoadSnow_Label.Location = new System.Drawing.Point(116, 9);
            this.LoadSnow_Label.Name = "LoadSnow_Label";
            this.LoadSnow_Label.Size = new System.Drawing.Size(65, 13);
            this.LoadSnow_Label.TabIndex = 4;
            this.LoadSnow_Label.Text = "Start at boot";
            // 
            // Language_Label
            // 
            this.Language_Label.AutoSize = true;
            this.Language_Label.ForeColor = System.Drawing.Color.White;
            this.Language_Label.Location = new System.Drawing.Point(12, 66);
            this.Language_Label.Name = "Language_Label";
            this.Language_Label.Size = new System.Drawing.Size(55, 13);
            this.Language_Label.TabIndex = 6;
            this.Language_Label.Text = "Language";
            // 
            // SnowThickness_Button0
            // 
            this.SnowThickness_Button0.AutoSize = true;
            this.SnowThickness_Button0.BackColor = System.Drawing.Color.White;
            this.SnowThickness_Button0.Location = new System.Drawing.Point(15, 28);
            this.SnowThickness_Button0.MinimumSize = new System.Drawing.Size(45, 22);
            this.SnowThickness_Button0.Name = "SnowThickness_Button0";
            this.SnowThickness_Button0.OffBackColor = System.Drawing.Color.Gray;
            this.SnowThickness_Button0.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.SnowThickness_Button0.OnBackColor = System.Drawing.Color.Green;
            this.SnowThickness_Button0.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.SnowThickness_Button0.Size = new System.Drawing.Size(45, 22);
            this.SnowThickness_Button0.TabIndex = 8;
            this.SnowThickness_Button0.UseVisualStyleBackColor = false;
            this.SnowThickness_Button0.Click += new System.EventHandler(this.Save);
            // 
            // LoadSnow_Button1
            // 
            this.LoadSnow_Button1.AutoSize = true;
            this.LoadSnow_Button1.BackColor = System.Drawing.Color.White;
            this.LoadSnow_Button1.Location = new System.Drawing.Point(119, 28);
            this.LoadSnow_Button1.MinimumSize = new System.Drawing.Size(45, 22);
            this.LoadSnow_Button1.Name = "LoadSnow_Button1";
            this.LoadSnow_Button1.OffBackColor = System.Drawing.Color.Gray;
            this.LoadSnow_Button1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.LoadSnow_Button1.OnBackColor = System.Drawing.Color.Green;
            this.LoadSnow_Button1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.LoadSnow_Button1.Size = new System.Drawing.Size(45, 22);
            this.LoadSnow_Button1.TabIndex = 9;
            this.LoadSnow_Button1.UseVisualStyleBackColor = false;
            this.LoadSnow_Button1.Click += new System.EventHandler(this.Save);
            // 
            // Language_Button2
            // 
            this.Language_Button2.AutoSize = true;
            this.Language_Button2.BackColor = System.Drawing.Color.White;
            this.Language_Button2.Location = new System.Drawing.Point(15, 85);
            this.Language_Button2.MinimumSize = new System.Drawing.Size(45, 22);
            this.Language_Button2.Name = "Language_Button2";
            this.Language_Button2.OffBackColor = System.Drawing.Color.Gray;
            this.Language_Button2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.Language_Button2.OnBackColor = System.Drawing.Color.Green;
            this.Language_Button2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.Language_Button2.Size = new System.Drawing.Size(45, 22);
            this.Language_Button2.TabIndex = 10;
            this.Language_Button2.UseVisualStyleBackColor = false;
            this.Language_Button2.Click += new System.EventHandler(this.Save);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(193, 172);
            this.Controls.Add(this.Language_Button2);
            this.Controls.Add(this.LoadSnow_Button1);
            this.Controls.Add(this.SnowThickness_Button0);
            this.Controls.Add(this.Language_Label);
            this.Controls.Add(this.LoadSnow_Label);
            this.Controls.Add(this.SnowThickness_Label);
            this.Controls.Add(this.Start_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Control";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label SnowThickness_Label;
        private System.Windows.Forms.Label LoadSnow_Label;
        private System.Windows.Forms.Label Language_Label;
        private Properties.ToggleButton SnowThickness_Button0;
        private Properties.ToggleButton LoadSnow_Button1;
        private Properties.ToggleButton Language_Button2;
    }
}