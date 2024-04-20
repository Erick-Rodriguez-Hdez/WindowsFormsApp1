using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperaciones.Items.Add("Suma");
            this.cmbOperaciones.Items.Add("Resta");
            this.cmbOperaciones.Items.Add("Division");
            this.cmbOperaciones.Items.Add("Multiplicacion");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            string Operacion = this.cmbOperaciones.SelectedItem.ToString();

            double num1 = double.Parse(this.txtNum1.Text);
            double num2 = double.Parse(this.txtNum2.Text);

            switch (Operacion)
            {
                case "Suma":
                    resultado = num1 + num2;
                    break;
                case "Resta":
                    resultado = num1 - num2;
                    break;
                case "Division":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        MessageBox.Show("No se puede dividir por cero.");
                    break;
                case "Multiplicacion":
                    resultado = num1 * num2;
                    break;
                default:
                    MessageBox.Show("Operación no válida.");
                    break;
            }
            this.txtResultado.Text=resultado.ToString();
        }
    }
}
