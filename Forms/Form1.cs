namespace Forms
{
    public partial class Form1 : Form
    {
        string txtTeste;
        bool alternar = false;
        string txtParImpar;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtTeste = txtBox1.Text;
            lbl1.Text = txtTeste;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn2.ForeColor = Color.Black;
            alternar = !alternar;
            if (alternar)
            {
                btn2.BackColor = Color.Violet;
            }
            else
            {
                btn2.BackColor = SystemColors.Control;
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            string txtParImpar = txtBox1.Text;
            int numParImpar = int.Parse(txtParImpar);
            string resultParImpar = "É ímpar";

            if (numParImpar % 2 == 0)
            {
                resultParImpar = "É par";
            }
            lbl1.Text = resultParImpar;
        }
    }
}
