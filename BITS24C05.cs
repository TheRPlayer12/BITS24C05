using System.Data;
using System.Windows.Forms;

namespace BITS24C05
{
    public partial class BITS24C05 : Form
    {
        bool pwCal = false;
        bool AddCal = false;
        bool SubCal = false;
        bool MultiCal = false;
        bool DivCal = false;


        public BITS24C05()
        {
            InitializeComponent();
        }

        private void BITS24C05_Load(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (checkForErrors()) { return; }
            if (pwCal)
            {
                string[] splitinput = inputTxt.Text.Split('^');
                clearBtn_Click(sender, e);
                double num1 = double.Parse(splitinput[0]);
                double num2 = double.Parse(splitinput[1]);
                inputTxt.Text = Math.Pow(num1, num2).ToString();
                pwCal = false;
            }
            if (AddCal)
            {
                string[] splitinput = inputTxt.Text.Split('+');
                clearBtn_Click(sender, e);
                double num1 = double.Parse(splitinput[0]);
                double num2 = double.Parse(splitinput[1]);
                inputTxt.Text = (num1 + num2).ToString();
                AddCal = false;
            }
            if (SubCal)
            {
                string[] splitinput = inputTxt.Text.Split('-');
                clearBtn_Click(sender, e);
                double num1 = double.Parse(splitinput[0]);
                double num2 = double.Parse(splitinput[1]);
                inputTxt.Text = (num1 - num2).ToString();
                SubCal = false;
            }
            if (MultiCal)
            {
                string[] splitinput = inputTxt.Text.Split('*');
                clearBtn_Click(sender, e);
                double num1 = double.Parse(splitinput[0]);
                double num2 = double.Parse(splitinput[1]);
                inputTxt.Text = (num1 * num2).ToString();
                MultiCal = false;
            }
            if (DivCal)
            {
                string[] splitinput = inputTxt.Text.Split('/');
                clearBtn_Click(sender, e);
                double num1 = double.Parse(splitinput[0]);
                double num2 = double.Parse(splitinput[1]);
                inputTxt.Text = (num1 / num2).ToString();
                DivCal = false;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "+";
            AddCal = true;
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "-";
            SubCal = true;
        }

        private void mutiBtn_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "*";
            MultiCal = true;
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "/";
            DivCal = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputTxt.Text = null;
        }

        private void rootBtn_Click(object sender, EventArgs e)
        {
            if (checkForErrors()) { return; }
            double result = double.Parse(inputTxt.Text);
            result = Math.Sqrt(result);

            inputTxt.Text = result.ToString();
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "^";
            pwCal = true;
        }



        private void btn0_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            inputTxt.Text += "9";
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            inputTxt.Text += ".";
        }

        private void inputTxt_TextChanged(object sender, EventArgs e)
        {
            if (inputTxt.Text.Contains('^')) { pwCal = true; }
            else { pwCal = false; }
            if (inputTxt.Text.Contains('+')) { AddCal = true; }
            else { AddCal = false; }
            if (inputTxt.Text.Contains('-')) { SubCal = true; }
            else { SubCal = false; }
            if (inputTxt.Text.Contains('*')) { MultiCal = true; }
            else { MultiCal = false; }
            if (inputTxt.Text.Contains('/')) { DivCal = true; }
            else { DivCal = false; }
        }
        private bool checkForErrors()
        {
            var match = inputTxt.Text.IndexOfAny("1234567890+-*/^".ToCharArray()) != -1;
            if (match)
            {
                MessageBox.Show("E01 : Invalid Character(s)!");
            }
            return match;
        }

    }
}
