using Entidades;

namespace Aplicacion01
{
    public partial class IngresarUsuario : Form
    {
        public Usuario Usuario { get; private set; }

        public IngresarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void IngresarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar1_Click(object sender, EventArgs e)
        {
            Usuario? aux = Funcionalidades.Login(txtCorreo.Text, txtContraseña.Text);

            if (aux != null)
            {
                Usuario = aux;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al ingresar. Verifique los datos.");
            }
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
            txtContraseña.Text = "";
        }
    }
}
