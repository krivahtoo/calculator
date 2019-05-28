using System;
using System.Windows.Forms;

namespace Calculator.Views
{
    public partial class Main : System.Windows.Forms.Form
    {
        private double Value1 = 0;
        private double Value2 = 0;
        private string Operation = "";
        private double Result = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            LogForm.Log("Application started successfully.");
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string txt = "Are you sure you would like to close the Calculator?";
            string caption = "Close Calculator";
            var result = MessageBox.Show(txt, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //If the No button is pressed.
            if (result == DialogResult.No)
            {
                // Cancel the closure of the Calculator.
                e.Cancel = true;
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";
            }
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
                textBox.Text = textBox.Text + ".";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operationText.Text = "+";
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else if (Value1 == 0 && Value2 == 0)
            {
                Value1 = Convert.ToDouble(textBox.Text);
                textBox.Text = "0";
                Operation = "+";
                operationText.Text = "+";
            }
            else if (Value2 == 0 && Value1 != 0)
            {
                Value2 = Convert.ToDouble(textBox.Text);
                textBox.Text = "0";
                Operation = "+";
                operationText.Text = "+";
            }
            else
            {
                calculate();
                LogForm.Log($"Calculation performed: {Value1} {Operation} {Value2} = {Result}");
            }
        }

        private void buttonZero_Click_1(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text = textBox.Text + "0";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            Operation = "";
            Value1 = 0;
            Value2 = 0;
            LogForm.Log("Answer text box cleared.");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operationText.Text = "-";
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else if (Value1 == 0 && Value2 == 0)
            {
                Value1 = Convert.ToDouble(textBox.Text);
                textBox.Text = "0";
                Operation = "-";
                operationText.Text = "-";
            }
            else if (Value2 == 0 && Value1 != 0)
            {
                Value2 = Convert.ToDouble(textBox.Text);
                textBox.Text = "0";
                Operation = "-";
                operationText.Text = "-";
            }
            else
            {
                calculate();
                LogForm.Log($"Calculation performed: {Value1} {Operation} {Value2} = {Result}");
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operationText.Text = "*";
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else if (Value1 == 0 && Value2 == 0)
            {
                Value1 = Convert.ToDouble(textBox.Text);
                textBox.Text = "0";
                Operation = "*";
                operationText.Text = "*";
            }
            else if (Value2 == 0 && Value1 != 0)
            {
                Value2 = Convert.ToDouble(textBox.Text);
                textBox.Text = "0";
                Operation = "*";
                operationText.Text = "*";
            }
            else
            {
                calculate();
                LogForm.Log($"Calculation performed: {Value1} {Operation} {Value2} = {Result}");
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operationText.Text = "/";
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else if (Value1 == 0 && Value2 == 0)
            {
                Value1 = Convert.ToDouble(textBox.Text);
                Operation = "/";
                textBox.Text = "0";
                operationText.Text = "/";
            }
            else if (Value2 == 0 && Value1 != 0)
            {
                Value2 = Convert.ToDouble(textBox.Text);
                textBox.Text = "0";
                Operation = "/";
                operationText.Text = "/";
            }
            else
            {
                calculate();
                LogForm.Log($"Calculation performed: {Value1} {Operation} {Value2} = {Result}");
            }
        }
        private void calculate()
        {
            switch (Operation)
            {
                case "-":
                    Result = Value1 - Value2;
                    break;
                case "+":
                    Result = Value1 + Value2;
                    break;
                case "/":
                    Result = Value1 / Value2;
                    break;
                case "*":
                    Result = Value1 * Value2;
                    break;
            }
            operationText.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (Value1 != 0 && Value2 != 0)
            {
                calculate();
                LogForm.Log($"Calculation performed: {Value1} {Operation} {Value2} = {Result}");
                textBox.Text = Convert.ToString(Result);
            }
            else if(Value1 != 0 && Value2 == 0)
            {
                Value2 = Convert.ToDouble(textBox.Text);
                calculate();
                LogForm.Log($"Calculation performed: {Value1} {Operation} {Value2} = {Result}");
                textBox.Text = Convert.ToString(Result);
            }
            else if(Result != 0)
            {
                textBox.Text = Convert.ToString(Result);
            }
            else
            {
                MessageBox.Show("There are no values to calculate.");
                LogForm.Log("Error: No Values to Calculate");
            }
        }
        private void operationText_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            DialogResult result = aboutForm.ShowDialog();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            DialogResult result = logForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            DialogResult result = settingsForm.ShowDialog();
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if (main.TopMost == false)
            {
                main.TopMost = true;
                buttonTop.Text = "UnP&in";
            }
            else
            {
                main.TopMost = false;
                buttonTop.Text = "Pin";
                
            }
            main.Show();
        }
        private void buttonTop_GotFocus(object sender, EventArgs e)
        {
            string txt = "Pin this window to the top.";
            ToolTip toolTop = new ToolTip();
            toolTop.Show(txt,Main.ActiveForm);
        }
    }
}
