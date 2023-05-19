using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_ADADAT.CSharp_MainCode;


namespace PROYECTO_ADADAT
{
    public partial class FORM_REGISTRO_HOTELES : Form
    {
        public FORM_REGISTRO_HOTELES()
        {
            InitializeComponent();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMenuAdmin.Show();
            this.Hide();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel hot = new();
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                hot.nombre = TXT_NOMBRE.Text;
                hot.fecha_inicio = (DTP_INICIOOPERACIONES.Value).Date;
                hot.ciudad = TXT_CIUDAD.Text;
                hot.estado = TXT_ESTADO.Text;
                hot.pais = TXT_PAIS.Text;
                hot.domicilio = TXT_DOMICILIO.Text;
                hot.numero_pisos = int.Parse(TXT_NUMEROPISOS.Text);
                hot.zona_turistica = TXT_ZONATURISTICA.Text;
                hot.servicios_adicionales = TXT_SERVICIOSADICIONALES.Text;
                hot.caracteristicas = TXT_CARACERISTICASHOTEL.Text;
                if (listaHot.Count > 0)
                {
                    Hotel hot1 = new();
                    hot1 = listaHot.Find(hot => hot.nombre == TXT_NOMBRE.Text);
                    if (hot1 != null)
                        throw new FormatException("YA HAY UN HOTEL REGISTRADO CON ESE NOMBRE!");
                }
                EnlaceCassandra.RegistrarHotel(hot.nombre, hot.fecha_inicio, hot.ciudad, hot.estado, hot.pais, hot.domicilio, hot.numero_pisos, hot.zona_turistica, hot.servicios_adicionales, hot.caracteristicas);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }
    }
}
