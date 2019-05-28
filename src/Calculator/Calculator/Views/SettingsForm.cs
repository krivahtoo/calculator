using System;
using System.Windows.Forms;
using Calculator.Sources;
using Calculator.Properties;

namespace Calculator.Views
{
    public partial class SettingsForm : System.Windows.Forms.Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBagroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogBaground = new ColorDialog();
            colorDialogBackground.ShowDialog();
            if(colorDialogBackground.ShowDialog() == DialogResult.OK)
            {
                selectedBagroundColor.Text = colorDialogBackground.Color.Name;
                Settings.Default.BagroundColour = colorDialogBaground.Color;
            }
        }

        private void buttonAnswerFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialogAnswer = new FontDialog();
            fontDialogAnswer.ShowDialog();
            if (fontDialogAnswer.ShowDialog() == DialogResult.OK)
            {
                selectedAnswerFont.Text = fontDialogAnswer.Font.Name + " " + fontDialogAnswer.Font.Size;
                Settings.Default.AnswerFont = fontDialogAnswer.Font;
            }
        }

        private void buttonButtonFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialogButton = new FontDialog();
            fontDialogButton.ShowDialog();
            if(fontDialogButton.ShowDialog() == DialogResult.OK)
            {
                selectedButtonFont.Text = fontDialogButton.Font.Name + " " + fontDialogButton.Font.Size;
                Settings.Default.ButtonFont = fontDialogButton.Font;
            }
        }

        private void buttonButtonBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogButtonBack = new ColorDialog();
            colorDialogButtonBack.ShowDialog();
            if(colorDialogButtonBack.ShowDialog() == DialogResult.OK)
            {
                selectedButtonBackColor.Text = colorDialogButtonBack.Color.Name;
                Settings.Default.ButtonBackColour = colorDialogButtonBack.Color;
            }
        }

        private void buttonButtonTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogButtonText = new ColorDialog();
            colorDialogButtonText.ShowDialog();
            if (colorDialogButtonText.ShowDialog() == DialogResult.OK)
            {
                selectedButtonTextColor.Text = colorDialogButtonText.Color.Name;
                Settings.Default.ButtonTextColour = colorDialogButtonText.Color;
            }
        }

        private void buttonOperatorTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogOperatorText = new ColorDialog();
            colorDialogOperatorText.ShowDialog();
            if (colorDialogOperatorText.ShowDialog() == DialogResult.OK)
            {
                selectedOperatorTextColor.Text = colorDialogOperatorText.Color.Name;
                Settings.Default.OperatorTextColour = colorDialogOperatorText.Color;
            }
        }

        private void buttonOperatorBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogOperatorBack = new ColorDialog();
            colorDialogOperatorBack.ShowDialog();
            if (colorDialogOperatorBack.ShowDialog() == DialogResult.OK)
            {
                selectedOperatorBackColor.Text = colorDialogOperatorBack.Color.Name;
                Settings.Default.OperatorBackColour = colorDialogOperatorBack.Color;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string caption = "Apply Changes";
            string message = "Are you sure you would like to apply the changes you made?";
            DialogResult Result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                Settings.Default.Save();
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.Close(); 
            }
        }
    }
}
