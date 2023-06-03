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
    public partial class FORM_MENU_ADMIN : Form
    {
        public FORM_MENU_ADMIN()
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

        private void eDITARHOTELESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoHoteles.Show();
            this.Hide();
        }

        private void rEGISTROHABITACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoHabitaciones.Show();
            this.Hide();
        }

        private void aGREGARUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistroOper.Show();
            this.Hide();
        }

        private void cANCELARRESERVACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoCancelaciones.Show();
            this.Hide();
        }

        private void uSUARIOSINHABILITADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistroHabilitarUsuarios.Show();
            this.Hide();
        }

        private void rEPORTEDEOCUPACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormReporteOcupacion.Show();
            this.Hide();
        }

        private void rEPORTEDEVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormReporteVentas.Show();
            this.Hide();
        }

        private void rEPORTEHISTORIALDECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormReporteClientes.Show();
            this.Hide();
        }

        private void rESERVACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTROHABITACIONESENHOTELESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistoHabitacionesHoteles.Show();
            this.Hide();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormGestionUsuarios.Show();
            this.Hide();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormGestionClientes.Show();
            this.Hide();
        }

        private void hABITACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormGestionHabitaciones.Show();
            this.Hide();
        }

        private void hOTELESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormGestionHoteles.Show();
            this.Hide();
        }

        private void hABITACIONESENHOTELESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormGestionHabitacionesHoteles.Show();
            this.Hide();
        }

        private void rESERVACIONESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormGestionReservaciones.Show();
            this.Hide();
        }
    }
}
