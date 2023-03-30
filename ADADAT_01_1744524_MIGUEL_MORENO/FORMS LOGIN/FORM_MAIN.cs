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
    public partial class FORM_MAIN : Form
    {
        public FORM_MAIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_ADMIN_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormLoginAdmin.Show();
            this.Hide();
        }

        private void BTN_OPER_Click(object sender, EventArgs e)
        {
            
            VariablesGlobales.FormLoginOper.Show();
            this.Hide();
        }
    }
}
