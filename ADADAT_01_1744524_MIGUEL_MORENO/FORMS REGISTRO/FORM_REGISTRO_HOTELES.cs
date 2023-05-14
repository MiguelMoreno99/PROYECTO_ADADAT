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
    public partial class FORM_REGISTRO_HOTELES : Form
    {
        public FORM_REGISTRO_HOTELES(string nombre, DateTime fecha_inicio, string ciudad, string estado, string pais, string domicilio, int numero_pisos, string zona_turistica, string servicios_adicionales, string caracteristicas)
        {
            this.nombre = nombre;
            this.fecha_inicio = fecha_inicio;
            this.ciudad = ciudad;
            this.estado = estado;
            this.pais = pais;
            this.domicilio = domicilio;
            this.numero_pisos = numero_pisos;
            this.zona_turistica = zona_turistica;
            this.servicios_adicionales = servicios_adicionales;
            this.caracteristicas = caracteristicas;
        }

        private string nombre { set; get; }
        private DateTime fecha_inicio { set; get; }
        private string ciudad { set; get; }
        private string estado { set; get; }
        private string pais { set; get; }
        private string domicilio { set; get; }
        private int numero_pisos { set; get; }
        private string zona_turistica { set; get; }
        private string servicios_adicionales { set; get; }
        private string caracteristicas { set; get; }

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

        private void BTN_CARGARHABITACIONES_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoHabitacionesHoteles.Show();
            this.Hide();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = TXT_NOMBRE.Text;
                fecha_inicio = (DTP_INICIOOPERACIONES.Value).Date;
                ciudad = TXT_CIUDAD.Text;
                estado = TXT_ESTADO.Text;
                pais = TXT_PAIS.Text;
                domicilio = TXT_DOMICILIO.Text;
                numero_pisos = int.Parse(TXT_NUMEROPISOS.Text);
                zona_turistica = TXT_ZONATURISTICA.Text;
                servicios_adicionales = TXT_SERVICIOSADICIONALES.Text;
                caracteristicas = TXT_CARACERISTICASHOTEL.Text;
                List<int> habitaciones_en_hotel = new()
                {
                    1,
                    4,
                    6
                };
                EnlaceCassandra.RegistrarHotel(nombre, fecha_inicio, ciudad, estado, pais, domicilio, numero_pisos,zona_turistica,servicios_adicionales,caracteristicas,habitaciones_en_hotel);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }
    }
}
