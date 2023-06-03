using PROYECTO_ADADAT.CSharp_MainCode;
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
    public partial class FORM_GESTION_HOTELES : Form
    {
        public FORM_GESTION_HOTELES()
        {
            InitializeComponent();
        }

        private void FORM_GESTION_HOTELES_Load(object sender, EventArgs e)
        {
            try
            {
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                LB_NOMBRE_HOTEL.DataSource = listaHot;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
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

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                LB_NOMBRE_HOTEL.DataSource = listaHot;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel Hot = new();
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                Hot = listaHot.Find(Hot => Hot.nombre == LB_NOMBRE_HOTEL.Text);
                Hot.ciudad = TXT_CIUDAD.Text;
                Hot.estado = TXT_ESTADO.Text;
                Hot.pais = TXT_PAIS.Text;
                Hot.domicilio = TXT_DOMICILIO.Text;
                Hot.numero_pisos = int.Parse(TXT_NUMEROPISOS.Text);
                Hot.zona_turistica = TXT_ZONATURISTICA.Text;
                Hot.servicios_adicionales = TXT_SERVICIOSADICIONALES.Text;
                Hot.caracteristicas = TXT_CARACERISTICASHOTEL.Text;
                EnlaceCassandra.EditarHotel(Hot.nombre, Hot.ciudad, Hot.estado, Hot.pais, Hot.domicilio, Hot.numero_pisos, Hot.zona_turistica, Hot.servicios_adicionales, Hot.caracteristicas);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "VERIFIQUE LOS DATOS INGRESADOS");
            }
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                EnlaceCassandra.EliminarHotel(LB_NOMBRE_HOTEL.Text);
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                LB_NOMBRE_HOTEL.DataSource = listaHot;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void LB_NOMBRE_HOTEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Hotel Hot = new();
                List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                Hot = listaHot.Find(Hot => Hot.nombre == LB_NOMBRE_HOTEL.Text);
                TXT_CIUDAD.Text = Hot.ciudad;
                TXT_ESTADO.Text = Hot.estado;
                TXT_PAIS.Text = Hot.pais;
                TXT_DOMICILIO.Text = Hot.domicilio;
                TXT_NUMEROPISOS.Text = Hot.numero_pisos.ToString();
                TXT_ZONATURISTICA.Text = Hot.zona_turistica;
                TXT_SERVICIOSADICIONALES.Text = Hot.servicios_adicionales;
                TXT_CARACERISTICASHOTEL.Text = Hot.caracteristicas;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
