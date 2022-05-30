using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e) //botão ponto(virgula)
        {
            txtResultado.Text += ".";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }

            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }

            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }

            else if(operacao == "DIV")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lbloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração");
            }
        }

        private void multipicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lbloperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação");
            }
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lbloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão");
            }
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lbloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma");
            }
        }

        private void CE_Click(object sender, EventArgs e) //limpa a operação mais recente
        {
            txtResultado.Text = "";
            lbloperacao.Text = "";
        }

        private void C_Click(object sender, EventArgs e) //limpa toda a operação
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbloperacao.Text = "";
        }
    }
}
/*
     “C” é uma sigla para “clear” (“limpar”, em inglês) e “CE”, 
    para “cancel entry” (“cancelar registro”). O botão C, portanto, 
    limpa toda a operação que estava sendo feita na calculadora. 
    O CE só cancela o registro mais recente, permitindo que o 
    usuário dê continuidade ao cálculo que estava fazendo sem ter que recomeçar do zero.
    A primeira calculadora eletrônica foi lançada em 1961, na Inglaterra.
 */