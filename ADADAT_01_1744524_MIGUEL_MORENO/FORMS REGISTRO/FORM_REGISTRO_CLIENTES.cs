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
    public partial class FORM_REGISTRO_CLIENTES : Form
    {
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
                Cliente cl = new();
                List<Cliente> listaCl = EnlaceCassandra.HacerListaClientes();
                cl.nombre = TXT_NOMBRE.Text;
                cl.apellido_paterno = TXT_PATERNO.Text;
                cl.apellido_materno = TXT_MATERNO.Text;
                cl.rfc = TXT_RFC.Text;
                cl.domicilio = TXT_DOMICILIO.Text;
                cl.correo_electronico = TXT_CORREO.Text;
                cl.telefono_casa = int.Parse(TXT_TELEFONOCASA.Text);
                cl.telefono_celular = Int64.Parse(TXT_TELEFONOCELULAR.Text);
                cl.referencia = TXT_REFERENCIA.Text;
                cl.estado_civil = CB_ESTADOCIVIL.Text;
                cl.fecha_nacimiento = (DTP_FECHANACIMIENTO.Value).Date;
                if (listaCl.Count > 0)
                {
                    Cliente cl1 = new();
                    cl1 = listaCl.Find(cl1 => cl1.rfc == TXT_RFC.Text);
                    if (cl1 != null)
                        throw new FormatException("YA HAY UN CLIENTE REGISTRADO CON ESE RFC!");
                }
                EnlaceCassandra.RegistrarCliente(cl.nombre, cl.apellido_paterno, cl.apellido_materno, cl.rfc, cl.domicilio, cl.correo_electronico, cl.telefono_casa, cl.telefono_celular, cl.referencia, cl.estado_civil, cl.fecha_nacimiento);
                TXT_CORREO.Text = "";
                TXT_DOMICILIO.Text = "";
                TXT_MATERNO.Text = "";
                TXT_NOMBRE.Text = "";
                TXT_PATERNO.Text = "";
                TXT_REFERENCIA.Text = "";
                TXT_RFC.Text = "";
                TXT_TELEFONOCASA.Text = "";
                TXT_TELEFONOCELULAR.Text = "";
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void BTN_GESTION_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormGestionClientes.Show();
            this.Hide();
        }
    }
}
