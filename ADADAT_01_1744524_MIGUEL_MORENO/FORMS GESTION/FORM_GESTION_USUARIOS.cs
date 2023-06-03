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
    public partial class FORM_GESTION_USUARIOS : Form
    {
        public FORM_GESTION_USUARIOS()
        {
            InitializeComponent();
        }

        private void FORM_GESTION_USUARIOS_Load(object sender, EventArgs e)
        {
            try
            {
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                LB_CORREO.DataSource = listaOp;
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
                Operador Op = new();
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                Op = listaOp.Find(Op => Op.correo_electronico == LB_CORREO.Text);
                Op.nombre_completo = TXTB_NOMBRE.Text;
                Op.numero_nomina = long.Parse(TXTB_NOMINA.Text);
                Op.fecha_nacimiento = DTP_FECHANAC.Value.Date;
                Op.domicilio = TXTB_DOMICILIO.Text;
                Op.telefono_casa = int.Parse(TXTB_TELCASA.Text);
                Op.telefono_celular = long.Parse(TXTB_TELCEL.Text);
                EnlaceCassandra.EditarOperador(Op.correo_electronico, Op.nombre_completo, Op.numero_nomina, Op.fecha_nacimiento, Op.domicilio, Op.telefono_casa, Op.telefono_celular);
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
                EnlaceCassandra.EliminarOperador(LB_CORREO.Text);
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                LB_CORREO.DataSource = listaOp;
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
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                LB_CORREO.DataSource = listaOp;
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }

        private void LB_CORREO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Operador Op = new();
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                Op = listaOp.Find(Op => Op.correo_electronico == LB_CORREO.Text);
                TXTB_NOMBRE.Text = Op.nombre_completo;
                TXTB_NOMINA.Text = Op.numero_nomina.ToString();
                DTP_FECHANAC.Value = Op.fecha_nacimiento.Date;
                TXTB_DOMICILIO.Text = Op.domicilio;
                TXTB_TELCASA.Text = Op.telefono_casa.ToString();
                TXTB_TELCEL.Text = Op.telefono_celular.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
