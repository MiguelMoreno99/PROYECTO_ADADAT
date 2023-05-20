﻿using System;
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
    public partial class FORM_REGISTRO_CANCELACIONES : Form
    {
        public FORM_REGISTRO_CANCELACIONES()
        {
            InitializeComponent();
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

        private void BTN_CANCELARRESERVACION_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_RESERVACION.Text == "")
                {
                    throw new FormatException("INGRESE ALGUNA RESERVACION!");
                }
                Guid reservacion = Guid.Parse(TXT_RESERVACION.Text);
                List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                if (listaRes.Count > 0)
                {
                    Reservacion res = new();
                    res = listaRes.Find(res => res.id_reservacion == reservacion);
                    if (res != null)
                    {
                        if (!res.reservacion_activa)
                        {
                            throw new FormatException("ESTA RESERVACION YA ESTA CANCELADA!");
                        }
                        else
                        {
                            EnlaceCassandra.CancelarReservacion(res.id_reservacion);
                        }
                    }
                    else
                    {
                        throw new FormatException("NO HAY NINGUNA RESERVACION CON ESE ID!");
                    }
                }
                else
                {
                    throw new FormatException("NO HAY NINGUNA RESERVACION CREADA!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
