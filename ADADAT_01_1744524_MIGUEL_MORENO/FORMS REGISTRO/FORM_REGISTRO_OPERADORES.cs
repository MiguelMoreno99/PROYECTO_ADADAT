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
//List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();


namespace PROYECTO_ADADAT
{
    public partial class FORM_REGISTRO_OPERADORES : Form
    {
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
                Operador op = new();
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                op.correo_electronico = TXTB_CORREO.Text;
                op.contrasena_actual = TXTB_CONTRASENA.Text;
                op.nombre_completo = TXTB_NOMBRE.Text;
                op.numero_nomina = Int64.Parse(TXTB_NOMINA.Text);
                op.fecha_nacimiento = (DTP_FECHANAC.Value).Date;
                op.domicilio = TXTB_DOMICILIO.Text;
                op.telefono_casa = Int32.Parse(TXTB_TELCASA.Text);
                op.telefono_celular = Int64.Parse(TXTB_TELCEL.Text);
                if (listaOp.Count > 0)
                {
                    Operador op1 = new();
                    op1 = listaOp.Find(op => op.correo_electronico == TXTB_CORREO.Text);
                    if (op1 != null)
                        throw new FormatException("CORREO ELECTRONICO YA REGISTRADO!");
                }
                EnlaceCassandra.RegistrarOperador(op.correo_electronico, op.contrasena_actual, op.nombre_completo, op.numero_nomina, op.fecha_nacimiento, op.domicilio, op.telefono_casa, op.telefono_celular);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }
    }
}
