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
        Usuario[] usuarios;
        public IngresarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void IngresarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText(@"C:\Users\veliz\Desktop\Parcial\Kevin.Veliz\MOCK_DATA.json");
                // Deserializar el array JSON a un objeto Usuario
                usuarios = JsonConvert.DeserializeObject<Usuario[]>(json);
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
                if (usuario.Nombre == txtNombre.Text & usuario.Clave == txtClave.Text)
                {
                    encontro = true; break;
                }
            }

            if (encontro)
            {
                MessageBox.Show("accedió");
                this.Hide();

                Aerolineas aerolineas = new Aerolineas();
                aerolineas.ShowDialog();

                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }


        }
    }
}
