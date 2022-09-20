namespace WinFormsApp1
{
    public partial class AvgCalcForm : Form
    {
        public AvgCalcForm()
        {
            InitializeComponent();
        }

        private void AvgCalcForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            // string[] inputs = { tbFirstInput.Text, tbSecondInput.Text, tbThirdInput.Text, tbFourthInput.Text, tbFifthInput.Text }
            if (tbFirstInput.Text == string.Empty || 
                tbSecondInput.Text == string.Empty || 
                tbThirdInput.Text == string.Empty ||
                tbFourthInput.Text == string.Empty ||
                tbFifthInput.Text == string.Empty)
            {
                MessageBox.Show("Please enter all 5 values");
                    return;
            }
            double firstInput = double.Parse(tbFirstInput.Text);
            double secondInput = double.Parse(tbSecondInput.Text);
            double thirdInput = double.Parse(tbThirdInput.Text);
            double fourthInput = double.Parse(tbFourthInput.Text);
            double fifthInput = double.Parse(tbFifthInput.Text);

            double responses = firstInput + secondInput + thirdInput + fourthInput + fifthInput;
            double avgCalc = responses / 5;

            output.Text = avgCalc.ToString();
        }


        private void submit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbFirstInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbSecondInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbThirdInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbFourthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbFifthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            output.Text = "";
            tbFirstInput.Text = "";
            tbSecondInput.Text = "";
            tbThirdInput.Text = "";
            tbFourthInput.Text = "";
            tbFifthInput.Text = "";
        }
    }
}