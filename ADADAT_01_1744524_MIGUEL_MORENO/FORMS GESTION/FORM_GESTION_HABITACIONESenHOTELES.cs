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
    public partial class FORM_GESTION_HABITACIONESenHOTELES : Form
    {
        public FORM_GESTION_HABITACIONESenHOTELES()
        {
            InitializeComponent();
        }

        private void FORM_GESTION_HABITACIONESenHOTELES_Load(object sender, EventArgs e)
        {
            List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
            LB_HOTELES.DataSource = listaHot;
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

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
            LB_HOTELES.DataSource = listaHot;
        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {

        }
    }
}
