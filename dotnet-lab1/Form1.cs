namespace dotnet_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculation Calc = new Calculation();

            double xn, xk, h, a;

            xn = Convert.ToDouble(textBox1.Text);
            xk = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            a = Convert.ToDouble(textBox4.Text);

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();

            Calc.calc(xn, xk, h, a);

            for (int i = 0; i < Calc.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(Calc.xy[i, 0], 2).ToString(), Math.Round(Calc.xy[i, 1], 2).ToString());
                chart1.Series[0].Points.AddXY(Calc.xy[i, 0], Calc.xy[i, 1]);
            }
        }
    }
}
