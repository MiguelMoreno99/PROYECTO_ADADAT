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
    public partial class FORM_REGISTRO_HABITACIONES : Form
    {
        public FORM_REGISTRO_HABITACIONES(string nombre, int nivel, string nombre_nivel, int numero_camas, string tipo_cama, int max_personas)
        {
            this.nombre = nombre;
            this.nivel = nivel;
            this.nombre_nivel = nombre_nivel;
            this.numero_camas = numero_camas;
            this.tipo_cama = tipo_cama;
            this.max_personas = max_personas;
        }

        private string nombre { set; get; }
        private int nivel { set; get; }
        private string nombre_nivel { set; get; }
        private int numero_camas { set; get; }
        private string tipo_cama { set; get; }
        private int max_personas { set; get; }

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
                nombre = TXT_NOMBRE.Text;
                nivel = (CB_NIVEL.SelectedIndex)+1;
                nombre_nivel = CB_NIVEL.Text;
                numero_camas = int.Parse(CB_NUMEROCAMAS.Text);
                tipo_cama = TXT_TIPOCAMAS.Text;
                max_personas = numero_camas = int.Parse(CB_PERSONAS.Text);
                EnlaceCassandra.RegistrarHabitacion(nombre, nivel, nombre_nivel, numero_camas, tipo_cama, max_personas);
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
