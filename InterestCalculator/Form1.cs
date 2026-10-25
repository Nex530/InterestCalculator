namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double K0;
        double p;
        int n;
        double KnProstaSuma;
        double LProstaLihva;
        double KnSloznaSuma;
        double LSloznaLihva;

        private void button1_Click(object sender, EventArgs e)
        {
            K0 = double.Parse(textBox1.Text);
            p = double.Parse(textBox2.Text);
            n = int.Parse(textBox3.Text);
            KnProstaSuma = K0 * (1 + n * 1.0 * p / 100);
            KnSloznaSuma = K0 * Math.Pow((1 + p / 100), n);
            LProstaLihva = K0 * n * p / 100;
            LSloznaLihva = KnSloznaSuma - K0;

            string message = "";

            message += "Simple Interest:\r\n" +
                "Krajna suma: " + KnProstaSuma + "\r\n" +
                "Nachislena lihva: " + LProstaLihva + "\r\n" +
                "Razbivka po godini: " + "\r\n"
            ;



            for (int i = 1; i <= n; i++)
            {
                double curK = K0 * (1 + i * p / 100);
                message += "  Godina " + i + ": " + curK + "\r\n";
            }
            message += "\r\n \r\n";


            message += "Compound Interest:\r\n" +
                "Krajna suma: " + KnSloznaSuma + "\r\n" +
                "Nachislena lihva: " + LSloznaLihva + "\r\n" +
                "Razbivka po godini: " + "\r\n"
            ;



            for (int i = 1; i <= n; i++)
            {
                double curK = K0 * Math.Pow((1 + p / 100), i);
                message += "  Godina " + i + ": " + curK + "\r\n";
            }




            textBox4.Text = message;
        }
    }
}
