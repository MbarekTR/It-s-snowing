using It_s_snowing.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace It_s_snowing
{
    public partial class Control : Form
    {
        private readonly Main frm = new Main();
        private string ButtonTextHide = "Hide", ButtonTextShow = "Show";
        public Control()
        {
            InitializeComponent();
            
            SnowThickness_Button0.Checked = Settings.SnowThickness;
            LoadSnow_Button1.Checked = Settings.LoadSnow;
            Language_Button2.Checked = Settings.Language;

            if (Settings.Language == true)
            {
                SnowThickness_Label.Text = "Kar Kalınlığı";
                LoadSnow_Label.Text = "Açılışta başla";
                Language_Label.Text = "Dil";
                ButtonTextHide = "Gizle";
                ButtonTextShow = "Göster";
            }

            if (Settings.LoadSnow == true)
            {
                frm.Show();
                Start_Button.Text = ButtonTextHide;
                Start_Button.BackColor = Color.FromArgb(64, 0, 0);
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (Start_Button.Text == ButtonTextShow)
            {
                frm.Show();
                Start_Button.Text = ButtonTextHide;
                Start_Button.BackColor = Color.FromArgb(64, 0, 0);

            }
            else
            {
                frm.Hide();
                Start_Button.Text = ButtonTextShow;
                Start_Button.BackColor = Color.FromArgb(0, 64, 0);
            }

        }

        private void Save(object sender, EventArgs e)
        {
            ToggleButton toggleButton = (ToggleButton)sender;
            byte number = Convert.ToByte(toggleButton.Name.Substring(toggleButton.Name.Length - 1));

            if (toggleButton == sender)
            {
                if (toggleButton.CheckState == CheckState.Checked)
                {
                    Settings.SaveSettings(number, true);
                }
                else
                {
                    Settings.SaveSettings(number, false);
                }
            }
        }
    }
}
