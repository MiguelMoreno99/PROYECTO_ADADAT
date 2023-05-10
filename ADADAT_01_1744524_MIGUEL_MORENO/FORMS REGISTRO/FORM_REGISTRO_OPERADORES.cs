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
    public partial class FORM_REGISTRO_OPERADORES : Form
    {
        public FORM_REGISTRO_OPERADORES(string correo_electronico, string contrasena_actual, string nombre_completo, Int64 numero_nomina, DateTime fecha_nacimiento, string domicilio, Int32 telefono_casa, Int64 telefono_celular)
        {
            this.correo_electronico = correo_electronico;
            this.contrasena_actual = contrasena_actual;
            this.nombre_completo = nombre_completo;
            this.numero_nomina = numero_nomina;
            this.fecha_nacimiento = fecha_nacimiento;
            this.domicilio = domicilio;
            this.telefono_casa = telefono_casa;
            this.telefono_celular = telefono_celular;

        }

        private string correo_electronico { set; get; }
        private string contrasena_actual { set; get; }
        private string nombre_completo { set; get; }
        private Int64 numero_nomina { set; get; }
        private DateTime fecha_nacimiento { set; get; }
        private string domicilio { set; get; }
        private Int32 telefono_casa { set; get; }
        private Int64 telefono_celular { set; get; }


        public FORM_REGISTRO_OPERADORES()
        {
            InitializeComponent();
        }

        private void FORM_REGISTO_OPER_Load(object sender, EventArgs e)
        {

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

        private void BTN_REGISTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                correo_electronico = TXTB_CORREO.Text;
                contrasena_actual = TXTB_CONTRASENA.Text;
                nombre_completo = TXTB_NOMBRE.Text;
                numero_nomina = Int64.Parse(TXTB_NOMINA.Text);
                fecha_nacimiento = (DTP_FECHANAC.Value).Date;
                domicilio = TXTB_DOMICILIO.Text;
                telefono_casa = Int32.Parse(TXTB_TELCASA.Text);
                telefono_celular = Int64.Parse(TXTB_TELCEL.Text);
                EnlaceCassandra.RegistrarOperador(correo_electronico, contrasena_actual, nombre_completo, numero_nomina, fecha_nacimiento, domicilio, telefono_casa, telefono_celular);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }
    }
}
