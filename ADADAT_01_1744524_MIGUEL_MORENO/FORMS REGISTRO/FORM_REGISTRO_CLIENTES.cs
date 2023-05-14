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
    public partial class FORM_REGISTRO_CLIENTES : Form
    {
        public FORM_REGISTRO_CLIENTES(string nombre, string apellido_paterno, string apellido_materno, string rfc, string domicilio, string correo_electronico, int telefono_casa, Int64 telefono_celular, string referencia, string estado_civil, DateTime fecha_nacimiento)
        {
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.rfc = rfc;
            this.domicilio = domicilio;
            this.correo_electronico = correo_electronico;
            this.telefono_casa = telefono_casa;
            this.telefono_celular = telefono_celular;
            this.referencia = referencia;
            this.estado_civil = estado_civil;
            this.fecha_nacimiento = fecha_nacimiento;
        }

        private string nombre { set; get; }
        private string apellido_paterno { set; get; }
        private string apellido_materno { set; get; }
        private string rfc { set; get; }
        private string domicilio { set; get; }
        private string correo_electronico { set; get; }
        private int telefono_casa { set; get; }
        private Int64 telefono_celular { set; get; }
        private string referencia { set; get; }
        private string estado_civil { set; get; }
        private DateTime fecha_nacimiento { set; get; }

        public FORM_REGISTRO_CLIENTES()
        {
            InitializeComponent();
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

        private void FORM_REGISTRO_CLIENTES_Load(object sender, EventArgs e)
        {

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = TXT_NOMBRE.Text;
                apellido_paterno = TXT_PATERNO.Text;
                apellido_materno = TXT_MATERNO.Text;
                rfc = TXT_RFC.Text;
                domicilio = TXT_DOMICILIO.Text;
                correo_electronico = TXT_CORREO.Text;
                telefono_casa = int.Parse(TXT_TELEFONOCASA.Text);
                telefono_celular = Int64.Parse(TXT_TELEFONOCELULAR.Text);
                referencia = TXT_REFERENCIA.Text;
                estado_civil = CB_ESTADOCIVIL.Text;
                fecha_nacimiento = (DTP_FECHANACIMIENTO.Value).Date;
                EnlaceCassandra.RegistrarCliente(nombre, apellido_paterno,apellido_materno, rfc, domicilio, correo_electronico, telefono_casa, telefono_celular, referencia, estado_civil, fecha_nacimiento);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }
    }
}
