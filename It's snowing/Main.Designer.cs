namespace It_s_snowing
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SnowPanel = new System.Windows.Forms.Panel();
            this.SnowAnimation = new System.Windows.Forms.Timer(this.components);
            this.SnowPuddle = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SnowPanel
            // 
            this.SnowPanel.BackColor = System.Drawing.Color.White;
            this.SnowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SnowPanel.Location = new System.Drawing.Point(0, 449);
            this.SnowPanel.Name = "SnowPanel";
            this.SnowPanel.Size = new System.Drawing.Size(800, 1);
            this.SnowPanel.TabIndex = 0;
            this.SnowPanel.Visible = false;
            // 
            // SnowAnimation
            // 
            this.SnowAnimation.Enabled = true;
            this.SnowAnimation.Interval = 400;
            this.SnowAnimation.Tick += new System.EventHandler(this.SnowAnimation_Tick);
            // 
            // SnowPuddle
            // 
            this.SnowPuddle.Enabled = true;
            this.SnowPuddle.Interval = 3000;
            this.SnowPuddle.Tick += new System.EventHandler(this.SnowPuddle_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SnowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SnowPanel;
        private System.Windows.Forms.Timer SnowAnimation;
        private System.Windows.Forms.Timer SnowPuddle;
    }
}

