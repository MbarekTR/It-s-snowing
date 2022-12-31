using It_s_snowing.Properties;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace It_s_snowing
{
    public partial class Control : Form
    {
        private readonly Main frm = new Main();

        #region private

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        public Control()
        {
            InitializeComponent();

            #region Settings

            SnowThickness_Button0.Checked = Settings.SnowThickness;
            LoadSnow_Button1.Checked = Settings.LoadSnow;
            Snow_Button.Checked = Settings.LoadSnow;
            Language_Button2.Checked = Settings.Language;

            if (Settings.Language == true)
            {
                SnowThickness_Label.Text = "Kar Kalınlığı";
                LoadSnow_Label.Text = "Açılışta başla";
                Language_Label.Text = "Dil";
                Snow_Label.Text = "Kar";

                Reload_Button.Text = "Yenile";
            }

            if (Settings.LoadSnow == true)
            {
                frm.Show();
            }

            #endregion
        }

        private void Save(object sender, EventArgs e)
        {
            ToggleButton toggleButton = (ToggleButton)sender;
            byte number = Convert.ToByte(toggleButton.Name.Substring(toggleButton.Name.Length - 1));

            if (toggleButton == sender)
            {
                if (toggleButton.CheckState == CheckState.Checked) Settings.SaveSettings(number, true);
                else Settings.SaveSettings(number, false);
            }

            Reload_Button.Visible = true;
        }

        #region Click - MouseMove

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reload_Button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GitHub_Label_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MbarekTR/It-s-snowing");
        }

        private void Hide_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Snow_Button_Click(object sender, EventArgs e)
        {
            if (Snow_Button.Checked == true) frm.Show();
            else frm.Hide();
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
