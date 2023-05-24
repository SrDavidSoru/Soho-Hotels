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
    public partial class FormDialogHotels : Form
    {
        //creo un objecte cadena per rebre per paràmetre la cadena de la qual l'user vol gestionar el seus hotels
        cadenas cadenaAEditar = new cadenas();

        //creo dues llistes d'hotels, una pels hotels ja associats a la cadena i una altra per la resta d'hotels existents
        List<hoteles> hotelsDisponibles = new List<hoteles>();
        List<hoteles> hotelsCadena = new List<hoteles>();

        //creo un objecte de tipus formgestcadenes per poder accedir a una funció d'aquella pantalla des d'aquí
        private readonly FormGestCadenes form;
        public FormDialogHotels(cadenas cadena, FormGestCadenes formGestCadena)
        {
            InitializeComponent();
            cadenaAEditar = cadena;
            form = formGestCadena;
        }

        //tanco sense guardar dades
        private void buttonTornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //per guardar el canvis de les cadenes reviso els dos datagrids
        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            //per cada hotel a la grid d'hotels associats a la cadena li canvio el cif pel de la cadena que estic editant
            foreach(hoteles hotelCadena in hotelsCadena)
            {
                hotelCadena.cif = cadenaAEditar.cif;
                hotelCadena.cadenas = cadenaAEditar;
            }

            //per cada hotel en la grid d'hotels disponibles que abans eren de la cadena que estic editant
            //la canvio a null per deixar-los sense cadena associada
            foreach(hoteles hotelDisponible in hotelsDisponibles)
            {
                if (hotelDisponible.cif == cadenaAEditar.cif)
                {
                    hotelDisponible.cif = null;
                    hotelDisponible.cadenas = null;
                }
            }

            Orm.MySavesChanges();
            MessageBox.Show("Canvis aplicats correctament", "Canvis", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //accedeixo al form de gestionar cadenes per executar des d'aqui la funció de omplir camps i així quan tanco
            //el dialog el grid ja està actualitzat
            form.rellenarCampos();
            this.Close();
        }

        //canvio el text del títol per recordar l'usuari quina cadena està editant
        private void FormDialogHotels_Load(object sender, EventArgs e)
        {
            
            labelDescripcio.Text = "Gestiona els hotels que estaran associats a la cadena " + cadenaAEditar.nombre;

            //guardo els hotels disponibles (sense cadena o amb cadena diferent a la que estic editant) a una llista
            hotelsDisponibles = HotelesORM.SelectHotelsByNotCadena(cadenaAEditar);
            //guardo els associats a la cadena a una llista
            hotelsCadena = HotelesORM.SelectHotelsByCadena(cadenaAEditar);


            reloadGridDisponibles();
            reloadGridCadena();
            
            
        }

        private void dataGridViewHotelsDisponibles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                hoteles hotel = (hoteles)dataGridViewHotelsDisponibles.Rows[e.RowIndex].DataBoundItem;
                e.Value = hotel.ciudades.nombre.ToString();
            }

            if (e.ColumnIndex == 6)
            {
                hoteles hotel = (hoteles)dataGridViewHotelsDisponibles.Rows[e.RowIndex].DataBoundItem;
                if (hotel.cadenas != null)
                {
                    e.Value = hotel.cadenas.nombre.ToString();
                }
                else
                {
                    e.Value = "(sense cadena assignada)";
                }

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
                if (hotel.cadenas != null)
                {
                    e.Value = hotel.cadenas.nombre.ToString();
                }
                else
                {
                    e.Value = "(sense cadena assignada)";
                }

            }
        }

        private void buttonBuscarHotelDisponible_Click(object sender, EventArgs e)
        {
            reloadGridDisponibles();
        }

        //carrego la grid d'hotels disponibles aplicant datasource diferents segons si l'user els busca per nom o sense cap cerca específica
        private void reloadGridDisponibles()
        {
            bindingSourceHotelsDisponibles.ResetBindings(true);
            if (textBoxNomHotelDisponible.Text != "")
            {
                bindingSourceHotelsDisponibles.DataSource = findHotelByName(hotelsDisponibles, textBoxNomHotelDisponible.Text.ToLower());
            } else
            {
                bindingSourceHotelsDisponibles.DataSource = hotelsDisponibles;
            }
            
        }

        

        private void textBoxNomHotelDisponible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                reloadGridDisponibles();
            }
        }

        private void buttonBuscarHotelCadena_Click(object sender, EventArgs e)
        {
            reloadGridCadena();
        }

        //carrego la grid d'hotels de la cadena aplicant datasource diferents segons si l'user els busca per nom o sense cap cerca específica
        private void reloadGridCadena()
        {
            bindingSourceHotels.ResetBindings(true);
            if (textBoxNomHotelCadena.Text != "")
            {
                bindingSourceHotels.DataSource = findHotelByName(hotelsCadena, textBoxNomHotelCadena.Text.ToLower());
            } else
            {
                bindingSourceHotels.DataSource = hotelsCadena;
            }
        }

        //aquesta funció substitueix el selectbyname de l'orm, ja que al no tenir els canvis encara guardats a la base de dades
        //no funcionava, així que ho faig manualment amb la llista
        private List<hoteles> findHotelByName(List<hoteles> hotels, string name)
        {
            List<hoteles> hotelsFiltrats = new List<hoteles>();

            foreach (hoteles hotel in hotels)
            {
                
                if (hotel.nombre.ToLower().Contains(name.ToLower()))
                {
                    hotelsFiltrats.Add(hotel);
                }
            }

            return hotelsFiltrats;
        }

        private void textBoxNomHotelCadena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                reloadGridCadena();
            }
        }

        //m'asseguro de que un hotel estigui seleccionat, el guardo a un objecte, el trec d'una llista i la inserto a l'altra
        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotelsDisponibles.SelectedRows.Count > 0)
            {
                hoteles hotelTransferir = dataGridViewHotelsDisponibles.CurrentRow.DataBoundItem as hoteles;

                

                hotelsDisponibles.Remove(hotelTransferir);
                hotelsCadena.Add(hotelTransferir);

                reloadGridCadena();
                reloadGridDisponibles();
            }
        }

        //m'asseguro de que un hotel estigui seleccionat, el guardo a un objecte, el trec d'una llista i la inserto a l'altra
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewHotels.SelectedRows.Count > 0)
            {
                hoteles hotelEliminarCadena = dataGridViewHotels.CurrentRow.DataBoundItem as hoteles;

                hotelsCadena.Remove(hotelEliminarCadena);
                hotelsDisponibles.Add(hotelEliminarCadena);
                

                reloadGridCadena();
                reloadGridDisponibles();
            }
        }
    }
}
