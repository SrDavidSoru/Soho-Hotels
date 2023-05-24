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
    public partial class Hotels : Form
    {
        
        public Hotels()
        {
            InitializeComponent();
            
        }

        private void Hotels_Load(object sender, EventArgs e)
        {

            reLoadGrid();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            

            Panel panel = (Panel)this.Parent;
            FormGestHotels formGestHotels = new FormGestHotels() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(formGestHotels);
            formGestHotels.FormBorderStyle = FormBorderStyle.None;
            formGestHotels.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotels.SelectedRows.Count > 0)
            {
                hoteles hotelAEditar = dataGridViewHotels.CurrentRow.DataBoundItem as hoteles;

                Panel panel = (Panel)this.Parent;
                FormGestHotels formGestHotels = new FormGestHotels(hotelAEditar) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(formGestHotels);
                formGestHotels.FormBorderStyle = FormBorderStyle.None;
                formGestHotels.Show();
            } else
            {
                MessageBox.Show("Selecciona un hotel per editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void dataGridViewHotels_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                hoteles hotel = (hoteles)dataGridViewHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = hotel.ciudades.nombre.ToString();
            }

            if (e.ColumnIndex == 6)
            {
                hoteles hotel = (hoteles)dataGridViewHotels.Rows[e.RowIndex].DataBoundItem;
                if(hotel.cadenas != null)
                {
                    e.Value = hotel.cadenas.nombre.ToString();
                } else
                {
                    e.Value = "(sense cadena assignada)";
                }
                
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotels.SelectedRows.Count > 0)
            {
                hoteles hotel = dataGridViewHotels.CurrentRow.DataBoundItem as hoteles;




                DialogResult dr = MessageBox.Show("Segur que vols eliminar l'hotel " +
                    dataGridViewHotels.CurrentRow.Cells[0].Value + "?\nAquesta acció no es pot desfer", "Eliminar cadena",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {

                    HotelesORM.Delete(hotel);
                    reLoadGrid();
                }
            }
        }

        private void reLoadGrid()
        {
            bindingSourceHotels.ResetBindings(true);
            if (textBoxNomHotels.Text.Equals(""))
            {
                
                bindingSourceHotels.DataSource = HotelesORM.SelectAll();
            } else
            {
                bindingSourceHotels.DataSource = HotelesORM.SelectHotelsByName(textBoxNomHotels.Text.ToLower());
            }
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            reLoadGrid();
        }

        private void textBoxNomHotels_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                reLoadGrid();
            }
        }
    }
}
