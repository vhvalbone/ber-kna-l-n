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
            double m�nadsinkomst = double.Parse(textBox1.Text);

            double l�nefterskatt;
            double skatt;
            if (m�nadsinkomst <= 51158)
            {
                skatt = m�nadsinkomst * 0.30;
                l�nefterskatt = m�nadsinkomst - skatt;
            }
            else
            {
                skatt = (m�nadsinkomst - 51158) * 0.20 + (51158 * 0.30);
                l�nefterskatt = m�nadsinkomst - skatt;
            }


            label2.Text = $"L�nen du f�r efter all skatt: {l�nefterskatt:C}";
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