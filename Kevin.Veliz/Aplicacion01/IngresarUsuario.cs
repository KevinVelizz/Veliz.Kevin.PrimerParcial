using Entidades;
using System.Text.Json;

namespace Aplicacion01
{
    public partial class IngresarUsuario : Form
    {
        public Usuario Usuario { get; private set; } // solo se puede setear desde IngresarUsuario.

        public IngresarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void IngresarUsuario_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Archivos.TryGetSolutionDirectoryInfo().Parent.FullName);
        }
        private void btnIngresar_Click(object sender, EventArgs e)
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
        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
            txtContraseña.Text = "";
        }
    }
}
