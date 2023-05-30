namespace Aplicacion01
{
    public partial class FrmBase : Form
    {

        protected bool cerrar;

        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }

        private void FrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cerrar == false)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.cerrar = true;
                this.Close();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Text = "--Seleccione--";
                }
            }
        }
    }
}
