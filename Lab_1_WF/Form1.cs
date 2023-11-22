namespace Lab_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double CalculateDeposit(double deposit, double procent, int amountOfYears)
        {
            double result = deposit * Math.Pow(1 + (procent / 100), amountOfYears);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double deposit;
            double procent;
            int amountOfYears;

            if (!double.TryParse(textBox1.Text, out deposit) || deposit != 1000)
            {
                MessageBox.Show("Enter a valid deposit amount of 1000!");
                return;
            }

            if (!double.TryParse(textBox2.Text, out procent) || procent != 4.5)
            {
                MessageBox.Show("Enter a valid interest rate of 4,5!");
                return;
            }

            if (!int.TryParse(textBox3.Text, out amountOfYears) || amountOfYears != 7)
            {
                MessageBox.Show("Enter a valid number of years, 7!");
                return;
            }

            double totalSum = CalculateDeposit(deposit, procent, amountOfYears);
            textBox4.Text = totalSum.ToString();
        }


    }
}