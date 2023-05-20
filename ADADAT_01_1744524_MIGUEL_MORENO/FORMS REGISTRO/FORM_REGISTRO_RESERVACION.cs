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

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_COBRAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_RFC.Text != "" && TXT_CIUDAD.Text != "" && CB_HOTELESDISPONIBLES.Text != "" && CB_HABITACIONESDISPONIBLES.Text != "" && CB_NUMEROPERSONAS.Text != "" && (TXT_DIAS.Text != ""  && int.Parse(TXT_DIAS.Text) > 0 ))
                {
                    HabitacionEnHotel habhot = new();
                    Cliente cl = new();
                    Hotel hot = new();
                    List<HabitacionEnHotel> listaHabHot = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                    List<Cliente> listaCl = EnlaceCassandra.HacerListaClientes();
                    List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                    habhot = listaHabHot.Find(hab => hab.id_habitacion_hotel == Guid.Parse(CB_HABITACIONESDISPONIBLES.Text));
                    hot = listaHot.Find(hot => hot.nombre == CB_HOTELESDISPONIBLES.Text);
                    cl = listaCl.Find(cl => cl.rfc == TXT_RFC.Text);
                    if (habhot != null && hot != null && cl != null)
                    {
                        if (int.Parse(CB_NUMEROPERSONAS.Text) > habhot.max_personas_habitacion)
                        {
                            throw new FormatException("EL NUMERO DE PERSONAS A HOSPEDAR ES MAYOR AL MAXIMO POR HABITACION!");
                        }
                        Reservacion res = new();
                        res.id_reservacion = Guid.NewGuid();
                        cl.id_reservacion.Add(res.id_reservacion);
                        res.fecha_inicial = (DTP_FECHAINICIAL.Value).Date;
                        res.fecha_final = (DTP_FECHAFINAL.Value).Date;
                        res.personas_hospedar = int.Parse(CB_NUMEROPERSONAS.Text);
                        res.anticipo = double.Parse(TXT_ANTICIPO.Text);
                        res.total_hospedaje = (habhot.precio_noche) * int.Parse(TXT_DIAS.Text);
                        EnlaceCassandra.RegistrarReservacion(res.id_reservacion, hot.id_hotel, habhot.id_habitacion_hotel, cl.id_cliente, cl.id_reservacion, res.fecha_inicial, res.fecha_final, res.personas_hospedar, res.anticipo, res.total_hospedaje);
                    }
                    else
                    {
                        throw new FormatException("LLENE TODOS LOS CAMPOS ANTES DE CONTINUAR!");
                    }
                }
                else
                {
                    throw new FormatException("PRIMERO INGRESE TODA LA INFORMACION PARA CREAR LA RESERVACION!");
                }

            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void BTN_BUSCARRFC_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_RFC.Text != "")
                {
                    List<Cliente> listaCl = EnlaceCassandra.HacerListaClientes();
                    if (listaCl.Count > 0)
                    {
                        Cliente cl = new();
                        cl = listaCl.Find(cl => cl.rfc == TXT_RFC.Text);
                        if (cl != null)
                        {
                            string NombreCompleto = cl.nombre + " " + cl.apellido_paterno + " " + cl.apellido_materno;
                            TXT_NOMBRE.Text = NombreCompleto;
                        }
                        else
                        {
                            throw new FormatException("NO HAY NINGUN CLIENTE CON ESE RFC!");
                        }
                    }
                    else
                    {
                        throw new FormatException("NO HAY NINGUN CLIENTE REGISTRADO!");
                    }
                }
                else
                {
                    throw new FormatException("INGRESE UN RFC!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void BTN_BUSCARHOTEL_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_CIUDAD.Text != "")
                {
                    List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
                    if (listaHot.Count > 0)
                    {
                        Hotel hot = new();
                        List<Hotel> listaHotCiu = EnlaceCassandra.HacerListaHoteles();
                        listaHotCiu = listaHot.FindAll(hot => hot.ciudad == TXT_CIUDAD.Text);
                        List<Hotel> listaHotCiuHab = EnlaceCassandra.HacerListaHoteles();
                        listaHotCiuHab = listaHotCiu.FindAll(hot => hot.habitaciones_en_hotel.Count != 0);
                        if (listaHotCiuHab.Count != 0)
                        {
                            CB_HOTELESDISPONIBLES.DataSource = listaHotCiuHab;
                        }
                        else if (listaHotCiu.Count == 0)
                        {
                            throw new FormatException("NO HAY NINGUN HOTEL CON ESA CIUDAD!");
                        }
                        else
                        {
                            throw new FormatException("EL HOTEL NO TIENE HABITACIONES REGISTRADAS!");
                        }
                    }
                    else
                    {
                        throw new FormatException("NO HAY NINGUN HOTEL REGISTRADO!");
                    }
                }
                else
                {
                    throw new FormatException("INGRESE UNA CIUDAD!");
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR VERIFIQUE LOS DATOS CAPTURADOS");
            }
        }

        private void CB_HOTELESDISPONIBLES_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hotel hot = new();
            List<Hotel> listaHot = EnlaceCassandra.HacerListaHoteles();
            hot = listaHot.Find(hot => hot.nombre == CB_HOTELESDISPONIBLES.Text);
            CB_HABITACIONESDISPONIBLES.DataSource = hot.habitaciones_en_hotel;
            string infoHot = "Fecha Inicio: " + hot.fecha_inicio + Environment.NewLine + "Ciudad: " + hot.ciudad + Environment.NewLine + "Estado: " + hot.estado + Environment.NewLine + "Pais: " + hot.pais
             + Environment.NewLine + "Domicilio: " + hot.domicilio + Environment.NewLine + "No. Pisos: " + hot.numero_pisos + Environment.NewLine + "Zona Turistica: " + hot.zona_turistica
             + Environment.NewLine + "Servicios Adicionales: " + hot.servicios_adicionales + Environment.NewLine + "Caracteristicas: " + hot.caracteristicas;
            TXT_CARACTERISTICAHOTEL.Text = infoHot;
        }

        private void CB_HABITACIONESDISPONIBLES_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabitacionEnHotel hab = new();
            List<HabitacionEnHotel> listaHab = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
            hab = listaHab.Find(hab => hab.id_habitacion_hotel == Guid.Parse(CB_HABITACIONESDISPONIBLES.Text));
            string infoHab = "Nombre Habitacion: " + hab.nombre_habitacion + Environment.NewLine + "Nivel Habitacion: " + hab.nombre_nivel_habitacion + Environment.NewLine + "Numero Camas: " + hab.numero_camas_habitacion
             + Environment.NewLine + "Tipo Camas: " + hab.tipo_cama_habitacion + Environment.NewLine + "Maximo de Personas: " + hab.max_personas_habitacion
             + Environment.NewLine + "Precio Noche: " + hab.precio_noche + Environment.NewLine + "Numero de Habitacion: " + hab.numero + Environment.NewLine + "Caracteristicas: " + hab.caracteristicas
             + hab.numero + Environment.NewLine + "Amenidades: " + hab.amenidades;
            TXT_CARACTERISTICASHABITACION.Text = infoHab;
            TXT_PRECIONOCHE.Text = hab.precio_noche.ToString();
        }

        private void DTP_FECHAINICIAL_ValueChanged(object sender, EventArgs e)
        {
            int totalDias = ((DTP_FECHAFINAL.Value).Date - (DTP_FECHAINICIAL.Value).Date).Days + 1;
            TXT_DIAS.Text = totalDias.ToString();
        }

        private void DTP_FECHAFINAL_ValueChanged(object sender, EventArgs e)
        {
            int totalDias = ((DTP_FECHAFINAL.Value).Date - (DTP_FECHAINICIAL.Value).Date).Days + 1;
            TXT_DIAS.Text = totalDias.ToString();
        }
    }
}
