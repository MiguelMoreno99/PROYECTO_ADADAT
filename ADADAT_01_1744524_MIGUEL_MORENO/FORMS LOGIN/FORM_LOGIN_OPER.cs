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
    public partial class FORM_LOGIN_OPER : Form
    {
        public FORM_LOGIN_OPER()
        {
            InitializeComponent();
        }

        private void FORM_LOGIN_OPER_Load(object sender, EventArgs e)
        {

        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMain.Show();
            this.Hide();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            try
            {
                Operador op = new();
                List<Operador> listaOp = EnlaceCassandra.HacerListaOperadores();
                op.correo_electronico = TXT_USUARIO.Text;
                op.contrasena_actual = TXT_CONTRASENA.Text;
                if (listaOp.Count > 0)
                {
                    Operador opCorreo = new();
                    opCorreo = listaOp.Find(op => op.correo_electronico == TXT_USUARIO.Text);
                    if (opCorreo != null)
                    {
                        if (opCorreo.contrasena_actual==TXT_CONTRASENA.Text)
                        {
                            VariablesGlobales.FormContraRest.Show();
                            VariablesGlobales.CorreoPersonaLogeada = TXT_USUARIO.Text;
                            this.Hide();
                        }
                        else
                        {
                            if (true)
                            {

                            }
                            throw new FormatException("CONTRASEÑA INCORRECTA");
                        }
                    }
                    else
                    {
                        throw new FormatException("VERIFIQUE LOS DATOS CAPTURADOS!");
                    }
                }
                else
                {
                    throw new FormatException("NO HAY NINGUN OPERADOR DADO DE ALTA!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
