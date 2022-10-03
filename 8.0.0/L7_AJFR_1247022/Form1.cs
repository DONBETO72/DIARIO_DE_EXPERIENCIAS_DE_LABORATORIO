namespace L7_AJFR_1247022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            int A = 0;
            int B = 1;
            int C = 0;
            int i = 2; 
            string resultado = "";

            if(N > 0)
            {
                resultado = resultado + Convert.ToString(A) + ", ";

                if (N > 1)
                {
                    resultado = resultado + Convert.ToString(B) + ", ";

                    while (i < N)
                    {
                        C = A + B;
                        resultado = resultado + Convert.ToString(C) + ", ";
                        A=B;
                        B=C;
                        i=i + 1;
                    }

                    label3.Text = Convert.ToString(resultado);
                }

                else
                {
                    label3.Text = Convert.ToString(resultado);
                }
            }

            else
            {
                label3.Text = Convert.ToString(resultado);
            }

        }
    }
}