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
        List<Pasajero> pasajeros;
        List<Aeronave> aeronaves;
        List<Vuelo> vuelos;

        public Aerolineas()
        {
            InitializeComponent();
            this.pasajeros = new List<Pasajero>();
            this.aeronaves = new List<Aeronave>();
            this.vuelos = new List<Vuelo>();
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
                    this.StripAgregarPasajero.Enabled = false;
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

        private void agregarPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPasajero frmPasajero = new FrmPasajero();
            frmPasajero.ShowDialog();
            this.pasajeros.Add(frmPasajero.Pasajero);

            foreach (Pasajero pasajero in this.pasajeros)
            {
                MessageBox.Show(pasajero.Nombre);
            }
        }

        //private void ActualizarListaSupermercado()
        //{
        //    lstObjetos.DataSource = null;
        //    lstObjetos.DataSource = listaSupermercado;
        //}
    }
}