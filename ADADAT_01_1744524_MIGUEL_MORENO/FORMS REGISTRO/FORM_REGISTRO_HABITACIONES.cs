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
    public partial class FORM_REGISTRO_HABITACIONES : Form
    {
        public FORM_REGISTRO_HABITACIONES()
        {
            InitializeComponent();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMenuAdmin.Show();
            this.Hide();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                Habitacion hab = new();
                List<Habitacion> listaHab = EnlaceCassandra.HacerListaHabitaciones();
                hab.nombre = TXT_NOMBRE.Text;
                hab.nivel = (CB_NIVEL.SelectedIndex) + 1;
                hab.nombre_nivel = CB_NIVEL.Text;
                hab.numero_camas = (CB_NUMEROCAMAS.SelectedIndex) + 1;
                hab.tipo_cama = TXT_TIPOCAMAS.Text;
                hab.max_personas = int.Parse(CB_PERSONAS.Text);
                if (listaHab.Count > 0)
                {
                    Habitacion hab1 = new();
                    hab1 = listaHab.Find(hab => hab.nombre == TXT_NOMBRE.Text);
                    if (hab1 != null)
                        throw new FormatException("YA HAY UNA HABITACION REGISTRADA CON ESE NOMBRE!");
                }
                EnlaceCassandra.RegistrarHabitacion(hab.nombre, hab.nivel, hab.nombre_nivel, hab.numero_camas, hab.tipo_cama, hab.max_personas);
                TXT_NOMBRE.Text = "";
                TXT_TIPOCAMAS.Text = "";
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {

        }
    }
}
