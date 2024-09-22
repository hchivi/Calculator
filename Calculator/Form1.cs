namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketQua = a + b;
            txtKQ.Text = ketQua.ToString();
        }
    }
}
