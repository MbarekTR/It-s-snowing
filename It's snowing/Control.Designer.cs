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
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SnowThickness_Label = new System.Windows.Forms.Label();
            this.LoadSnow_Label = new System.Windows.Forms.Label();
            this.Language_Label = new System.Windows.Forms.Label();
            this.Snow_Label = new System.Windows.Forms.Label();
            this.Reload_Button = new System.Windows.Forms.Button();
            this.GitHub_Label = new System.Windows.Forms.Label();
            this.Snow_Button = new It_s_snowing.Properties.ToggleButton();
            this.Language_Button2 = new It_s_snowing.Properties.ToggleButton();
            this.LoadSnow_Button1 = new It_s_snowing.Properties.ToggleButton();
            this.SnowThickness_Button0 = new It_s_snowing.Properties.ToggleButton();
            this.ControlBox_Panel = new System.Windows.Forms.Panel();
            this.Hide_Button = new System.Windows.Forms.Button();
            this.ControlBox_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Exit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.Location = new System.Drawing.Point(166, 0);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(20, 20);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "X";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // SnowThickness_Label
            // 
            this.SnowThickness_Label.ForeColor = System.Drawing.Color.White;
            this.SnowThickness_Label.Location = new System.Drawing.Point(5, 41);
            this.SnowThickness_Label.Name = "SnowThickness_Label";
            this.SnowThickness_Label.Size = new System.Drawing.Size(82, 13);
            this.SnowThickness_Label.TabIndex = 0;
            this.SnowThickness_Label.Text = "Snow thickness";
            this.SnowThickness_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadSnow_Label
            // 
            this.LoadSnow_Label.ForeColor = System.Drawing.Color.White;
            this.LoadSnow_Label.Location = new System.Drawing.Point(93, 41);
            this.LoadSnow_Label.Name = "LoadSnow_Label";
            this.LoadSnow_Label.Size = new System.Drawing.Size(81, 13);
            this.LoadSnow_Label.TabIndex = 0;
            this.LoadSnow_Label.Text = "Start at boot";
            this.LoadSnow_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Language_Label
            // 
            this.Language_Label.ForeColor = System.Drawing.Color.White;
            this.Language_Label.Location = new System.Drawing.Point(5, 98);
            this.Language_Label.Name = "Language_Label";
            this.Language_Label.Size = new System.Drawing.Size(55, 13);
            this.Language_Label.TabIndex = 0;
            this.Language_Label.Text = "Language";
            this.Language_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Snow_Label
            // 
            this.Snow_Label.ForeColor = System.Drawing.Color.White;
            this.Snow_Label.Location = new System.Drawing.Point(140, 101);
            this.Snow_Label.Name = "Snow_Label";
            this.Snow_Label.Size = new System.Drawing.Size(34, 13);
            this.Snow_Label.TabIndex = 0;
            this.Snow_Label.Text = "Snow";
            this.Snow_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Reload_Button
            // 
            this.Reload_Button.BackColor = System.Drawing.Color.Transparent;
            this.Reload_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Reload_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Reload_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reload_Button.ForeColor = System.Drawing.Color.White;
            this.Reload_Button.Location = new System.Drawing.Point(31, 156);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(125, 23);
            this.Reload_Button.TabIndex = 6;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = false;
            this.Reload_Button.Visible = false;
            this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
            // 
            // GitHub_Label
            // 
            this.GitHub_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHub_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.GitHub_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitHub_Label.ForeColor = System.Drawing.Color.White;
            this.GitHub_Label.Location = new System.Drawing.Point(0, 0);
            this.GitHub_Label.Name = "GitHub_Label";
            this.GitHub_Label.Size = new System.Drawing.Size(51, 20);
            this.GitHub_Label.TabIndex = 7;
            this.GitHub_Label.Text = "GitHub";
            this.GitHub_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GitHub_Label.Click += new System.EventHandler(this.GitHub_Label_Click);
            // 
            // Snow_Button
            // 
            this.Snow_Button.AutoSize = true;
            this.Snow_Button.BackColor = System.Drawing.Color.White;
            this.Snow_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Snow_Button.Location = new System.Drawing.Point(129, 117);
            this.Snow_Button.MinimumSize = new System.Drawing.Size(45, 22);
            this.Snow_Button.Name = "Snow_Button";
            this.Snow_Button.OffBackColor = System.Drawing.Color.Gray;
            this.Snow_Button.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.Snow_Button.OnBackColor = System.Drawing.Color.Green;
            this.Snow_Button.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.Snow_Button.Size = new System.Drawing.Size(45, 22);
            this.Snow_Button.TabIndex = 0;
            this.Snow_Button.UseVisualStyleBackColor = false;
            this.Snow_Button.Click += new System.EventHandler(this.Snow_Button_Click);
            // 
            // Language_Button2
            // 
            this.Language_Button2.AutoSize = true;
            this.Language_Button2.BackColor = System.Drawing.Color.White;
            this.Language_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Language_Button2.Location = new System.Drawing.Point(8, 117);
            this.Language_Button2.MinimumSize = new System.Drawing.Size(45, 22);
            this.Language_Button2.Name = "Language_Button2";
            this.Language_Button2.OffBackColor = System.Drawing.Color.Gray;
            this.Language_Button2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.Language_Button2.OnBackColor = System.Drawing.Color.Green;
            this.Language_Button2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.Language_Button2.Size = new System.Drawing.Size(45, 22);
            this.Language_Button2.TabIndex = 0;
            this.Language_Button2.UseVisualStyleBackColor = false;
            this.Language_Button2.Click += new System.EventHandler(this.Save);
            // 
            // LoadSnow_Button1
            // 
            this.LoadSnow_Button1.AutoSize = true;
            this.LoadSnow_Button1.BackColor = System.Drawing.Color.White;
            this.LoadSnow_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadSnow_Button1.Location = new System.Drawing.Point(129, 60);
            this.LoadSnow_Button1.MinimumSize = new System.Drawing.Size(45, 22);
            this.LoadSnow_Button1.Name = "LoadSnow_Button1";
            this.LoadSnow_Button1.OffBackColor = System.Drawing.Color.Gray;
            this.LoadSnow_Button1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.LoadSnow_Button1.OnBackColor = System.Drawing.Color.Green;
            this.LoadSnow_Button1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.LoadSnow_Button1.Size = new System.Drawing.Size(45, 22);
            this.LoadSnow_Button1.TabIndex = 0;
            this.LoadSnow_Button1.UseVisualStyleBackColor = false;
            this.LoadSnow_Button1.Click += new System.EventHandler(this.Save);
            // 
            // SnowThickness_Button0
            // 
            this.SnowThickness_Button0.AutoSize = true;
            this.SnowThickness_Button0.BackColor = System.Drawing.Color.White;
            this.SnowThickness_Button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SnowThickness_Button0.Location = new System.Drawing.Point(8, 60);
            this.SnowThickness_Button0.MinimumSize = new System.Drawing.Size(45, 22);
            this.SnowThickness_Button0.Name = "SnowThickness_Button0";
            this.SnowThickness_Button0.OffBackColor = System.Drawing.Color.Gray;
            this.SnowThickness_Button0.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.SnowThickness_Button0.OnBackColor = System.Drawing.Color.Green;
            this.SnowThickness_Button0.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.SnowThickness_Button0.Size = new System.Drawing.Size(45, 22);
            this.SnowThickness_Button0.TabIndex = 0;
            this.SnowThickness_Button0.UseVisualStyleBackColor = false;
            this.SnowThickness_Button0.Click += new System.EventHandler(this.Save);
            // 
            // ControlBox_Panel
            // 
            this.ControlBox_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ControlBox_Panel.Controls.Add(this.Hide_Button);
            this.ControlBox_Panel.Controls.Add(this.GitHub_Label);
            this.ControlBox_Panel.Controls.Add(this.Exit_Button);
            this.ControlBox_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBox_Panel.Location = new System.Drawing.Point(0, 0);
            this.ControlBox_Panel.Name = "ControlBox_Panel";
            this.ControlBox_Panel.Size = new System.Drawing.Size(186, 20);
            this.ControlBox_Panel.TabIndex = 8;
            this.ControlBox_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // Hide_Button
            // 
            this.Hide_Button.BackColor = System.Drawing.Color.Transparent;
            this.Hide_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Hide_Button.FlatAppearance.BorderSize = 0;
            this.Hide_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Hide_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Hide_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_Button.ForeColor = System.Drawing.Color.White;
            this.Hide_Button.Location = new System.Drawing.Point(146, 0);
            this.Hide_Button.Name = "Hide_Button";
            this.Hide_Button.Size = new System.Drawing.Size(20, 20);
            this.Hide_Button.TabIndex = 8;
            this.Hide_Button.Text = "-";
            this.Hide_Button.UseVisualStyleBackColor = false;
            this.Hide_Button.Click += new System.EventHandler(this.Hide_Button_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(186, 191);
            this.ControlBox = false;
            this.Controls.Add(this.ControlBox_Panel);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.Snow_Button);
            this.Controls.Add(this.Snow_Label);
            this.Controls.Add(this.Language_Button2);
            this.Controls.Add(this.LoadSnow_Button1);
            this.Controls.Add(this.SnowThickness_Button0);
            this.Controls.Add(this.Language_Label);
            this.Controls.Add(this.LoadSnow_Label);
            this.Controls.Add(this.SnowThickness_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ControlBox_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label SnowThickness_Label;
        private System.Windows.Forms.Label LoadSnow_Label;
        private System.Windows.Forms.Label Language_Label;
        private Properties.ToggleButton SnowThickness_Button0;
        private Properties.ToggleButton LoadSnow_Button1;
        private Properties.ToggleButton Language_Button2;
        private Properties.ToggleButton Snow_Button;
        private System.Windows.Forms.Label Snow_Label;
        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.Label GitHub_Label;
        private System.Windows.Forms.Panel ControlBox_Panel;
        private System.Windows.Forms.Button Hide_Button;
    }
}