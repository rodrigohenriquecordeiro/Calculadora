namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Focus();
            btn_sete.Enabled = false;
        }
    }
}
