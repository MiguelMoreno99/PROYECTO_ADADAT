using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ADADAT
{
        public partial class FORM_REGISTRO_RESERVACION : Form
    {
        public FORM_REGISTRO_RESERVACION(Guid id_reservacion, DateTime fecha_inicial, DateTime fecha_final, int personas_hospedar, double anticipo, double total_hospedaje)
        {
            this.id_reservacion = id_reservacion;
            this.fecha_inicial = fecha_inicial;
            this.fecha_final = fecha_final;
            this.personas_hospedar = personas_hospedar;
            this.anticipo = anticipo;
            this.total_hospedaje = total_hospedaje;
        }

        private Guid id_reservacion { set; get; }
        private DateTime fecha_inicial { set; get; }
        private DateTime fecha_final { set; get; }
        private int personas_hospedar { set; get; }
        private double anticipo { set; get; }
        private double total_hospedaje { set; get; }

        public FORM_REGISTRO_RESERVACION()
        {
            InitializeComponent();
        }

        private void FORM_REGISTRO_RESERVACION_Load(object sender, EventArgs e)
        {

        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMenuOper.Show();
            this.Hide();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_COBRAR_Click(object sender, EventArgs e)
        {
            try
            {
                id_reservacion = Guid.NewGuid();
                fecha_inicial = (DTP_FECHAINICIAL.Value).Date;
                fecha_final = (DTP_FECHAFINAL.Value).Date;
                personas_hospedar = int.Parse(CB_NUMEROPERSONAS.Text);
                anticipo = double.Parse(TXT_ANTICIPO.Text);
                total_hospedaje = double.Parse(TXT_PRECIONOCHE.Text);
                EnlaceCassandra.RegistrarReservacion(id_reservacion,fecha_inicial,fecha_final,personas_hospedar,anticipo,total_hospedaje);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }
    }
}
