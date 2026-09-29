namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCommand.Items.Add("+");
            cmbCommand.Items.Add("-");
            cmbCommand.Items.Add("*");
            cmbCommand.Items.Add("/");

            cmbCommand.SelectedIndex = 0;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            decimal num1, num2, answer;

            if (!decimal.TryParse(txtNumberOne.Text, out num1) ||
                !decimal.TryParse(txtNumberTwo.Text, out num2))
            {
                MessageBox.Show("Duzgun eded daxil edin!");
                return;
            }

            if (cmbCommand.SelectedItem == null)
            {
                MessageBox.Show("Emeliyyat secin!");
                return;
            }

            string command = cmbCommand.SelectedItem.ToString();

            switch (command)
            {
                case "+":
                    answer = num1 + num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Sifira bolmek olmaz!");
                        return;
                    }
                    answer = num1 / num2;
                    break;

                default:
                    return;
            }

            lblAnswer.Text = "Answer: " + answer;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberOne.Text = "0";
            txtNumberTwo.Text = "0";
            cmbCommand.SelectedIndex = -1;
            lblAnswer.Text = "Answer: 0";
        }
    }
}
