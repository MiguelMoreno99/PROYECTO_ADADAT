﻿using System;
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
    public partial class FORM_REGISTRO_CHECKOUT : Form
    {
        public FORM_REGISTRO_CHECKOUT()
        {
            InitializeComponent();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMenuOper.Show();
            this.Hide();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORM_REGISTRO_CHECKOUT_Load(object sender, EventArgs e)
        {

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormRegistroPagoReservacion.Show();
            this.Hide();
        }
    }
}