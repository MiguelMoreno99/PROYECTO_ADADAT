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
    public partial class FORM_REGISTRO_HABITACIONESenHOTELES : Form
    {
        public FORM_REGISTRO_HABITACIONESenHOTELES(string nombre_habitacion, int nivel_habitacion, string nombre_nivel_habitacion, int numero_camas_habitacion, string tipo_cama_habitacion, int max_personas_habitacion, double precio_noche, int numero, string caracteristicas, string amenidades)
        {
            this.nombre_habitacion = nombre_habitacion;
            this.nivel_habitacion = nivel_habitacion;
            this.nombre_nivel_habitacion = nombre_nivel_habitacion;
            this.numero_camas_habitacion = numero_camas_habitacion;
            this.tipo_cama_habitacion = tipo_cama_habitacion;
            this.max_personas_habitacion = max_personas_habitacion;
            this.precio_noche = precio_noche;
            this.numero = numero;
            this.caracteristicas = caracteristicas;
            this.amenidades = amenidades;
        }
        private string nombre_habitacion { set; get; }
        private int nivel_habitacion { set; get; }
        private string nombre_nivel_habitacion { set; get; }
        private int numero_camas_habitacion { set; get; }
        private string tipo_cama_habitacion { set; get; }
        private int max_personas_habitacion { set; get; }
        private double precio_noche { set; get; }
        private int  numero { set; get; }
        private string caracteristicas { set; get; }
        private string amenidades { set; get; }

        public FORM_REGISTRO_HABITACIONESenHOTELES()
        {
            InitializeComponent();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoHoteles.Show();
            this.Hide();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                nombre_habitacion = CB_HABITACIONES.Text;
                nivel_habitacion = 1;
                nombre_nivel_habitacion = "dato";
                numero_camas_habitacion = 1;
                tipo_cama_habitacion = "dato";
                max_personas_habitacion = 1;
                precio_noche = double.Parse(TXT_PRECIO.Text);
                numero = 100;
                caracteristicas = TXT_CARACTERISTICAS.Text;
                amenidades = TXT_AMENIDADES.Text;
                EnlaceCassandra.RegistrarHabitacionEnHotel(nombre_habitacion, nivel_habitacion, nombre_nivel_habitacion, numero_camas_habitacion, tipo_cama_habitacion, max_personas_habitacion, precio_noche, numero, caracteristicas, amenidades);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {

        }
    }
}
