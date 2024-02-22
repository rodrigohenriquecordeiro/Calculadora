namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            Load += FrmCalculadora_Load;

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            textBox.Focus();
        }
    }
}
