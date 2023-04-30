namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            this.btnCandado.ImageIndex = (this.btnCandado.ImageIndex == 0) ? 1   : 0;
            bool cambiar = (this.btnCandado.ImageIndex == 0) ? false : true;
            this.DesenfocarText(cambiar);
        }

        private void DesenfocarText(bool cambiar)
        {
            this.txtDolarDefault.Enabled = cambiar;
            this.txtEuroDefault.Enabled = cambiar;
            this.txtPesoDefault.Enabled = cambiar;
        }
    }
}