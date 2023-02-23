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
    public partial class FORM_LOGIN_OPER : Form
    {
        public FORM_LOGIN_OPER()
        {
            InitializeComponent();
        }

        private void FORM_LOGIN_OPER_Load(object sender, EventArgs e)
        {
            //this.FormClosing += new FormClosingEventHandler(CerrarDialogo);
        }

        //private void CerrarDialogo(object sender, EventArgs a)
        //{
        //    this.Hide();
        //    VariablesGlobales.FormMain.Show();
        //}

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMain.Show();
            this.Hide();
        }
    }
}
