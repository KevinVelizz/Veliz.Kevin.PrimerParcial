using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aplicacion01
{
    public partial class IngresarUsuario : Form
    {
        List<Usuario> usuarios;
        public IngresarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuarios = new List<Usuario>();
        }

        private void IngresarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                string jsonFilePath = @"C:\Users\veliz\Desktop\Veliz.Kevin.PrimerParcial\Kevin.Veliz\MOCK_DATA.json";

                // Crear un JsonReader a partir del archivo JSON
                using (StreamReader sr = new StreamReader(jsonFilePath))
                {
                    string json_str = sr.ReadToEnd();
                    this.usuarios = (List<Usuario>)System.Text.Json.JsonSerializer.Deserialize(json_str, typeof(List<Usuario>));

                    //foreach (Usuario usuario in this.usuarios)
                    //{
                    //    MessageBox.Show(usuario.Apellido);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Correo == txtCorreo.Text && usuario.Clave == txtContraseña.Text)
                {
                    encontro = true;
                    break;
                }
            }

            if (encontro)
            {
                MessageBox.Show("accedió");
                this.Hide();
                Aerolineas aerolineas = new Aerolineas();
                aerolineas.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
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
