using iTextSharp.text;
using iTextSharp.text.pdf;
using Liquidaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Liquidaciones
{
    /// <summary>
    /// Lógica de interacción para Liquidacionesdesueldoxaml.xaml
    /// </summary>
    public partial class Liquidacion : UserControl
    {

        public Liquidacion()
        {
            InitializeComponent();
        


            Meses.Items.Add("ENERO");
            Meses.Items.Add("FEBRERO");
            Meses.Items.Add("MARZO");
            Meses.Items.Add("ABRIL");
            Meses.Items.Add("MAYO");
            Meses.Items.Add("JUNIO");
            Meses.Items.Add("JULIO");
            Meses.Items.Add("AGOSTO");
            Meses.Items.Add("SEPTIEMBRE");
            Meses.Items.Add("OCTUBRE");
            Meses.Items.Add("NOVIEMBRE");
            Meses.Items.Add("DICIEMBRE");




            AFP.Items.Add("CAPITAL");
            AFP.Items.Add("CUPRUM");
            AFP.Items.Add("HABITAT");
            AFP.Items.Add("PLANVITAL");
            AFP.Items.Add("PROVIDA");
            AFP.Items.Add("MODELO");

            IMPRIMIR.IsEnabled = false;

            Sueldobase.IsEnabled = true;
            Ajuste.IsEnabled = true;
            cargas_familiar.IsEnabled = false;
            SemanaCorrida.IsEnabled = true;
            Tratos.IsEnabled = true;
            totalhorasextra.IsEnabled = false;
            Comision.IsEnabled = true;
            Gratificacion.IsEnabled = true;
            movilizacion.IsEnabled = true;
            colacion.IsEnabled = true;
            salud.IsEnabled = false;
            segurocesantia.IsEnabled = false;
            consin.IsEnabled = true;
            cargas.IsEnabled = true;
            horas.IsEnabled = true;
            totalhaber.IsEnabled = false;
            totalcotizacion.IsEnabled = false;
            AFP.IsEnabled = true;
            Meses.IsEnabled = true;
            porcentaje.IsEnabled = false;
            diferencia.IsEnabled = true;
            voluntaria.IsEnabled = true;
            prestamos.IsEnabled = true;
            
            porccesantia.IsEnabled = false;
            porcsalud.IsEnabled = false;
            TotalImponible.IsEnabled = false;
            valesoanticipos.IsEnabled = true;
            limpiar.IsEnabled = true;
            año.IsEnabled = true;

            parteuno.Visibility = Visibility.Hidden;
            partedos.Visibility = Visibility.Visible;


            //Cliente datos = new Cliente();

            //ruttrabajador.Text = datos.rut.ToString();
            //nombretrabajador.Text = datos.nombre.ToString();

            //Sueldobase.IsEnabled = false;
            //Ajuste.IsEnabled = false;
            //cargas_familiar.IsEnabled = false;
            //SemanaCorrida.IsEnabled = false;
            //Tratos.IsEnabled = false;
            //totalhorasextra.IsEnabled = false;
            //Comision.IsEnabled = false;
            //Gratificacion.IsEnabled = false;
            //movilizacion.IsEnabled = false;
            //colacion.IsEnabled = false;
            //salud.IsEnabled = false;
            //segurocesantia.IsEnabled = false;
            //consin.IsEnabled = false;
            //cargas.IsEnabled = false;
            //horas.IsEnabled = false;
            //totalhaber.IsEnabled = false;
            //totalcotizacion.IsEnabled = false;
            //AFP.IsEnabled = false;
            //Meses.IsEnabled = false;
            //porcentaje.IsEnabled = false;
            //diferencia.IsEnabled = false;
            //voluntaria.IsEnabled = false;
            //prestamos.IsEnabled = false;
            //año.IsEnabled = false;
            //porccesantia.IsEnabled = false;
            //porcsalud.IsEnabled = false;
            //TotalImponible.IsEnabled = false;
            //valesoanticipos.IsEnabled = false;

        }








        double HorasOrdinarias;
        double Sueldo;
        double HorasExtra;
        double Gratificacionn;
        double CargaFamiliar;
        double cargass;
        double TotalHaber;
        double cesantia;
        double totalremuneracionn;


        private void Sueldobase_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                HorasOrdinarias = ((Convert.ToDouble(Sueldobase.Text) / 30) * 28) / 180;

                if ((Convert.ToDouble(Sueldobase.Text) <= 277016))
                {
                    CargaFamiliar = 10844;

                }
                else
                {

                    if ((Convert.ToDouble(Sueldobase.Text) <= 404613))
                    {
                        CargaFamiliar = 6655;

                    }
                    else
                    {

                        if ((Convert.ToDouble(Sueldobase.Text) <= 631058))
                        {
                            CargaFamiliar = 2104;

                        }
                        else
                        {

                            if ((Convert.ToDouble(Sueldobase.Text) >= 631058))
                            {
                                CargaFamiliar = 0;
                                cargas_familiar.Text = CargaFamiliar.ToString();

                            }



                        }
                    }

                    double TotalImponiblee;



                    TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                    TotalImponible.Text = TotalImponiblee.ToString();


                    TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                    totalhaber.Text = TotalHaber.ToString();
                    totalremunercion1.Text = TotalHaber.ToString();


                    if (TotalImponiblee >= 2925532)
                    {


                        segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                    }
                    else
                    {


                        segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                    }

                    if (TotalImponiblee >= 1573458)
                    {


                        salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                    }
                    else
                    {


                        salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                    }
                    totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                    alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                    totalremuneracion.Text = totaldescuento.Text;
                    saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();

                    double numero1 = Convert.ToDouble(salud.Text);
                    numero1 = Math.Round(numero1);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    salud.Text = numero1.ToString("N0");

                    double numero = Convert.ToDouble(segurocesantia.Text);
                    numero = Math.Round(numero);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    segurocesantia.Text = numero.ToString("N0");

                    double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                    numero10ASS = Math.Round(numero10ASS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    totalremunercion1.Text = numero10ASS.ToString("N0");

                    double numero1AS = Convert.ToDouble(totaldescuento.Text);
                    numero1AS = Math.Round(numero1AS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    totaldescuento.Text = numero1AS.ToString("N0");

                    double numero13333 = Convert.ToDouble(saldoliquido.Text);
                    numero13333 = Math.Round(numero13333);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    saldoliquido.Text = numero13333.ToString("N0");

                    double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                    numero1SS = Math.Round(numero1SS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    alcanceliquido.Text = numero1SS.ToString("N0");
                }

               
            }
            catch
            {
            }

            
            
        }

        private void horas_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                HorasExtra = (HorasOrdinarias * 150) / 100;
                double total = Math.Round(HorasExtra * Convert.ToDouble(horas.Text));

                totalhorasextra.Text = total.ToString();

                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();


                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero1 = Convert.ToDouble(salud.Text);
                numero1 = Math.Round(numero1);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero1.ToString("N0");

                double numero = Convert.ToDouble(segurocesantia.Text);
                numero = Math.Round(numero);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }

            catch
            {

            }



        }

        private void cargas_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                cargass = Convert.ToInt32(cargas.Text);
                cargas_familiar.Text = (cargass * CargaFamiliar).ToString();

                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();

                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero1 = Convert.ToDouble(salud.Text);
                numero1 = Math.Round(numero1);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero1.ToString("N0");

                double numero = Convert.ToDouble(segurocesantia.Text);
                numero = Math.Round(numero);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {
            }
        }

        private void totalhorasextra_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();

                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero1 = Convert.ToDouble(salud.Text);
                numero1 = Math.Round(numero1);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero1.ToString("N0");

                double numero = Convert.ToDouble(segurocesantia.Text);
                numero = Math.Round(numero);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void Tratos_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();

                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero1 = Convert.ToDouble(salud.Text);
                numero1 = Math.Round(numero1);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero1.ToString("N0");

                double numero = Convert.ToDouble(segurocesantia.Text);
                numero = Math.Round(numero);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void SemanaCorrida_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();

                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero1 = Convert.ToDouble(salud.Text);
                numero1 = Math.Round(numero1);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero1.ToString("N0");

                double numero = Convert.ToDouble(segurocesantia.Text);
                numero = Math.Round(numero);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void Ajuste_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();

                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero1 = Convert.ToDouble(salud.Text);
                numero1 = Math.Round(numero1);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero1.ToString("N0");

                double numero = Convert.ToDouble(segurocesantia.Text);
                numero = Math.Round(numero);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void Comision_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();

                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero1 = Convert.ToDouble(salud.Text);
                numero1 = Math.Round(numero1);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero1.ToString("N0");

                double numero = Convert.ToDouble(segurocesantia.Text);
                numero = Math.Round(numero);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void Gratificacion_KeyUp(object sender, KeyEventArgs e)
        {

            if (Sueldo >= 1223125)
            {
                Gratificacionn = 101927;

                Gratificacion.Text = Gratificacionn.ToString();
            }
            //try
            //{
            //    double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
            //    TotalImponible.Text = TotalImponiblee.ToString();
            //    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * 0.6) / 100).ToString();
            //    salud.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * 7) / 100).ToString();
            //}
            //catch
            //{

        }


        private void consin_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void consin_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (consin.IsChecked != true)
                {
                    Gratificacionn = 0;

                    Gratificacion.Text = Gratificacionn.ToString();

                    double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                    TotalImponible.Text = TotalImponiblee.ToString();


                    TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                    totalhaber.Text = TotalHaber.ToString();
                    totalremunercion1.Text = TotalHaber.ToString();


                    if (TotalImponiblee >= 2925532)
                    {


                        segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                    }
                    else
                    {


                        segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                    }

                    if (TotalImponiblee >= 1573458)
                    {


                        salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                    }
                    else
                    {


                        salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                    }
                    totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                    alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                    totalremuneracion.Text = totaldescuento.Text;
                    saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                    double numero1 = Convert.ToDouble(salud.Text);
                    numero1 = Math.Round(numero1);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    salud.Text = numero1.ToString("N0");

                    double numero = Convert.ToDouble(segurocesantia.Text);
                    numero = Math.Round(numero);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    segurocesantia.Text = numero.ToString("N0");
                    double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                    numero10ASS = Math.Round(numero10ASS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    totalremunercion1.Text = numero10ASS.ToString("N0");

                    double numero1AS = Convert.ToDouble(totaldescuento.Text);
                    numero1AS = Math.Round(numero1AS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    totaldescuento.Text = numero1AS.ToString("N0");

                    double numero13333 = Convert.ToDouble(saldoliquido.Text);
                    numero13333 = Math.Round(numero13333);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    saldoliquido.Text = numero13333.ToString("N0");

                    double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                    numero1SS = Math.Round(numero1SS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    alcanceliquido.Text = numero1SS.ToString("N0");

                    double numero2SS = Convert.ToDouble(Gratificacion.Text);
                    numero2SS = Math.Round(numero2SS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    Gratificacion.Text = numero2SS.ToString("N0");

                }
                else
                {
                    Gratificacionn = Math.Round((Convert.ToDouble(Sueldobase.Text) * 25) / 100);

                    Gratificacion.Text = Gratificacionn.ToString();

                    double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                    TotalImponible.Text = TotalImponiblee.ToString();


                    TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                    totalhaber.Text = TotalHaber.ToString();
                    totalremunercion1.Text = TotalHaber.ToString();


                    if (TotalImponiblee >= 2925532)
                    {


                        segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                    }
                    else
                    {


                        segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                    }

                    if (TotalImponiblee >= 1573458)
                    {


                        salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                    }
                    else
                    {


                        salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                    }
                    totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                    alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                    totalremuneracion.Text = totaldescuento.Text;
                    saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                    double numero1 = Convert.ToDouble(salud.Text);
                    numero1 = Math.Round(numero1);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    salud.Text = numero1.ToString("N0");

                    double numero = Convert.ToDouble(segurocesantia.Text);
                    numero = Math.Round(numero);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    segurocesantia.Text = numero.ToString("N0");
                    double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                    numero10ASS = Math.Round(numero10ASS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    totalremunercion1.Text = numero10ASS.ToString("N0");

                    double numero1AS = Convert.ToDouble(totaldescuento.Text);
                    numero1AS = Math.Round(numero1AS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    totaldescuento.Text = numero1AS.ToString("N0");

                    double numero13333 = Convert.ToDouble(saldoliquido.Text);
                    numero13333 = Math.Round(numero13333);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    saldoliquido.Text = numero13333.ToString("N0");

                    double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                    numero1SS = Math.Round(numero1SS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    alcanceliquido.Text = numero1SS.ToString("N0");

                    double numero2SS = Convert.ToDouble(Gratificacion.Text);
                    numero2SS = Math.Round(numero2SS);
                    // puedes probas estas dos maneras de aplicar formato
                    // primera:
                    Gratificacion.Text = numero2SS.ToString("N0");

                }
            }
            catch
            {
            }
        }

        private void colacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();


                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void movilizacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();


                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();

                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");

            }
            catch
            {

            }
        }

        private void AFP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {


                if (AFP.SelectedIndex == 0)
                {
                    double capital;
                    double TotalImponiblee;


                    if ((Convert.ToDouble(TotalImponible.Text) >= 1951230))
                    {



                        capital = (11.44);

                        porcentaje.Text = capital.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(1951230) * capital) / 100).ToString();
                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();


                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");

                    }
                    else
                    {




                        capital = (11.44);

                        porcentaje.Text = capital.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * capital) / 100).ToString();
                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();


                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();


                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                }

                if (AFP.SelectedIndex == 1)
                {
                    double cuprum;
                    double TotalImponiblee;

                    if ((Convert.ToDouble(TotalImponible.Text) >= 1951230))
                    {



                        cuprum = (11.48);
                        porcentaje.Text = cuprum.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(1951230) * cuprum) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");
                        

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero2 = Convert.ToDouble(salud.Text);
                        numero2 = Math.Round(numero2);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero2.ToString("N0");

                        double numero22 = Convert.ToDouble(segurocesantia.Text);
                        numero22 = Math.Round(numero22);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero22.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                    else
                    {
                        cuprum = (11.48);
                        porcentaje.Text = cuprum.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * cuprum) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");
                        


                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero3 = Convert.ToDouble(salud.Text);
                        numero3 = Math.Round(numero3);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero3.ToString("N0");

                        double numero4 = Convert.ToDouble(segurocesantia.Text);
                        numero4 = Math.Round(numero4);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero4.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                }

                if (AFP.SelectedIndex == 2)
                {
                    double habital;
                    double TotalImponiblee;

                    if ((Convert.ToDouble(TotalImponible.Text) >= 1951230))
                    {


                        habital = (11.27);
                        porcentaje.Text = habital.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(1951230) * habital) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");
                        

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero5 = Convert.ToDouble(salud.Text);
                        numero5 = Math.Round(numero5);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero5.ToString("N0");

                        double numero6 = Convert.ToDouble(segurocesantia.Text);
                        numero6 = Math.Round(numero6);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero6.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                    else
                    {
                        habital = (11.27);
                        porcentaje.Text = habital.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * habital) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero10 = Convert.ToDouble(salud.Text);
                        numero10 = Math.Round(numero10);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero10.ToString("N0");

                        double numero100 = Convert.ToDouble(segurocesantia.Text);
                        numero100 = Math.Round(numero100);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero100.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                }

                if (AFP.SelectedIndex == 3)
                {
                    double plan;
                    double TotalImponiblee;

                    if ((Convert.ToDouble(TotalImponible.Text) >= 1951230))
                    {

                        plan = (10.41);
                        porcentaje.Text = plan.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(1951230) * plan) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero50 = Convert.ToDouble(salud.Text);
                        numero50 = Math.Round(numero50);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero50.ToString("N0");

                        double numero55 = Convert.ToDouble(segurocesantia.Text);
                        numero55 = Math.Round(numero55);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero55.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                    else
                    {
                        plan = (10.41);
                        porcentaje.Text = plan.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * plan) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero70 = Convert.ToDouble(salud.Text);
                        numero70 = Math.Round(numero70);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero70.ToString("N0");

                        double numero60 = Convert.ToDouble(segurocesantia.Text);
                        numero60 = Math.Round(numero60);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero60.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                }

                if (AFP.SelectedIndex == 4)
                {

                    double provida;
                    double TotalImponiblee;
                    if ((Convert.ToDouble(TotalImponible.Text) >= 1951230))
                    {


                        provida = (11.54);
                        porcentaje.Text = provida.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(1951230) * provida) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero600 = Convert.ToDouble(salud.Text);
                        numero600 = Math.Round(numero600);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero600.ToString("N0");

                        double numero77 = Convert.ToDouble(segurocesantia.Text);
                        numero77 = Math.Round(numero77);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero77.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                    else
                    {
                        provida = (11.54);
                        porcentaje.Text = provida.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * provida) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero91 = Convert.ToDouble(salud.Text);
                        numero91 = Math.Round(numero91);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero91.ToString("N0");

                        double numer5o = Convert.ToDouble(segurocesantia.Text);
                        numer5o = Math.Round(numer5o);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numer5o.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                }
                if (AFP.SelectedIndex == 5)
                {
                    double modelo;
                    double TotalImponiblee;
                    if ((Convert.ToDouble(TotalImponible.Text) >= 1951230))
                    {



                        modelo = (10.77);
                        porcentaje.Text = modelo.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(1951230) * modelo) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");


                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero85 = Convert.ToDouble(salud.Text);
                        numero85 = Math.Round(numero85);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero85.ToString("N0");

                        double numero855 = Convert.ToDouble(segurocesantia.Text);
                        numero855 = Math.Round(numero855);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero855.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");

                    }
                    else
                    {

                        modelo = (10.77);
                        porcentaje.Text = modelo.ToString();
                        totalcotizacion.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * modelo) / 100).ToString();

                        TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                        TotalImponible.Text = TotalImponiblee.ToString();

                        TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                        totalhaber.Text = TotalHaber.ToString();
                        totalremunercion1.Text = TotalHaber.ToString();
                        double numero1 = Convert.ToDouble(salud.Text);
                        numero1 = Math.Round(numero1);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero1.ToString("N0");

                        double numero = Convert.ToDouble(segurocesantia.Text);
                        numero = Math.Round(numero);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero.ToString("N0");

                        if (TotalImponiblee >= 2925532)
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                        }
                        else
                        {


                            segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                        }

                        if (TotalImponiblee >= 1573458)
                        {


                            salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                        }
                        else
                        {


                            salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                        }
                        totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                        alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                        totalremuneracion.Text = totaldescuento.Text;
                        saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                        double numero856 = Convert.ToDouble(salud.Text);
                        numero856 = Math.Round(numero856);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        salud.Text = numero856.ToString("N0");

                        double numero855 = Convert.ToDouble(segurocesantia.Text);
                        numero855 = Math.Round(numero855);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        segurocesantia.Text = numero855.ToString("N0");
                        double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                        numero10ASS = Math.Round(numero10ASS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totalremunercion1.Text = numero10ASS.ToString("N0");

                        double numero1AS = Convert.ToDouble(totaldescuento.Text);
                        numero1AS = Math.Round(numero1AS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        totaldescuento.Text = numero1AS.ToString("N0");

                        double numero13333 = Convert.ToDouble(saldoliquido.Text);
                        numero13333 = Math.Round(numero13333);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        saldoliquido.Text = numero13333.ToString("N0");

                        double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                        numero1SS = Math.Round(numero1SS);
                        // puedes probas estas dos maneras de aplicar formato
                        // primera:
                        alcanceliquido.Text = numero1SS.ToString("N0");
                    }
                }

            }
            catch
            {


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sueldobase.IsEnabled = true;
            Ajuste.IsEnabled = true;
            cargas_familiar.IsEnabled = false;
            SemanaCorrida.IsEnabled = true;
            Tratos.IsEnabled = true;
            totalhorasextra.IsEnabled = false;
            Comision.IsEnabled = true;
            Gratificacion.IsEnabled = false;
            movilizacion.IsEnabled = true;
            colacion.IsEnabled = true;
            salud.IsEnabled = false;
            segurocesantia.IsEnabled = false;
            consin.IsEnabled = true;
            cargas.IsEnabled = true;
            horas.IsEnabled = true;
            totalhaber.IsEnabled = false;
            totalcotizacion.IsEnabled = false;
            AFP.IsEnabled = true;
            Meses.IsEnabled = true;
            porcentaje.IsEnabled = false;
            diferencia.IsEnabled = true;
            voluntaria.IsEnabled = true;
            prestamos.IsEnabled = true;
            año.IsEnabled = false;
            porccesantia.IsEnabled = false;
            porcsalud.IsEnabled = false;
            TotalImponible.IsEnabled = false;
            valesoanticipos.IsEnabled = true; ;



        }

        private void diferencia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();

                ;
                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();


                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero856 = Convert.ToDouble(salud.Text);
                numero856 = Math.Round(numero856);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero856.ToString("N0");

                double numero855 = Convert.ToDouble(segurocesantia.Text);
                numero855 = Math.Round(numero855);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero855.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void voluntaria_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();
                //segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * 0.6) / 100).ToString();

                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();


                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero856 = Convert.ToDouble(salud.Text);
                numero856 = Math.Round(numero856);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero856.ToString("N0");

                double numero855 = Convert.ToDouble(segurocesantia.Text);
                numero855 = Math.Round(numero855);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero855.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void prestamos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();

                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();


                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }
                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                double numero856 = Convert.ToDouble(salud.Text);
                numero856 = Math.Round(numero856);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero856.ToString("N0");

                double numero855 = Convert.ToDouble(segurocesantia.Text);
                numero855 = Math.Round(numero855);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero855.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");
            }
            catch
            {

            }
        }

        private void valesoanticipos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();

            }
            catch { }
        }

        private void aguilnaldo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


                double TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                TotalImponible.Text = TotalImponiblee.ToString();
                //segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponible.Text) * 0.6) / 100).ToString();

                TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                totalhaber.Text = TotalHaber.ToString();
                totalremunercion1.Text = TotalHaber.ToString();

                if (TotalImponiblee >= 2925532)
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                }
                else
                {


                    segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                }

                if (TotalImponiblee >= 1573458)
                {


                    salud.Text = Math.Round((Convert.ToDouble(1573458) * 7) / 100).ToString();
                }
                else
                {


                    salud.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 7) / 100).ToString();
                }

                totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                totalremuneracion.Text = totaldescuento.Text;
                double numero856 = Convert.ToDouble(salud.Text);
                numero856 = Math.Round(numero856);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                salud.Text = numero856.ToString("N0");

                double numero855 = Convert.ToDouble(segurocesantia.Text);
                numero855 = Math.Round(numero855);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                segurocesantia.Text = numero855.ToString("N0");
                double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremunercion1.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(totaldescuento.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(saldoliquido.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                saldoliquido.Text = numero13333.ToString("N0");

                double numero1SS = Convert.ToDouble(alcanceliquido.Text);
                numero1SS = Math.Round(numero1SS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                alcanceliquido.Text = numero1SS.ToString("N0");

            }
            catch
            {

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
           
            string nombrearchivo = nombretrabajador.Text + "_" + ruttrabajador.Text + Meses.Text + año.Text;
            // Indicamos donde vamos a guardar el documento

            //PdfWriter writer = PdfWriter.GetInstance(doc,
            //                            new FileStream(@"C:\Users\Nelson Morales\Desktop\Nelson Morales\liquidaciones\" + nombrearchivo + ".pdf", FileMode.Create));
             PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\Users\Nelson Morales\Desktop\Nelson Morales\liquidaciones\" + nombrearchivo + ".pdf", FileMode.Create));
            
            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("LIQUIDACION DE SUELDO");
            doc.AddCreator("MATIAS MORALES");

            // Abrimos el archivo
            doc.Open();

            // Escribimos el encabezamiento en el documento
            iTextSharp.text.Paragraph jeje = new iTextSharp.text.Paragraph();
            jeje.Alignment = Element.ALIGN_CENTER;
            jeje.Font = FontFactory.GetFont("Arial", 9);
            jeje.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            doc.Add(jeje);



            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph();
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Font = FontFactory.GetFont("Arial", 9);
            paragraph.Add("L I Q U I D A C I O N   D E   S U E L D O");


            doc.Add(paragraph);



            iTextSharp.text.Paragraph paragraph1 = new iTextSharp.text.Paragraph();
            paragraph1.Alignment = Element.ALIGN_CENTER;
            paragraph1.Font = FontFactory.GetFont("Arial", 9);

            paragraph1.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            doc.Add(paragraph1);

            iTextSharp.text.Paragraph paragraph2 = new iTextSharp.text.Paragraph();
            paragraph2.Alignment = Element.ALIGN_LEFT;
            paragraph2.Font = FontFactory.GetFont("Arial", 9);
            paragraph2.Add("NOMBRE TRABAJADOR                         : " + nombretrabajador.Text);
                                   



            doc.Add(paragraph2);

            iTextSharp.text.Paragraph paragraph3 = new iTextSharp.text.Paragraph();
            paragraph3.Alignment = Element.ALIGN_LEFT;
            paragraph3.Font = FontFactory.GetFont("Arial", 9);
            paragraph3.Add("RUT TRABAJADOR                                 : " + ruttrabajador.Text);




            doc.Add(paragraph3);

            iTextSharp.text.Paragraph paragraph4 = new iTextSharp.text.Paragraph();
            paragraph4.Alignment = Element.ALIGN_LEFT;
            paragraph4.Font = FontFactory.GetFont("Arial", 9);
            paragraph4.Add("MES REMUNERADO                               : " + Meses.Text +" "+ año.Text);


            doc.Add(paragraph4);

            iTextSharp.text.Paragraph paragraph5 = new iTextSharp.text.Paragraph();
            paragraph5.Alignment = Element.ALIGN_CENTER;
            paragraph5.Font = FontFactory.GetFont("Arial", 9);
            paragraph5.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");



            doc.Add(paragraph5);

            iTextSharp.text.Paragraph paragraph6 = new iTextSharp.text.Paragraph();
            paragraph6.Alignment = Element.ALIGN_CENTER;
            paragraph6.Font = FontFactory.GetFont("Arial", 10);
            paragraph6.Add("DETALLE DE REMUNERACIÓN");


            doc.Add(paragraph6);

            iTextSharp.text.Paragraph paragraph7 = new iTextSharp.text.Paragraph();
            paragraph7.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            paragraph7.Font = FontFactory.GetFont("Arial", 9);



            paragraph7.Add("SUELDO BASE                                                     " + (Sueldobase.Text));




            doc.Add(paragraph7);

            iTextSharp.text.Paragraph paragraph8 = new iTextSharp.text.Paragraph();
            paragraph8.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            paragraph8.Font = FontFactory.GetFont("Arial", 9);
            paragraph8.Add("HORAS EXTRAS    "+ horas.Text +"                                " + totalhorasextra.Text);



            doc.Add(paragraph8);

            iTextSharp.text.Paragraph paragraph9 = new iTextSharp.text.Paragraph();
            paragraph9.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            paragraph9.Font = FontFactory.GetFont("Arial", 9);
            paragraph9.Add("TRATOS                                                          " + Tratos.Text);


            doc.Add(paragraph9);

            iTextSharp.text.Paragraph uno = new iTextSharp.text.Paragraph();
            uno.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            uno.Font = FontFactory.GetFont("Arial", 9);
            uno.Add("SEMANA CORRIDA                                                         " + SemanaCorrida.Text);


            doc.Add(uno);

            iTextSharp.text.Paragraph dos = new iTextSharp.text.Paragraph();
            dos.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            dos.Font = FontFactory.GetFont("Arial", 9);
            dos.Add("AJUSTE                                                                 " + Ajuste.Text);


            doc.Add(dos);

            iTextSharp.text.Paragraph tres = new iTextSharp.text.Paragraph();
            tres.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            tres.Font = FontFactory.GetFont("Arial", 9);
            tres.Add("COMISIONES                                                            " + Comision.Text);


            doc.Add(tres);

            iTextSharp.text.Paragraph cuatro = new iTextSharp.text.Paragraph();
            cuatro.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            cuatro.Font = FontFactory.GetFont("Arial", 9);
            cuatro.Add("GRATIFICACIÓN                                                       " + Gratificacion.Text);


            doc.Add(cuatro);

            iTextSharp.text.Paragraph TOTALHABER = new iTextSharp.text.Paragraph();
            TOTALHABER.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            TOTALHABER.Font = FontFactory.GetFont("Arial", 10);
            TOTALHABER.Add("                                TOTAL REMUNERACIÓN IMPONIBLE :  $ " + TotalImponible.Text);


            doc.Add(TOTALHABER);


                
            iTextSharp.text.Paragraph UNO = new iTextSharp.text.Paragraph();
            UNO.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            UNO.Font = FontFactory.GetFont("Arial", 9);
            UNO.Add(cargas.Text + " CARGA DE ASIGNACIÓN FAMILIAR                                        " + cargas_familiar.Text);


            doc.Add(UNO);

            iTextSharp.text.Paragraph DOS = new iTextSharp.text.Paragraph();
            DOS.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            DOS.Font = FontFactory.GetFont("Arial", 9);
            DOS.Add("BONO DE COLACIÓN                                                       " + colacion.Text);


            doc.Add(DOS);

            iTextSharp.text.Paragraph TRES = new iTextSharp.text.Paragraph();
            TRES.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            TRES.Font = FontFactory.GetFont("Arial", 9);
            TRES.Add("BONO DE MOVILIZACIÓN                                                  " + movilizacion.Text);




            doc.Add(TRES);

            iTextSharp.text.Paragraph LINEA = new iTextSharp.text.Paragraph();
            LINEA.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            LINEA.Font = FontFactory.GetFont("Arial", 9);
            LINEA.Add("AGUILNALDO                                                           " + aguilnaldo.Text);


            doc.Add(LINEA);

            iTextSharp.text.Paragraph CUATRO = new iTextSharp.text.Paragraph();
            CUATRO.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            CUATRO.Font = FontFactory.GetFont("Arial", 10);
            CUATRO.Add("                                                    TOTAL HABER :  $ " + totalhaber.Text);


            doc.Add(CUATRO);

            iTextSharp.text.Paragraph LINEA1 = new iTextSharp.text.Paragraph();
            LINEA1.Alignment = Element.ALIGN_CENTER;
            LINEA1.Font = FontFactory.GetFont("Arial", 9);
            LINEA1.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            doc.Add(LINEA1);


            iTextSharp.text.Paragraph CINCO = new iTextSharp.text.Paragraph();
            CINCO.Alignment = Element.ALIGN_CENTER;
            CINCO.Font = FontFactory.GetFont("Arial", 10);
            CINCO.Add("DESCUENTO DE CARGO DEL TRABAJADOR");


            doc.Add(CINCO);

            iTextSharp.text.Paragraph SEIS = new iTextSharp.text.Paragraph();
            SEIS.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            SEIS.Font = FontFactory.GetFont("Arial", 9);
            SEIS.Add(porcentaje.Text + "% COTIZACIÓN OBLIGATORIA "+ AFP.Text +"                                  " + totalcotizacion.Text);


            doc.Add(SEIS);

            iTextSharp.text.Paragraph SIETE = new iTextSharp.text.Paragraph();
            SIETE.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            SIETE.Font = FontFactory.GetFont("Arial", 9);
            SIETE.Add(porccesantia.Text + "% SEGURO DE CESANTIA                                     " + segurocesantia.Text);


            doc.Add(SIETE);

            iTextSharp.text.Paragraph OCHO = new iTextSharp.text.Paragraph();
            OCHO.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            OCHO.Font = FontFactory.GetFont("Arial", 9);
            OCHO.Add(porcsalud.Text + "% SALUD                                          " + salud.Text);


            doc.Add(OCHO);

            iTextSharp.text.Paragraph NUEVE = new iTextSharp.text.Paragraph();
            NUEVE.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            NUEVE.Font = FontFactory.GetFont("Arial", 9);
            NUEVE.Add("DIFERENCIA ISAPRE                                              " + diferencia.Text);


            doc.Add(NUEVE);

            iTextSharp.text.Paragraph DIES = new iTextSharp.text.Paragraph();
            DIES.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            DIES.Font = FontFactory.GetFont("Arial", 9);
            DIES.Add("COTIZACION VOLUNTARIA                                             " + voluntaria.Text);


            doc.Add(DIES);

            iTextSharp.text.Paragraph ONCE = new iTextSharp.text.Paragraph();
            ONCE.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            ONCE.Font = FontFactory.GetFont("Arial", 9);
            ONCE.Add("PRESTAMOS                                                         " + prestamos.Text);


            doc.Add(ONCE);

            iTextSharp.text.Paragraph DOCE = new iTextSharp.text.Paragraph();
            DOCE.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            DOCE.Font = FontFactory.GetFont("Arial", 10);
            DOCE.Add("                                             TOTAL DESCUENTOS : $ " + totaldescuento.Text);


            doc.Add(DOCE);

            iTextSharp.text.Paragraph TRECE = new iTextSharp.text.Paragraph();
            TRECE.Alignment = Element.ALIGN_CENTER;
            TRECE.Font = FontFactory.GetFont("Arial", 9);
            TRECE.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            doc.Add(TRECE);

            iTextSharp.text.Paragraph CATORCE = new iTextSharp.text.Paragraph();
            CATORCE.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            CATORCE.Font = FontFactory.GetFont("Arial", 9);
            CATORCE.Add("TOTAL REMUNERACIÓN                                           " + totalremunercion1.Text);


            doc.Add(CATORCE);

            iTextSharp.text.Paragraph QUINCE = new iTextSharp.text.Paragraph();
            QUINCE.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            QUINCE.Font = FontFactory.GetFont("Arial", 9);
            QUINCE.Add("TOTAL DESCUENTOS                                              " + totaldescuento.Text);


            doc.Add(QUINCE);

            iTextSharp.text.Paragraph DIECISEIS = new iTextSharp.text.Paragraph();
            DIECISEIS.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            DIECISEIS.Font = FontFactory.GetFont("Arial", 9);
            DIECISEIS.Add("ALCANCE LIQUIDO                                            " + alcanceliquido.Text);


            doc.Add(DIECISEIS);

            iTextSharp.text.Paragraph DIESISIETE = new iTextSharp.text.Paragraph();
            DIESISIETE.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            DIESISIETE.Font = FontFactory.GetFont("Arial", 9);
            DIESISIETE.Add("VALES O ANTICIPOS                                         " + valesoanticipos.Text);


            doc.Add(DIESISIETE);

            iTextSharp.text.Paragraph DIECIOCHO = new iTextSharp.text.Paragraph();
            DIECIOCHO.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            DIECIOCHO.Font = FontFactory.GetFont("Arial", 10);
            DIECIOCHO.Add("                                         SALDO LIQUIDO : $ " + saldoliquido.Text);




            doc.Add(DIECIOCHO);

            iTextSharp.text.Paragraph VEINTE = new iTextSharp.text.Paragraph();
            VEINTE.Alignment = Element.ALIGN_LEFT;
            VEINTE.Font = FontFactory.GetFont("Arial", 9);
            VEINTE.Add("SALDO LIQUIDO EN LETRAS : " + saldoliquidoenletras.Text);
            doc.Add(VEINTE);

            iTextSharp.text.Paragraph TRECE1 = new iTextSharp.text.Paragraph();
            TRECE1.Alignment = Element.ALIGN_CENTER;
            TRECE1.Font = FontFactory.GetFont("Arial", 9);
            //TRECE1.Add("__________________________________________________________________________________________________________");
            TRECE1.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            doc.Add(TRECE1);







            iTextSharp.text.Paragraph VEINTEUNO = new iTextSharp.text.Paragraph();
            VEINTEUNO.Alignment = Element.ALIGN_LEFT;
            VEINTEUNO.Font = FontFactory.GetFont("Arial", 9);
            VEINTEUNO.Add("CERTIFICO QUE  HE RECIBIDO DE : "+ empresa.Text +" A MI ENTERA SATISFACCIÓN EL SALDO LIQUIDO INDICANDO EN LA PRESENTE LIQUIDACIÓN Y NO TENGO CARGOS NI COBRO ALGUNO POSTERIOR QUE HACER, POR NINGUNO DE LOS CONCEPTOS COMPRENDIDOS EN ELLA");


            doc.Add(VEINTEUNO);

            iTextSharp.text.Paragraph VEINTIDOS = new iTextSharp.text.Paragraph();
            VEINTIDOS.Alignment = Element.ALIGN_RIGHT;
            VEINTIDOS.Font = FontFactory.GetFont("Arial", 9);
            VEINTIDOS.Add("");


            doc.Add(VEINTIDOS);

            iTextSharp.text.Paragraph VEINTIDOSS = new iTextSharp.text.Paragraph();
            VEINTIDOSS.Alignment = Element.ALIGN_RIGHT;
            VEINTIDOSS.Font = FontFactory.GetFont("Arial", 9);
            VEINTIDOSS.Add("                                                                                           ");


            doc.Add(VEINTIDOSS);

            iTextSharp.text.Paragraph VEINTIDOS1 = new iTextSharp.text.Paragraph();
            VEINTIDOS1.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            VEINTIDOS1.Font = FontFactory.GetFont("Arial", 9);
            VEINTIDOS1.Add("__________________________                                                                   _________________________");


            doc.Add(VEINTIDOS1);

            iTextSharp.text.Paragraph VEINTIDOS2 = new iTextSharp.text.Paragraph();
            VEINTIDOS2.Alignment = Element.ALIGN_JUSTIFIED_ALL;
            VEINTIDOS2.Font = FontFactory.GetFont("Arial", 9);
            VEINTIDOS2.Add("--- FIRMA DEL EMPLEADOR ---                                                                 ---FIRMA DEL TRABAJADOR---");
            


            doc.Add(VEINTIDOS2);


            doc.Close();
            writer.Close();


            MessageBox.Show("¡PDF creado!");

            Process.Start("C:\\Users\\Nelson Morales\\Desktop\\Nelson Morales\\liquidaciones\\" + nombrearchivo + ".pdf");

           


        }

        private void Sueldobase_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               

                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void Ajuste_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void SemanaCorrida_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void Tratos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void totalhorasextra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void Comision_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void Gratificacion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void movilizacion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void colacion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void diferencia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void prestamos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void voluntaria_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void cargas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void horas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void aguilnaldo_KeyDown(object sender, KeyEventArgs e)
        {
             try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void valesoanticipos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void limpiar_Click(object sender, RoutedEventArgs e)
        {

            Sueldobase.Text = "0";
            Ajuste.Text = "0";
            cargas_familiar.Text = "0";
            SemanaCorrida.Text = "0";
            Tratos.Text = "0";
            totalhorasextra.Text = "0";
            Comision.Text = "0";
            Gratificacion.Text = "0";
            movilizacion.Text = "0";
            colacion.Text = "0";
            salud.Text = "0";
            segurocesantia.Text = "0";

            cargas.Text = "0";
            horas.Text = "0";
            totalhaber.Text = "0";
            totalcotizacion.Text = "0";
            AFP.Text = "0";
            Meses.Text = "0";
            porcentaje.Text = "";
            diferencia.Text = "0";
            voluntaria.Text = "0";
            prestamos.Text = "0";
            año.Text = "2016";
            porccesantia.Text = "";
            porcsalud.Text = "";
            TotalImponible.Text = "0";
            valesoanticipos.Text = "0";
            totalremunercion1.Text = "0";
            totaldescuento.Text = "0";
            alcanceliquido.Text = "0";
            valesoanticipos.Text = "0";
            saldoliquido.Text = "0;";
            saldoliquidoenletras.Text = "";


        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(nombre.Text) || nombre.Text.Equals("") || !validarRut(rut.Text) || string.IsNullOrWhiteSpace(empresa.Text) || empresa.Text.Equals("") || Meses.Text.Equals(""))
                {

                    mensajeerror.Content = "*ERROR EN LOS CAMPOS ";







                }
                else
                {
                    mensajeerror.Content = "";
                    mensajeerror1.Content = "";
                    MessageBoxResult respuesta = System.Windows.MessageBox.Show("¿Crear liquidación?", "Salir", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question);



                    nombretrabajador.Text = nombre.Text;
                    ruttrabajador.Text = rut.Text;






                    if (respuesta == MessageBoxResult.No)
                    {

                        parteuno.Visibility = Visibility.Hidden;
                        partedos.Visibility = Visibility.Hidden;
                    }

                    if (respuesta == MessageBoxResult.Yes)
                    {
                        parteuno.Visibility = Visibility.Visible;
                        partedos.Visibility = Visibility.Hidden;
                    }









                }






            }
            catch
            {

            }

        }

        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        private void saldoliquidoenletras_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                

                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch
            {

            }
        }

        private void saldoliquidoenletras_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                IMPRIMIR.IsEnabled = true;
                double numero10ASS = Convert.ToDouble(totalhaber.Text);
                numero10ASS = Math.Round(numero10ASS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalhaber.Text = numero10ASS.ToString("N0");

                double numero1AS = Convert.ToDouble(TotalImponible.Text);
                numero1AS = Math.Round(numero1AS);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                TotalImponible.Text = numero1AS.ToString("N0");

                double numero13333 = Convert.ToDouble(totaldescuento.Text);
                numero13333 = Math.Round(numero13333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totaldescuento.Text = numero13333.ToString("N0");

                double numero1333 = Convert.ToDouble(totalremuneracion.Text);
                numero1333 = Math.Round(numero1333);
                // puedes probas estas dos maneras de aplicar formato
                // primera:
                totalremuneracion.Text = numero1333.ToString("N0");

            }catch{

            }


        }

        private void Sueldobase_LostFocus(object sender, RoutedEventArgs e)
        {
           
            double  numero = Convert.ToDouble (Sueldobase.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            Sueldobase.Text = numero.ToString("N0");
           
            
           
        }

        private void horas_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(totalhorasextra.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            totalhorasextra.Text = numero.ToString("N0");
        }

        private void Tratos_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(Tratos.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            Tratos.Text = numero.ToString("N0");
        }

        private void SemanaCorrida_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(SemanaCorrida.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            SemanaCorrida.Text = numero.ToString("N0");
        }

        private void Ajuste_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(Ajuste.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            Ajuste.Text = numero.ToString("N0");
        }

        private void Comision_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(Comision.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            Comision.Text = numero.ToString("N0");
        }

        private void Gratificacion_LostFocus(object sender, RoutedEventArgs e)
        {
           
        }

        private void cargas_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(cargas_familiar.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            cargas_familiar.Text = numero.ToString("N0");
        }

        private void colacion_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(colacion.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            colacion.Text = numero.ToString("N0");
        }

        private void movilizacion_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(movilizacion.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            movilizacion.Text = numero.ToString("N0");
        }

        private void aguilnaldo_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(aguilnaldo.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            aguilnaldo.Text = numero.ToString("N0");
        }

        private void AFP_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(totalcotizacion.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            totalcotizacion.Text = numero.ToString("N0");
        }

        private void segurocesantia_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void salud_LostFocus(object sender, RoutedEventArgs e)
        {
           
        
        }

        private void diferencia_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(diferencia.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            diferencia.Text = numero.ToString("N0");
        }

        private void voluntaria_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(voluntaria.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            voluntaria.Text = numero.ToString("N0");
        }

        private void prestamos_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(prestamos.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            prestamos.Text = numero.ToString("N0");
        }

        private void valesoanticipos_LostFocus(object sender, RoutedEventArgs e)
        {
            double numero = Convert.ToDouble(valesoanticipos.Text);
            numero = Math.Round(numero);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            valesoanticipos.Text = numero.ToString("N0");

            double numero10ASS = Convert.ToDouble(totalremunercion1.Text);
            numero10ASS = Math.Round(numero10ASS);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            totalremunercion1.Text = numero10ASS.ToString("N0");

            double numero1AS = Convert.ToDouble(totaldescuento.Text);
            numero1AS = Math.Round(numero1AS);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            totaldescuento.Text = numero1AS.ToString("N0");

            double numero1 = Convert.ToDouble(saldoliquido.Text);
            numero1 = Math.Round(numero1);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            saldoliquido.Text = numero1.ToString("N0");
            
            double numero1SS = Convert.ToDouble(alcanceliquido.Text);
            numero1SS = Math.Round(numero1SS);
            // puedes probas estas dos maneras de aplicar formato
            // primera:
            alcanceliquido.Text = numero1SS.ToString("N0");
            
        }

        private void año_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)


        {
             try
            {

                if (segurosin.IsChecked == true)
                {
                    cesantia = 0;
                   
                    segurocesantia.Text = cesantia.ToString();
                    double TotalImponiblee;



                    TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                    TotalImponible.Text = TotalImponiblee.ToString();


                    TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                    totalhaber.Text = TotalHaber.ToString();
                    totalremunercion1.Text = TotalHaber.ToString();

                    totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                    alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                    totalremuneracion.Text = totaldescuento.Text;
                    saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                    double numero1 = Convert.ToDouble(salud.Text);
                    numero1 = Math.Round(numero1);



                }



                if (segurosin.IsChecked == false)
                {
                    double TotalImponiblee;



                    TotalImponiblee = Convert.ToDouble(Sueldobase.Text) + Convert.ToDouble(totalhorasextra.Text) + Convert.ToDouble(Tratos.Text) + Convert.ToDouble(SemanaCorrida.Text) + Convert.ToDouble(Ajuste.Text) + Convert.ToDouble(Comision.Text) + Convert.ToDouble(Gratificacion.Text);
                    TotalImponible.Text = TotalImponiblee.ToString();


                    TotalHaber = Convert.ToDouble(TotalImponible.Text) + Convert.ToDouble(aguilnaldo.Text) + Convert.ToDouble(colacion.Text) + Convert.ToDouble(movilizacion.Text) + Convert.ToDouble(cargas_familiar.Text);
                    totalhaber.Text = TotalHaber.ToString();
                    totalremunercion1.Text = TotalHaber.ToString();



                    if (TotalImponiblee >= 2925532)
                    {


                        segurocesantia.Text = Math.Round((Convert.ToDouble(2925532) * 0.6) / 100).ToString();
                    }
                    else
                    {


                        segurocesantia.Text = Math.Round((Convert.ToDouble(TotalImponiblee) * 0.6) / 100).ToString();
                    }

                    totaldescuento.Text = (Convert.ToDouble(totalcotizacion.Text) + Convert.ToDouble(segurocesantia.Text) + Convert.ToDouble(diferencia.Text) + Convert.ToDouble(prestamos.Text) + Convert.ToDouble(voluntaria.Text) + Convert.ToDouble(salud.Text)).ToString();
                    alcanceliquido.Text = (Convert.ToDouble(totalhaber.Text) - Convert.ToDouble(totaldescuento.Text)).ToString();
                    totalremuneracion.Text = totaldescuento.Text;
                    saldoliquido.Text = (Convert.ToDouble(alcanceliquido.Text) - Convert.ToDouble(valesoanticipos.Text)).ToString();
                    double numero1 = Convert.ToDouble(salud.Text);
                    numero1 = Math.Round(numero1);
                }

                
            }
            catch
            {
            }
        }


        }

                
        
        
    
    
    
    
    }



        

    



