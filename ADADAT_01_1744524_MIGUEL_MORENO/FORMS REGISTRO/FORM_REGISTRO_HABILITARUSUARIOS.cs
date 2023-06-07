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
    public partial class FORM_REGISTRO_HABILITARUSUARIOS : Form
    {
        public FORM_REGISTRO_HABILITARUSUARIOS()
        {
            InitializeComponent();
        }

        private void FORM_REGISTRO_HABILITARUSUARIOS_Load(object sender, EventArgs e)
        {

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

        private void BTN_HABILITARUSUARIO_Click(object sender, EventArgs e)
        {
            try
            {
                Operador op = new();
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                op.correo_electronico = TXT_USUARIO.Text;
                if (listaOp.Count > 0)
                {
                    Operador opCorreo = new();
                    opCorreo = listaOp.Find(op => op.correo_electronico == TXT_USUARIO.Text);
                    if (opCorreo != null)
                    {
                        if (opCorreo.inhabilitado)
                        {
                            EnlaceCassandra.HabiliatarOperador(TXT_USUARIO.Text, opCorreo.contrasena_anterior, opCorreo.contrasena_actual);
                            TXT_USUARIO.Text = "";
                        }
                        else
                        {
                            throw new FormatException("EL CORREO INGRESADO NO ESTA DESHABILITADO!");
                        }
                    }
                    else
                    {
                        throw new FormatException("VERIFIQUE LOS DATOS CAPTURADOS!");
                    }
                }
                else
                {
                    throw new FormatException("NO HAY NINGUN OPERADOR DADO DE ALTA!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
