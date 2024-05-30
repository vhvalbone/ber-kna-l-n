namespace Slut_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double månadsinkomst = double.Parse(textBox1.Text);

            double lönefterskatt;
            double skatt;
            if (månadsinkomst <= 51158)
            {
                skatt = månadsinkomst * 0.30;
                lönefterskatt = månadsinkomst - skatt;
            }
            else
            {
                skatt = (månadsinkomst - 51158) * 0.20 + (51158 * 0.30);
                lönefterskatt = månadsinkomst - skatt;
            }


            label2.Text = $"Lönen du får efter all skatt: {lönefterskatt:C}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Application.Exit();

        }
    }
}