using System;
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
    public partial class FORM_LOGIN_ADMIN : Form
    {
        public FORM_LOGIN_ADMIN()
        {
            InitializeComponent();
        }

        private void FORM_LOGIN_ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VariablesGlobales.FormMain.Show();
            this.Hide();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            try
            {
                Administrador ad = new();
                List<Administrador> listaAd = EnlaceCassandra.HacerListaAdministradores();
                ad.correo_electronico = TXT_USUARIO.Text;
                ad.contrasena_actual = TXT_CONTRASEÑA.Text;
                if (listaAd.Count > 0)
                {
                    Administrador adCorreo = new();
                    adCorreo = listaAd.Find(ad => ad.correo_electronico == TXT_USUARIO.Text);
                    if (adCorreo != null)
                    {
                        if (adCorreo.contrasena_actual == TXT_CONTRASEÑA.Text)
                        {
                            VariablesGlobales.FormMenuAdmin.Show();
                            VariablesGlobales.CorreoPersonaLogeada = TXT_USUARIO.Text;
                            this.Hide();
                            Reservacion res = new();
                            List<Reservacion> listaRes = EnlaceCassandra.HacerListaReservaciones();
                            if (listaRes.Count > 0)
                            {
                                for (int i = 0; i < listaRes.Count; i++)
                                {
                                    TimeSpan DifDias = listaRes[i].fecha_inicial.Date - VariablesGlobales.FechaCheckInOut.Date;
                                    if (DifDias.Days < 0 && listaRes[i].reservacion_activa)
                                    {
                                        EnlaceCassandra.CancelarReservacionAutomatica(listaRes[i].id_reservacion, listaRes[i].id_habitacion_hotel);
                                    }
                                }
                            }
                        }
                        else
                        {
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
                    throw new FormatException("NO HAY NINGUN ADMINISTRADOR DADO DE ALTA!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
