namespace MyFirstProject
{
    public partial class Form1 : Form
    {

        int num1;
        int num2;
        string option;
        int result;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += zeroBtn.Text;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += oneBtn.Text;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += twoBtn.Text;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += threeBtn.Text;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += fourBtn.Text;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += fiveBtn.Text;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += sixBtn.Text;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += sevenBtn.Text;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += eightBtn.Text;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text += nineBtn.Text;
        }

        private void divsionBtn_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(resultTxt.Text);

            resultTxt.Text = "";
        }

        private void timesBtn_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(resultTxt.Text);

            resultTxt.Text = "";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(resultTxt.Text);

            resultTxt.Text = "";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(resultTxt.Text);

            resultTxt.Text = "";
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(resultTxt.Text);
            if (option.Equals("/"))
            {
                result = num1 / num2;
                resultTxt.Text = result.ToString();
            }
            if(option.Equals("*"))
            {
                result = num2 * num1;
                resultTxt.Text = result.ToString();
            }
            if (option.Equals("+"))
            {
                result = num1 + num2;
                resultTxt.Text = result.ToString();
            }
            if(option.Equals("-"))
            {
                result = num1 - num2;
                resultTxt.Text = result.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Text = string.Empty;
        }
    }
}
