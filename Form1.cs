namespace money_convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n01, usd, aed, pkr;

            n01 = Convert.ToSingle(this.txt1.Text);

            usd = n01 / 324.21;
            aed = n01 / 88.27;
            pkr = n01 / 1.12;

            this.txt2.Text = usd.ToString();
            this.txt3.Text = aed.ToString();
            this.txt4.Text = pkr.ToString();

        }
    }
}