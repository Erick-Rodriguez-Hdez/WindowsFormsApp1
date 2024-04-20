using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp002Crud
{
    public partial class CervezaForm : Form
    {
        public Cerveza Cerveza { get; set; }
        public CervezaForm()
        {
            InitializeComponent();
            Cerveza = new Cerveza();
        }
        public CervezaForm(Cerveza Cerveza) : this()
        {
            this.Cerveza = Cerveza;
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void CervezaForm_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.Cerveza.Nombre;
            this.txtEstilo.Text = this.Cerveza.Estilo;
            this.txtAlcohol.Text = this.Cerveza.Alcohol.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cerveza.Nombre = this.txtNombre.Text;
            this.Cerveza.Estilo = this.txtEstilo.Text;
            this.Cerveza.Alcohol = double.Parse(this.txtAlcohol.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

