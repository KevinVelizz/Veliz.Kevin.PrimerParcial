using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Text.Json.Serialization;
using Entidades;

namespace Aplicacion01
{
    public partial class Aerolineas : Form
    {
        Usuario usuario;

        public Aerolineas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Aerolineas_Load(object sender, EventArgs e)
        {
            IngresarUsuario ingresarUsuario = new IngresarUsuario();
            ingresarUsuario.ShowDialog();
            if (ingresarUsuario.DialogResult == DialogResult.OK)
            {
                this.usuario = ingresarUsuario.Usuario;
                if (this.usuario.Perfil == "administrador" || this.usuario.Perfil == "supervisor")
                {
                    this.StripVender.Visible = false;
                    this.StripVender.Enabled = false;
                }
                else if (this.usuario.Perfil == "vendedor")
                {
                    this.StripVender.Visible = true;
                    this.StripVender.Enabled = true;
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}