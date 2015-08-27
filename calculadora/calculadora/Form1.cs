using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        //declarar variaveis
        double total;
        double ultimoNumero;
        string operador;

        //Metodos
        private void Clean() {
            total = 0;
            ultimoNumero = 0;
            operador = "+";
            txtResult.Text = "0";
        }

        private void calcular()
        {
            switch (operador) {
                case "+": 
                    total = total + ultimoNumero;
                    break;    
                case "-": 
                    total = total - ultimoNumero;
                    break;
                case "/": 
                    total = total / ultimoNumero;
                    break;
                case "X": 
                    total = total * ultimoNumero;
                    break;
            }
            ultimoNumero = 0;
            txtResult.Text = total.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            //inicializar vars
            Clean();

        }

        // funcoes click
        private void btClean_Click(object sender, EventArgs e)
        {
            Clean();
            //txtResult.Text = " ";
        }

        private void gerarNumero(object sender, EventArgs e)
        {
            if (ultimoNumero == 0)
            {
                txtResult.Text = (sender as Button).Text;

            }
            else
            {
                ultimoNumero = Convert.ToDouble(txtResult.Text + (sender as Button).Text);
            }
            ultimoNumero = Convert.ToDouble(txtResult.Text);
        }

        private void operadores(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(txtResult.Text);
            calcular();
            operador = (sender as Button).Text;
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(txtResult.Text);
            calcular();
            operador = "+";
            total = 0;

        }




    }
}
