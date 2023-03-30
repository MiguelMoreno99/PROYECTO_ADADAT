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
    public partial class FORM_REGISTRO_RESERVACION : Form
    {
        public FORM_REGISTRO_RESERVACION()
        {
            InitializeComponent();
        }

        private void FORM_REGISTRO_RESERVACION_Load(object sender, EventArgs e)
        {

        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMenuOper.Show();
            this.Hide();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creó la reservación correctamente codigo de Reservación: AGO323", "El cobre $200 pesos del Anticipo");
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
