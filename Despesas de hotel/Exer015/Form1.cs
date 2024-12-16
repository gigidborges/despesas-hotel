using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exer015
{

    public partial class Form1 : Form
    {
        int totalDias = 0;
        double valorDiaria = 0;
        double totValorDiarias = 0;
        double valorDesconto = 0;
        double subTotal = 0;
        double Servicos = 0;
        double totalPagar = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblDia.Text = DateTime.Now.ToString("dddd").ToUpper(); //Exibe o dia da semana
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");//Exibe a hora do form (hh/mm/ss --> hora de 24 hrs)

            //Código para que o Rdo iniciem pré-selecionados
            radSimple.Checked = true;
            radVista.Checked = true;

            //Fazer a data de hoje aparecer no projeto para cálculo de dias da hospedagem
            masSaida.Text = DateTime.Now.ToString("dd/MM/yyyy"); //Exibe data atual do form (dia/mês/ano)
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblDesconto.Text = "";
            lblDiaria.Text = "";
            lblServico.Text = "";
            lblSub.Text = "";
            lblTotal.Text = "";
            lblTotal2.Text = "";
            c1.Checked = false;
            c2.Checked = false;
            c3.Checked = false;
            c4.Checked = false;
            radSimple.Checked = true;
            radVista.Checked = true;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtEntrada = Convert.ToDateTime(masEntrada.Text);
                DateTime dtSaida = Convert.ToDateTime(masSaida.Text);

                totalDias = ((dtSaida).Subtract(dtEntrada)).Days;

                if (radDuplo.Checked)
                {
                    valorDiaria += 280.00;
                }
                else if (radSimple.Checked)
                {
                    valorDiaria += 150.00;
                }


                totValorDiarias = totalDias * valorDiaria;
                Servicos = 0;


                if (c1.Checked)
                {
                    Servicos += 50.00;
                }
                if (c2.Checked)
                {
                    Servicos += 80.00;
                }
                if (c3.Checked)
                {
                    Servicos += 120.00;
                }
                if (c4.Checked)
                {
                    Servicos += 200.00;
                }

                subTotal = totValorDiarias - valorDesconto; // Calcular o subtotal
                totalPagar = subTotal + Servicos; // Calcula o total a pagar

                if (radVista.Checked)
                {
                    valorDesconto = (totValorDiarias) * 0.1;
                }

                subTotal = totValorDiarias - valorDesconto; // Calcular o subtotal
                totalPagar = subTotal + Servicos; // Calcula o total a pagar

                // Exibir os resultados nos labels correspondentes
                lblTotal.Text = totalDias.ToString();
                lblDiaria.Text = totValorDiarias.ToString("0.00");
                lblServico.Text = Servicos.ToString("0.00");
                lblDesconto.Text = valorDesconto.ToString("0.00");
                lblSub.Text = subTotal.ToString("0.00");
                lblTotal2.Text = totalPagar.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Digite uma data valida");
            }
        }

        private void MasSaida_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
            masSaida.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
        }

  
    }
}
