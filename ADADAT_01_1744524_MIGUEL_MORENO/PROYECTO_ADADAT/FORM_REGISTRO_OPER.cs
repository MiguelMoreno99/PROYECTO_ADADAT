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
    public partial class FORM_REGISTRO_OPER : Form
    {
        public FORM_REGISTRO_OPER()
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
            VariablesGlobales.FormLoginOper.Show();
            this.Hide();
        }

        private void BTN_REGISTRAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SE CAPTURÓ EL OPERADOR DE MANERA CORRECTA");
        }
    }
}
