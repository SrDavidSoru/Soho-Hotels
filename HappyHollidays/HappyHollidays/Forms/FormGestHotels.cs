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
    public partial class FormGestHotels : Form
    {
        hoteles hotelAEditar = new hoteles();
        bool crearHotel = false;
        public FormGestHotels()
        {
            InitializeComponent();
            crearHotel = true;
        }

        public FormGestHotels(hoteles hotel)
        {
            InitializeComponent();
            hotelAEditar = hotel;
            crearHotel = false;
        }

        private void buttonTornar_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            Hotels hotels = new Hotels() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(hotels);
            hotels.FormBorderStyle = FormBorderStyle.None;
            hotels.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(textBoxNomHotels.Equals("") || textBoxDireccio.Equals("") || textBoxTelefon.Equals("") || comboBoxCadena.Text.Equals("") || comboBoxTipus.Text.Equals(""))
            {
                MessageBox.Show("Omple tots els camps per guardar l'hotel" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if(Int32.TryParse(textBoxTelefon.Text, out int tlf))
                {
                    //hotelAEditar.nombre = textBoxNomHotels.Text.ToString();
                    //hotelAEditar.ciudades = (ciudades)comboBoxCiutat.SelectedItem;
                    hotelAEditar.telefono = tlf;
                    hotelAEditar.categoria = (int)numericUpDownEstrelles.Value;
                    hotelAEditar.cadenas = (cadenas)comboBoxCadena.SelectedItem;
                    hotelAEditar.cif = hotelAEditar.cadenas.cif;
                    hotelAEditar.direccion = textBoxDireccio.Text.ToString();
                    hotelAEditar.tipo = comboBoxTipus.Text.ToString();

                    if(crearHotel == true)
                    {
                        hotelAEditar.nombre = textBoxNomHotels.Text.ToString();
                        hotelAEditar.ciudades = (ciudades)comboBoxCiutat.SelectedItem;
                        hotelAEditar.id_ciudad = hotelAEditar.ciudades.id_ciudad;
                        HotelesORM.InsertHotel(hotelAEditar);
                    }

                    Orm.MySavesChanges();

                    Panel panel = (Panel)this.Parent;
                    Hotels hotels = new Hotels() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    panel.Controls.Clear();
                    panel.Controls.Add(hotels);
                    hotels.FormBorderStyle = FormBorderStyle.None;
                    hotels.Show();
                } else
                {
                    MessageBox.Show("Inserta correctament el número de telèfon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                



                
            }

            
        }

        

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            FormDialogActivitats formDialogActivitats = new FormDialogActivitats(hotelAEditar, this);
            formDialogActivitats.ShowDialog();
        }

        public void rellenarCampos()
        {
            textBoxNomHotels.Text = hotelAEditar.nombre.ToString();
            textBoxNomHotels.Enabled = false;
            textBoxDireccio.Text = hotelAEditar.direccion.ToString();
            textBoxTelefon.Text = hotelAEditar.telefono.ToString();
            textBoxCif.Enabled = true;
            textBoxCif.Text = hotelAEditar.cif.ToString();
            textBoxCif.Enabled = false;
            comboBoxCadena.Text = hotelAEditar.cadenas.nombre.ToString();
            comboBoxCiutat.Text = hotelAEditar.ciudades.nombre.ToString();
            comboBoxCiutat.Enabled = false;
            comboBoxTipus.Text = hotelAEditar.tipo.ToString();
            numericUpDownEstrelles.Value = hotelAEditar.categoria;
            bindingSourceActivitats.DataSource = ActivitatsORM.SelectActivitatsByHotel(hotelAEditar);
        }

        private void rellenarItemsComboBoxes()
        {
            bindingSourceCiutats.DataSource = CiudadesORM.SelectAll();

            bindingSourceCadenes.DataSource = CadenesORM.SelectAll();

            List<hoteles> hotels = HotelesORM.SelectAll();

            List<string> listTipusHotels = tipusHotels(hotels);

            foreach (string tipus in listTipusHotels)
            {
                comboBoxTipus.Items.Add(tipus);
            }
        }

        //aquí paso por todos los hoteles para recoger su tipo y guardarlo en una lista para meterlo como item
        //al combobox de tipo. Esto lo hago porque como tal no hay una tabla de tipo de hotel
        private List<string> tipusHotels (List<hoteles> hotels)
        {
            List<string> result = new List<string>();
            

            foreach(hoteles hotel in hotels)
            {
                if(!result.Contains(hotel.tipo.ToUpper().ToString()))
                {
                    result.Add(hotel.tipo.ToUpper().ToString());
                }
            }

            

            return result;
        }

        private void FormGestHotels_Load(object sender, EventArgs e)
        {
            rellenarItemsComboBoxes();
            if (crearHotel == false)
            {
                rellenarCampos();
                panelCrearHotel.Visible = false;
            } else
            {
                labelGestionarHotel.Text = "Crear Hotel";
                comboBoxCadena.SelectedIndex = -1;
            }
            
        }

        private void comboBoxCadena_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadenas cadenaEscogida = comboBoxCadena.SelectedItem as cadenas;

            if (cadenaEscogida != null )
            {
                textBoxCif.Enabled = true;
                textBoxCif.Text = cadenaEscogida.cif.ToString();
                textBoxCif.Enabled = false;
            }
            
        }

        private void buttonCrearHotel_Click(object sender, EventArgs e)
        {
            if (textBoxNomHotels.Equals("") || textBoxDireccio.Equals("") || textBoxTelefon.Equals("") || comboBoxCadena.Text.Equals("") || comboBoxTipus.Text.Equals(""))
            {
                MessageBox.Show("Omple tots els camps per guardar l'hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Int32.TryParse(textBoxTelefon.Text, out int tlf))
                {
                    //hotelAEditar.nombre = textBoxNomHotels.Text.ToString();
                    //hotelAEditar.ciudades = (ciudades)comboBoxCiutat.SelectedItem;
                    hotelAEditar.telefono = tlf;
                    hotelAEditar.categoria = (int)numericUpDownEstrelles.Value;
                    hotelAEditar.cadenas = (cadenas)comboBoxCadena.SelectedItem;
                    hotelAEditar.cif = hotelAEditar.cadenas.cif;
                    hotelAEditar.direccion = textBoxDireccio.Text.ToString();
                    hotelAEditar.tipo = comboBoxTipus.Text.ToString();

                    if (crearHotel == true)
                    {
                        hotelAEditar.nombre = textBoxNomHotels.Text.ToString();
                        hotelAEditar.ciudades = (ciudades)comboBoxCiutat.SelectedItem;
                        hotelAEditar.id_ciudad = hotelAEditar.ciudades.id_ciudad;
                        HotelesORM.InsertHotel(hotelAEditar);
                        panelCrearHotel.Visible = false;
                    }

                    Orm.MySavesChanges();

                    
                }
                else
                {
                    MessageBox.Show("Inserta correctament el número de telèfon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }






            }
        }
    }
}
