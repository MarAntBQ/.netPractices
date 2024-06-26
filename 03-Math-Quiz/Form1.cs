namespace _03_Math_Quiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1;
        int addend2;
        int minuend1;
        int minuend2;
        int multiplicand1;
        int multiplicand2;

        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;
            sum.Enabled = true;

            // Fill in the subtraction problem.
            minuend1 = randomizer.Next(1, 101);
            minuend2 = randomizer.Next(1, minuend1);
            minusLeftLabel.Text = minuend1.ToString();
            minusRightLabel.Text = minuend2.ToString();
            difference.Value = 0;
            difference.Enabled = true;

            // Fill in the multiplication problem.
            multiplicand1 = randomizer.Next(2, 11);
            multiplicand2 = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand1.ToString();
            timesRightLabel.Text = multiplicand2.ToString();
            product.Value = 0;
            product.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
        }
    }
}
