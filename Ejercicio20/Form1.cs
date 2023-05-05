using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        private static int MAXIMO_PEDIDO = 5;
        private static int MINIMO_PEDIDO = 0;
        private int numHamPedido;
        private static double PRECIO_HAMBURGUESA = 35.00d;
        private static double PRECIO_PAPAS = 15.00d;
        private static double PRECIO_REFRESCO = 12.00d;
        private static double PRECIO_PIZZA = 70.00d;
        private static double PRECIO_NUGGET = 25.00d;
        private static double PRECIO_ENSALADA = 30.00d;
        private static double PRECIO_YOGUR = 15.00d;
        private static double PRECIO_AGUA = 12.00d;
        private static int TIPOIVA = 16;


        public Form1()
        {
            InitializeComponent();
        }



        private int lecturaEntero(int valorALeer)
        {
                if ((valorALeer <=MAXIMO_PEDIDO) && (valorALeer >=MINIMO_PEDIDO))
                {
                    return valorALeer;
                }

                else
                {
                    MessageBox.Show("El valor es inferior a 0 o superior a 5");
                    
                    return valorALeer = 0;
                }
      
        }

        //calculos de precios articulos:
        private double calcula_burguer()
        {
            
            return Convert.ToDouble(txt_Box_Hamburguesas.Text) * PRECIO_HAMBURGUESA;
        }

        private double Calcula_papas()
        {
            
            return Convert.ToDouble(txt_box_Papas.Text) * PRECIO_PAPAS;
        }

        private double Calcula_Refresco()
        {
            return Convert.ToDouble(txt_box_Refresco.Text) * PRECIO_REFRESCO;
        }

        private double Calcula_Pizza()
        {
            return Convert.ToDouble(txt_box_Pizza.Text) * PRECIO_PIZZA;
        }
        private double Calcula_Nugget()
        {
            return Convert.ToDouble(txt_box_Nugget.Text) * PRECIO_NUGGET;
        }

        private double Calcula_Ensalada()
        {
            return Convert.ToDouble(txt_box_Ensalada.Text) * PRECIO_ENSALADA;
        }

        private double Calcula_Yogur()
        {
            return Convert.ToDouble(txt_box_Yogur.Text) * PRECIO_YOGUR;
        }



        private double Calcula_Agua()
        {
            return Convert.ToDouble(txt_box_Agua.Text) * PRECIO_AGUA;
        }
        private void subTotal()
        {
            string eurosSubtotal = Convert.ToString(calcula_burguer()+Calcula_papas()+Calcula_Refresco()+Calcula_Pizza()+Calcula_Nugget()
                + Calcula_Ensalada()+ Calcula_Yogur()+Calcula_Agua());
            txt_box_SubTotal.Text =  eurosSubtotal;

            CalcularIva();
            txt_Box_IVA.Text = Convert.ToString(CalcularIva());

            TotalPagar();
            txt_box_TotalPagar.Text = Convert.ToString(TotalPagar());

             
        }
        //calcular IVA

        private double CalcularIva()
        {
            double baseImponible = Convert.ToDouble(txt_box_SubTotal.Text);
            return baseImponible * TIPOIVA / 100;
        }

        // suma total (base imponible + iva)

        private double TotalPagar()
        {
            string eurosSubtotal = Convert.ToString(calcula_burguer() + Calcula_papas() + Calcula_Refresco() + Calcula_Pizza() + Calcula_Nugget()
               + Calcula_Ensalada() + Calcula_Yogur() + Calcula_Agua());
            txt_box_SubTotal.Text = eurosSubtotal;
            return CalcularIva() + Convert.ToDouble(eurosSubtotal);
        }



        //FUNCION INCREMENTO Y DECREMENTO
        private int Incremento(int valorAIncrementar)
        {
            return valorAIncrementar += 1;
        }

        private int Decremento(int valorADecrementar)
        {
            return valorADecrementar -= 1;
        }


        //botones de incremento y decremento

         private void rbuton_OtrasOpciones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbuton_OtrasOpciones.Checked)
            {
                gbox_Pedidos.Enabled = true;
            }
            else
            {
                gbox_Pedidos.Enabled = false;
            }
        }
                private void btn_inc_Hamburguesa_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Incremento(int.Parse(txt_Box_Hamburguesas.Text));
                    txt_Box_Hamburguesas.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_dism_Hamburguesa_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Decremento(int.Parse(txt_Box_Hamburguesas.Text));
                    txt_Box_Hamburguesas.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_inc_Papas_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Incremento(int.Parse(txt_box_Papas.Text));
                    txt_box_Papas.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_dism_Papas_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Decremento(int.Parse(txt_box_Papas.Text));
                    txt_box_Papas.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_inc_Refresco_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Incremento(int.Parse(txt_box_Refresco.Text));
                    txt_box_Refresco.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_dism_Refresco_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Decremento(int.Parse(txt_box_Refresco.Text));
                    txt_box_Refresco.Text = Convert.ToString(nuevaCantidad);
                }
                private void btn_inc_Pizza_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Incremento(int.Parse(txt_box_Pizza.Text));
                    txt_box_Pizza.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_dism_Pizza_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Decremento(int.Parse(txt_box_Pizza.Text));
                    txt_box_Pizza.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_inc_Nugget_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Incremento(int.Parse(txt_box_Nugget.Text));
                    txt_box_Nugget.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_dism_Nugget_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Decremento(int.Parse(txt_box_Nugget.Text));
                    txt_box_Nugget.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_inc_Ensalada_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Incremento(int.Parse(txt_box_Ensalada.Text));
                    txt_box_Ensalada.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_dism_Ensalada_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Decremento(int.Parse(txt_box_Ensalada.Text));
                    txt_box_Ensalada.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_inc_Yogur_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Incremento(int.Parse(txt_box_Yogur.Text));
                    txt_box_Yogur.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_dism_Yogur_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Decremento(int.Parse(txt_box_Yogur.Text));
                    txt_box_Yogur.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_inc_Agua_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Incremento(int.Parse(txt_box_Agua.Text));
                    txt_box_Agua.Text = Convert.ToString(nuevaCantidad);
                }

                private void btn_dism_Agua_Click(object sender, EventArgs e)
                {
                    int nuevaCantidad = Decremento(int.Parse(txt_box_Agua.Text));
                    txt_box_Agua.Text = Convert.ToString(nuevaCantidad);
                }


        private void txtBox_Hamburguesas_TextChanged(object sender, EventArgs e)
        {
            lecturaEntero(int.Parse(txt_Box_Hamburguesas.Text));
            subTotal();

        }

        private void txt_box_Papas_TextChanged(object sender, EventArgs e)
        {
            lecturaEntero(int.Parse(txt_box_Papas.Text));
            subTotal();
        }

        private void txt_box_Refresco_TextChanged(object sender, EventArgs e)
        {
            lecturaEntero(int.Parse(txt_box_Refresco.Text));
            subTotal();
        }

        private void txt_box_Pizza_TextChanged(object sender, EventArgs e)
        {
            lecturaEntero(int.Parse(txt_box_Pizza.Text));
            subTotal();
        }

        private void txt_box_Nugget_TextChanged(object sender, EventArgs e)
        {
            lecturaEntero(int.Parse(txt_box_Nugget.Text));
            subTotal();
        }

        private void txt_box_Ensalada_TextChanged(object sender, EventArgs e)
        {
            lecturaEntero(int.Parse(txt_box_Ensalada.Text));
            subTotal();
        }

        private void txt_box_Yogur_TextChanged(object sender, EventArgs e)
        {
            lecturaEntero(int.Parse(txt_box_Yogur.Text));
            subTotal();
        }

        private void txt_box_Agua_TextChanged(object sender, EventArgs e)
        {
           
           lecturaEntero(int.Parse(txt_box_Agua.Text));
           subTotal();
            
        }

        private void btn_inc_pack1_Click(object sender, EventArgs e)
        {
            int nuevaCantidad = Incremento(int.Parse(txt_Box_Hamburguesas.Text));
            txt_Box_Hamburguesas.Text = Convert.ToString(nuevaCantidad);

            int nuevaCantidadPapas = Incremento(int.Parse(txt_box_Papas.Text));
            txt_box_Papas.Text = Convert.ToString(nuevaCantidadPapas);

            int nuevaCantidadRefrescos = Incremento(int.Parse(txt_box_Refresco.Text));
            txt_box_Refresco.Text = Convert.ToString(nuevaCantidadRefrescos);


        }

        private void btn_dec_pack1_Click(object sender, EventArgs e)
        {
            int nuevaCantidad = Decremento(int.Parse(txt_Box_Hamburguesas.Text));
            txt_Box_Hamburguesas.Text = Convert.ToString(nuevaCantidad);

            int nuevaCantidadPapas = Decremento(int.Parse(txt_box_Papas.Text));
            txt_box_Papas.Text = Convert.ToString(nuevaCantidadPapas);

            int nuevaCantidadRefrescos = Decremento(int.Parse(txt_box_Refresco.Text));
            txt_box_Refresco.Text = Convert.ToString(nuevaCantidadRefrescos);
        }

        private void btn_inc_pack2_Click(object sender, EventArgs e)
        {

            int nuevaCantidadRefrescos = Incremento(int.Parse(txt_box_Refresco.Text));
            txt_box_Refresco.Text = Convert.ToString(nuevaCantidadRefrescos);

            int nuevaCantidadPizza = Incremento(int.Parse(txt_box_Pizza.Text));
            txt_box_Pizza.Text = Convert.ToString(nuevaCantidadPizza);

            int nuevaCantidad = Incremento(int.Parse(txt_box_Nugget.Text));
            txt_box_Nugget.Text = Convert.ToString(nuevaCantidad);

        }

        private void btn_dec_Pack2_Click(object sender, EventArgs e)
        {

            int nuevaCantidadRefrescos = Decremento(int.Parse(txt_box_Refresco.Text));
            txt_box_Refresco.Text = Convert.ToString(nuevaCantidadRefrescos);

            int nuevaCantidadPizza = Decremento(int.Parse(txt_box_Pizza.Text));
            txt_box_Pizza.Text = Convert.ToString(nuevaCantidadPizza);

            int nuevaCantidad = Decremento(int.Parse(txt_box_Nugget.Text));
            txt_box_Nugget.Text = Convert.ToString(nuevaCantidad);
        }

        private void btn_inc_Pack3_Click(object sender, EventArgs e)
        {
            int nuevaCantidadEnsalada = Incremento(int.Parse(txt_box_Ensalada.Text));
            txt_box_Ensalada.Text = Convert.ToString(nuevaCantidadEnsalada);

            int nuevaCantidadYogur = Incremento(int.Parse(txt_box_Yogur.Text));
            txt_box_Yogur.Text = Convert.ToString(nuevaCantidadYogur);

            int nuevaCantidad = Incremento(int.Parse(txt_box_Agua.Text));
            txt_box_Agua.Text = Convert.ToString(nuevaCantidad);
        }

        private void btn_dec_pack3_Click(object sender, EventArgs e)
        {
            int nuevaCantidadEnsalada = Decremento(int.Parse(txt_box_Ensalada.Text));
            txt_box_Ensalada.Text = Convert.ToString(nuevaCantidadEnsalada);

            int nuevaCantidadYogur = Decremento(int.Parse(txt_box_Yogur.Text));
            txt_box_Yogur.Text = Convert.ToString(nuevaCantidadYogur);

            int nuevaCantidad = Decremento(int.Parse(txt_box_Agua.Text));
            txt_box_Agua.Text = Convert.ToString(nuevaCantidad);
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            if (mask_TxtBox_CPostal.MaskCompleted)
            {
                try
                {
                    double totalpagar = TotalPagar();
                    double pagoInsertado = Convert.ToDouble(txt_Box_Pago.Text);
                    if (totalpagar < pagoInsertado)
                    {
                        double Cambio = Convert.ToDouble(txt_Box_Pago.Text) - TotalPagar();
                        txt_box_Cambio.Text = Convert.ToString(Cambio);
                    }
                    else
                    {
                        MessageBox.Show("Dinero insuficiente");
                    }
                }
                catch (Exception esz)
                {
                    MessageBox.Show("Por favor realice el pago para poder procesar su pedido");
                }

            }
            else
            {
                MessageBox.Show("El campo codigo postal es obligatorio para realizar la compra. Gracias.");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_NuevaOperacion_Click(object sender, EventArgs e)
        {
            txt_Box_Hamburguesas.Text = "0";
            txt_box_Papas.Text = "0";
            txt_box_Refresco.Text = "0";
            txt_box_Pizza.Text = "0";
            txt_box_Nugget.Text = "0";
            txt_box_Ensalada.Text = "0";
            txt_box_Yogur.Text = "0";
            txt_box_SubTotal.Text = "";
            txt_Box_IVA.Text = "";
            txt_box_TotalPagar.Text = "";
            txt_Box_Pago.Text = "";
            txt_box_Cambio.Text = "";
            mask_TxtBox_CPostal.Text = "";

        }
    }
}
