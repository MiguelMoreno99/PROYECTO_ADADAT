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
    public partial class FORM_CONTRA_REST : Form
    {
        public FORM_CONTRA_REST()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormLoginOper.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Operador op = new();
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                op.correo_electronico = VariablesGlobales.CorreoPersonaLogeada;
                op.contrasena_actual = TXT_CONTRASENA.Text;
                Operador opCorreo = new();
                opCorreo = listaOp.Find(op => op.correo_electronico == VariablesGlobales.CorreoPersonaLogeada);
                if ((opCorreo.contrasena_actual == TXT_CONTRASENA.Text) || (opCorreo.contrasena_anterior == TXT_CONTRASENA.Text) || (opCorreo.contrasena_anteanterior == TXT_CONTRASENA.Text))
                {
                    throw new FormatException("NO PUEDE PONER LA MISMA CONTRASEÑA QUE LAS ULTIMAS 3 CONTRASEÑAS");
                }
                else
                {
                    EnlaceCassandra.CambiarContrasenaOperador(VariablesGlobales.CorreoPersonaLogeada, TXT_CONTRASENA.Text);
                    VariablesGlobales.FormMenuOper.Show();
                    this.Hide();
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
