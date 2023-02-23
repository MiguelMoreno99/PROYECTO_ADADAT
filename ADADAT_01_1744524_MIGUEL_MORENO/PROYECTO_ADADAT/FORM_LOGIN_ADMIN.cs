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
    public partial class FORM_LOGIN_ADMIN : Form
    {
        public FORM_LOGIN_ADMIN()
        {
            InitializeComponent();
        }

        private void FORM_LOGIN_ADMIN_Load(object sender, EventArgs e)
        {
            //this.FormClosing += new FormClosingEventHandler(CerrarDialogo);
        }

        //private void CerrarDialogo(object sender, EventArgs a)
        //{
        //    this.Hide();
        //    VariablesGlobales.FormMain.Show();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMain.Show();
            this.Hide();
        }
    }
}
