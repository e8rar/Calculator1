namespace Calculator1
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double carp = number1 * number2;
            textBox3.Text = carp.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double difference = number1 - number2;
            textBox3.Text = difference.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double sum = number1 + number2;
            textBox3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double bol = number1 / number2;
            textBox3.Text = bol.ToString();
        }
    }
}
