using System;
using System.Threading;
using System.Windows.Forms;

namespace It_s_snowing
{
    public partial class Main : Form
    {
        private int snow = 0;
        private SnowControl[] snowFlakes;

        public Main()
        {
            InitializeComponent();
            snowFlakes = new SnowControl[40];
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(RAMCleaning);
            thread.Start();
        }

        private void RAMCleaning()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Thread.Sleep(1000);
        }

        private void SnowAnimation_Tick(object sender, EventArgs e)
        {
            if (snow >= 40)
            {
                SnowAnimation.Stop();
                return;
            }
            snowFlakes[snow] = new SnowControl();
            Controls.Add(snowFlakes[snow]);
            snow++;
        }

        private void SnowPuddle_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SnowThickness == true)
            {
                SnowPanel.Visible = true;
                if (SnowPanel.Height <= 300)
                {
                    SnowPanel.Height++;
                }
            }
            else
            {
                SnowPanel.Visible = false;
                SnowPanel.Height = 0;
            }
        }
    }
}
