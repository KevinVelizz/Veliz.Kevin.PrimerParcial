using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Text.Json.Serialization;
using Entidades;

namespace Aplicacion01
{
    public partial class Aerolineas : Form
    {
        List<Cliente> clientes;

        public Aerolineas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Aerolineas_Load(object sender, EventArgs e)
        {

        }


    }
}