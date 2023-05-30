using Entidades;

namespace Aplicacion01
{
    public partial class FrmPasajerosDelVuelo : FrmBase
    {

        private Vuelo vuelo;

        public FrmPasajerosDelVuelo(Vuelo vuelo)
        {
            InitializeComponent();
            this.vuelo = vuelo;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmPasajerosDelVuelo_Load(object sender, EventArgs e)
        {
            this.dtgvPasajerosDelVuelo.DataSource = this.vuelo.Pasajeros;
        }
    }
}
