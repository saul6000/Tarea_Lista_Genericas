using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_ListaGénericas.Modelo;

namespace Tarea_ListaGénericas
{
    public partial class Form1 : Form
    {
        int n = 0;
        private List<Matricula> La_lista = new List<Matricula>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.letra(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.letra(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros(e);
        }

        private void btbAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtMatricula.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el codigo de la Matricula ");
                this.txtMatricula.Focus();
            }
            if (this.txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Su Nombre ");
                this.txtNombres.Focus();
            }
            if (this.txtApellidos.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Su Apellido ");
                this.txtApellidos.Focus();
            }
            if (!(int.TryParse(this.txtEdad.Text, out int Edad)))
            {
                MessageBox.Show("Ingrese su Edad  ");
                this.txtEdad.Focus();
            }
             Matricula materia = new Matricula();
            materia.Matriculas = this.txtMatricula.Text;
            materia.Nombres = this.txtNombres.Text;
            materia.Apellidos = this.txtApellidos.Text;
            materia.Edad = Edad;
            materia.Sexo = this.txtSexo.Text;
            La_lista.Add(materia);        
            this.gridAsignatura.DataSource = null;
            this.gridAsignatura.DataSource = La_lista;
            ListViewItem lista = new ListViewItem(this.txtMatricula.Text);
            lista.SubItems.Add(this.txtNombres.Text);
            lista.SubItems.Add(this.txtApellidos.Text);
            lista.SubItems.Add(this.txtEdad.Text);
            lista.SubItems.Add(this.txtSexo.Text);
            listMatriculas.Items.Add(lista);
            Limpiar_Texbox limpiar = new Limpiar_Texbox();
            limpiar.Borrar_Texbox(this);

            

        }

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.letra(e);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.gridAsignatura.DataSource = null;
            this.gridAsignatura.DataSource = La_lista.Where(data => data.Matriculas == this.textBox1.Text).ToList();
        }

        private void btbMostrar_Click(object sender, EventArgs e)
        {
            this.txtMaxima.Text = La_lista.Max(data => data.Edad).ToString();
            this.txtMinimo.Text = La_lista.Min(data => data.Edad).ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {


            

            foreach (ListViewItem lista in listMatriculas.SelectedItems)
            {
                lista.Remove();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            listMatriculas.Items.Clear();
        }
    }
}
