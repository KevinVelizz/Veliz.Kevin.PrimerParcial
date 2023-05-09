using Entidades;
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
    public partial class FrmVuelo : Form
    {
        DateTime fechaActual;

        public FrmVuelo()
        {
            InitializeComponent();
            this.fechaActual = DateTime.Now;

        }

        private void FrmVuelo_Load(object sender, EventArgs e)
        {
            //this.dtmDuracion.Value = Aerolinea.CalcularDuracion();
            this.dtmVuelo.MinDate = fechaActual.Date;
            this.lblHoraVuelo.Visible = false;
            this.lblDuracionVuelo.Visible = false;

        }

        private void dtmVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.lblHoraVuelo.Visible = true;
            this.lblDuracionVuelo.Visible = true;
            DateTime hora = dtmVuelo.Value;
            this.lblHoraVuelo.Text = hora.ToString();
            DateTime duracion = Aerolinea.CalcularDuracion(hora);
            this.lblDuracionVuelo.Text = duracion.ToString();
        }


    }
}
