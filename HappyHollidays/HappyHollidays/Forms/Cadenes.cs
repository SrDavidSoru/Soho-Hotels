using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyHollidays.Models;
using HappyHollidays.ORM;

namespace HappyHollidays.Forms
{
    public partial class Cadenes : Form
    {
        public Cadenes()
        {
            InitializeComponent();
        }

        private void Cadenes_Load(object sender, EventArgs e)
        {
            reLoadGrid();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            FormGestCadenes formGestCadenes = new FormGestCadenes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(formGestCadenes);
            formGestCadenes.FormBorderStyle = FormBorderStyle.None;
            formGestCadenes.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //reviso si hi ha una cadena seleccionada a la datagrid per guardar-la a un objecte i passar-la com a paràmetre
            //a la pantalla de gestionar
            if (dataGridViewCadenes.SelectedRows.Count > 0)
            {
                cadenas cadenaAEditar = dataGridViewCadenes.CurrentRow.DataBoundItem as cadenas;

                Panel panel = (Panel)this.Parent;
                FormGestCadenes formGestCadenes = new FormGestCadenes(cadenaAEditar) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(formGestCadenes);
                formGestCadenes.FormBorderStyle = FormBorderStyle.None;
                formGestCadenes.Show();
            } else
            {
                MessageBox.Show("Selecciona una cadena per editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            reLoadGrid();
        }

        //aquesta funció carrega les dades del bindingsource de cadenes a la datagrid depenent de si fem una
        //cerca per nom o una normal
        private void reLoadGrid()
        {
            if(textBoxNomCadenes.Text.Equals(""))
            {
                bindingSourcCadenes.DataSource = CadenesORM.SelectAll();
            } else
            {
                bindingSourcCadenes.DataSource = CadenesORM.SelectCadenesByName(textBoxNomCadenes.Text.ToLower());
            }
        }

        private void textBoxNomCadenes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                reLoadGrid();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            //reviso si hi ha una cadena seleccionada a la datagrid per guardar-la a un objecte i eliminar-la
            if (dataGridViewCadenes.SelectedRows.Count > 0)
            {
                cadenas cadena = dataGridViewCadenes.CurrentRow.DataBoundItem as cadenas;




                DialogResult dr = MessageBox.Show("Segur que vols eliminar la cadena " +
                    dataGridViewCadenes.CurrentRow.Cells[1].Value + "?\nAquesta acció no es pot desfer", "Eliminar cadena",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {

                    CadenesORM.Delete(cadena);
                    reLoadGrid();
                }
            }
        }
    }
}
