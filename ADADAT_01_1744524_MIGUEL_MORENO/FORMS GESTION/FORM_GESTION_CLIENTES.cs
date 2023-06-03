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
    public partial class FORM_GESTION_CLIENTES : Form
    {
        public FORM_GESTION_CLIENTES()
        {
            InitializeComponent();
        }

        private void FORM_GESTION_CLIENTES_Load(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaCli = EnlaceCassandra.HacerListaClientes();
                LB_RFC.DataSource = listaCli;
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

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente Cli = new();
                List<Cliente> listaCli = EnlaceCassandra.HacerListaClientes();
                Cli = listaCli.Find(Cli => Cli.rfc == LB_RFC.Text);
                Cli.nombre = TXT_NOMBRE.Text;
                Cli.apellido_paterno = TXT_PATERNO.Text;
                Cli.apellido_materno = TXT_MATERNO.Text;
                Cli.domicilio = TXT_DOMICILIO.Text;
                Cli.correo_electronico = TXT_CORREO.Text;
                Cli.telefono_casa= int.Parse(TXT_TELEFONOCASA.Text);
                Cli.telefono_celular = long.Parse(TXT_TELEFONOCELULAR.Text);
                Cli.referencia = TXT_REFERENCIA.Text;
                Cli.estado_civil = CB_ESTADOCIVIL.Text;
                Cli.fecha_nacimiento = DTP_FECHANACIMIENTO.Value.Date;
                EnlaceCassandra.EditarCliente(Cli.id_cliente, Cli.nombre, Cli.apellido_paterno, Cli.apellido_materno, Cli.domicilio, Cli.correo_electronico, Cli.telefono_casa, Cli.telefono_celular, Cli.referencia, Cli.estado_civil, Cli.fecha_nacimiento);
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
                Cliente Cli = new();
                List<Cliente> listaCli = EnlaceCassandra.HacerListaClientes();
                Cli = listaCli.Find(Cli => Cli.rfc == LB_RFC.Text);
                EnlaceCassandra.EliminarCliente(Cli.id_cliente);
                listaCli = EnlaceCassandra.HacerListaClientes();
                LB_RFC.DataSource = listaCli;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaCli = EnlaceCassandra.HacerListaClientes();
                LB_RFC.DataSource = listaCli;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void LB_RFC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cliente Cli = new();
                List<Cliente> listaCli = EnlaceCassandra.HacerListaClientes();
                Cli = listaCli.Find(Cli => Cli.rfc == LB_RFC.Text);
                TXT_NOMBRE.Text = Cli.nombre;
                TXT_PATERNO.Text = Cli.apellido_paterno;
                TXT_MATERNO.Text = Cli.apellido_materno;
                TXT_DOMICILIO.Text = Cli.domicilio;
                TXT_CORREO.Text = Cli.correo_electronico;
                TXT_TELEFONOCASA.Text = Cli.telefono_casa.ToString();
                TXT_TELEFONOCELULAR.Text = Cli.telefono_celular.ToString();
                TXT_REFERENCIA.Text = Cli.referencia;
                CB_ESTADOCIVIL.Text = Cli.estado_civil;
                DTP_FECHANACIMIENTO.Value = Cli.fecha_nacimiento.Date;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
