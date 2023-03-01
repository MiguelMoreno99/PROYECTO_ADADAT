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
    public partial class FORM_MENU_OPER : Form
    {
        public FORM_MENU_OPER()
        {
            InitializeComponent();
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMain.Show();
            this.Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hACERNUEVARESERVACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoReservaciones.Show();
            this.Hide();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoClientes.Show();
            this.Hide();
        }

        private void cHECKINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoCheckIn.Show();
            this.Hide();
        }

        private void cHECKOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoCheckOut.Show();
            this.Hide();
        }
    }
}
