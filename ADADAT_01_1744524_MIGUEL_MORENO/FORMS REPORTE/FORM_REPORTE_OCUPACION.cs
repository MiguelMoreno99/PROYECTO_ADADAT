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
    public partial class FORM_REPORTE_OCUPACION : Form
    {
        public FORM_REPORTE_OCUPACION()
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

        private void FORM_REPORTE_OCUPACION_Load(object sender, EventArgs e)
        {

        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                List<Hotel> ListaHoteles = EnlaceCassandra.HacerListaHoteles();
                if (ListaHoteles.Count == 0)
                {
                    throw new FormatException("PARA VER EL REPORTE DEBE DE HABER POR LO MENOS 1 HOTEL CREADO!");
                }
                List<HabitacionEnHotel> ListaHabitacionesEnHoteles = EnlaceCassandra.HacerListaHabitacionesEnHoteles();
                if (ListaHabitacionesEnHoteles.Count == 0)
                {
                    throw new FormatException("PARA VER EL REPORTE DEBE DE HABER POR LO MENOS 1 HABITACION ASIGNADA A ALGUN HOTEL!");
                }
                List<Reservacion> ListaReservaciones = EnlaceCassandra.HacerListaReservaciones();
                List<Cliente> ListaClientes = EnlaceCassandra.HacerListaClientes();
                LV_OCUPACION.Items.Clear();
                LV_RESUMENOCUPACION.Items.Clear();

                for (int c = 0; c < ListaHoteles.Count; c++)
                {
                    int CantHab1Ocupadas = 0;
                    int CantHab1Desocupadas = 0;
                    int CantPersHab1 = 0;

                    int CantHab2Ocupadas = 0;
                    int CantHab2Desocupadas = 0;
                    int CantPersHab2 = 0;

                    int CantHab3Ocupadas = 0;
                    int CantHab3Desocupadas = 0;
                    int CantPersHab3 = 0;

                    int CantHab4Ocupadas = 0;
                    int CantHab4Desocupadas = 0;
                    int CantPersHab4 = 0;

                    int CantHab5Ocupadas = 0;
                    int CantHab5Desocupadas = 0;
                    int CantPersHab5 = 0;
                    for (int r = 0; r < ListaHoteles[c].habitaciones_en_hotel.Count; r++)
                    {
                        Hotel hotel1 = ListaHoteles[c];
                        HabitacionEnHotel habitacionEnHotel1 = new();
                        habitacionEnHotel1 = ListaHabitacionesEnHoteles.Find(habitacion1 => habitacion1.id_habitacion_hotel == hotel1.habitaciones_en_hotel[r]);
                        switch (habitacionEnHotel1.nivel_habitacion)
                        {
                            case 1:
                                {
                                    if (habitacionEnHotel1.ocupada)
                                    {
                                        CantHab1Ocupadas++;
                                        CantPersHab1 += habitacionEnHotel1.personas_hospedadas;
                                    }
                                    else
                                    {
                                        CantHab1Desocupadas++;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (habitacionEnHotel1.ocupada)
                                    {
                                        CantHab2Ocupadas++;
                                        CantPersHab2 += habitacionEnHotel1.personas_hospedadas;
                                    }
                                    else
                                    {
                                        CantHab2Desocupadas++;
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    if (habitacionEnHotel1.ocupada)
                                    {
                                        CantHab3Ocupadas++;
                                        CantPersHab3 += habitacionEnHotel1.personas_hospedadas;
                                    }
                                    else
                                    {
                                        CantHab3Desocupadas++;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (habitacionEnHotel1.ocupada)
                                    {
                                        CantHab4Ocupadas++;
                                        CantPersHab4 += habitacionEnHotel1.personas_hospedadas;
                                    }
                                    else
                                    {
                                        CantHab4Desocupadas++;
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    if (habitacionEnHotel1.ocupada)
                                    {
                                        CantHab5Ocupadas++;
                                        CantPersHab5 += habitacionEnHotel1.personas_hospedadas;
                                    }
                                    else
                                    {
                                        CantHab5Desocupadas++;
                                    }
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                    if (CantHab1Ocupadas + CantHab1Desocupadas > 0)
                    {
                        decimal TotalHabitaciones = CantHab1Ocupadas + CantHab1Desocupadas;
                        decimal porcentaje = (100 / TotalHabitaciones) * CantHab1Ocupadas;
                        string[] datosReporte =
                        {
                            (ListaHoteles[c].pais),
                            ("2023"),
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ("BASICA"),
                            ((CantHab1Ocupadas + CantHab1Desocupadas).ToString()),
                            ((CantPersHab1).ToString()),
                            ((porcentaje).ToString() + " %")
                        };
                        string[] ResumenReporte =
                        {
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ((porcentaje).ToString() + " %")
                        };
                        ListViewItem DatosReporte = new(datosReporte);
                        LV_OCUPACION.Items.Add(DatosReporte);
                        DatosReporte = new(ResumenReporte);
                        LV_RESUMENOCUPACION.Items.Add(DatosReporte);
                    }
                    if (CantHab2Ocupadas + CantHab2Desocupadas > 0)
                    {
                        decimal TotalHabitaciones = CantHab2Ocupadas + CantHab2Desocupadas;
                        decimal porcentaje = (100 / TotalHabitaciones) * CantHab2Ocupadas;
                        string[] datosReporte =
                        {
                            (ListaHoteles[c].pais),
                            ("2023"),
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ("MEDIA"),
                            ((CantHab2Ocupadas + CantHab2Desocupadas).ToString()),
                            ((CantPersHab2).ToString()),
                            ((porcentaje).ToString() + " %")
                        };
                        string[] ResumenReporte =
                        {
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ((porcentaje).ToString() + " %")
                        };
                        ListViewItem DatosReporte = new(datosReporte);
                        LV_OCUPACION.Items.Add(DatosReporte);
                        DatosReporte = new(ResumenReporte);
                        LV_RESUMENOCUPACION.Items.Add(DatosReporte);
                    }
                    if (CantHab3Ocupadas + CantHab3Desocupadas > 0)
                    {
                        decimal TotalHabitaciones = CantHab3Ocupadas + CantHab3Desocupadas;
                        decimal porcentaje = (100 / TotalHabitaciones) * CantHab3Ocupadas;
                        string[] datosReporte =
                        {
                            (ListaHoteles[c].pais),
                            ("2023"),
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ("PLUS"),
                            ((CantHab3Ocupadas + CantHab3Desocupadas).ToString()),
                            ((CantPersHab3).ToString()),
                            ((porcentaje).ToString() + " %")
                        };
                        string[] ResumenReporte =
                        {
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ((porcentaje).ToString() + " %")
                        };
                        ListViewItem DatosReporte = new(datosReporte);
                        LV_OCUPACION.Items.Add(DatosReporte);
                        DatosReporte = new(ResumenReporte);
                        LV_RESUMENOCUPACION.Items.Add(DatosReporte);
                    }
                    if (CantHab4Ocupadas + CantHab4Desocupadas > 0)
                    {
                        decimal TotalHabitaciones = CantHab4Ocupadas + CantHab4Desocupadas;
                        decimal porcentaje = (100 / TotalHabitaciones) * CantHab4Ocupadas;
                        string[] datosReporte =
                        {
                            (ListaHoteles[c].pais),
                            ("2023"),
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ("DELUXE"),
                            ((CantHab4Ocupadas + CantHab4Desocupadas).ToString()),
                            ((CantPersHab3).ToString()),
                            ((porcentaje).ToString() + " %")
                        };
                        string[] ResumenReporte =
                        {
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ((porcentaje).ToString() + " %")
                        };
                        ListViewItem DatosReporte = new(datosReporte);
                        LV_OCUPACION.Items.Add(DatosReporte);
                        DatosReporte = new(ResumenReporte);
                        LV_RESUMENOCUPACION.Items.Add(DatosReporte);
                    }
                    if (CantHab5Ocupadas + CantHab5Desocupadas > 0)
                    {
                        decimal TotalHabitaciones = CantHab5Ocupadas + CantHab5Desocupadas;
                        decimal porcentaje = (100 / TotalHabitaciones) * CantHab5Ocupadas;
                        string[] datosReporte =
                        {
                            (ListaHoteles[c].pais),
                            ("2023"),
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ("LUXURY"),
                            ((CantHab5Ocupadas + CantHab5Desocupadas).ToString()),
                            ((CantPersHab5).ToString()),
                            ((porcentaje).ToString() + " %")
                        };
                        string[] ResumenReporte =
                        {
                            (ListaHoteles[c].ciudad),
                            (ListaHoteles[c].nombre),
                            ((ListaHoteles[c].fecha_inicio.ToString()).Substring(3,7)),
                            ((porcentaje).ToString() + " %")
                        };
                        ListViewItem DatosReporte = new(datosReporte);
                        LV_OCUPACION.Items.Add(DatosReporte);
                        DatosReporte = new(ResumenReporte);
                        LV_RESUMENOCUPACION.Items.Add(DatosReporte);
                    }
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
