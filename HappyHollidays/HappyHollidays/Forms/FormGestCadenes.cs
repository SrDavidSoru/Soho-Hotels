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
    public partial class FormGestCadenes : Form
    {
        //creo un objecte de tipus cadena per guardar la cadena que he passat per paràmetre i vull editar
        //no obstant, en cas d'haver vingut a aquesta pantalla amb el botó de crear cadena, aquest objecte
        //queda buit per l'usuari per omplir el seus atributs i guardar-la
        //el bool crearCadena m'ajuda a saber si l'usuari ve del botó d'editar o crear cadena
        cadenas cadenaAEditar = new cadenas();
        public bool crearCadena = false;

        //aquest es el constructor de quan l'usuari ha seleccionat editar cadena. Omplo la cadena a editar amb
        //la cadena que es passa per paràmetre i estableixo crearCadena a false
        public FormGestCadenes(cadenas cadena)
        {
            InitializeComponent();
            cadenaAEditar = cadena;
            crearCadena = false;
        }

        //aquest es el constructor de quan l'usuari ha seleccionat crear cadena. Cadena a editar queda buida
        public FormGestCadenes()
        {
            InitializeComponent();
            crearCadena = true;
        }

        //aqui torno a la pantalla anterior sense guardar dades a la base
        private void buttonTornar_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            Cadenes cadenes = new Cadenes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(cadenes);
            cadenes.FormBorderStyle = FormBorderStyle.None;
            cadenes.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //m'asseguro que tots els camps estiguin omplerts i actualitzo els camps de nom i direcció de la cadena a editar
            //no actualitzo el camp del CIF ja que la intenció es que un cop introduït no es pugui modificar ja que es una
            //dada important
            if(textBoxNomCadena.Text != "" && textBoxDireccioCadena.Text != "" && textBoxCIFCadena.Text != "")
            {
                
                cadenaAEditar.nombre = textBoxNomCadena.Text;
                cadenaAEditar.dir_fis = textBoxDireccioCadena.Text;

                Orm.MySavesChanges();

                Panel panel = (Panel)this.Parent;
                Cadenes cadenes = new Cadenes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(cadenes);
                cadenes.FormBorderStyle = FormBorderStyle.None;
                cadenes.Show();
            } else
            {
                MessageBox.Show("Omple tots els camps per guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        //obro el dialog per gestionar els hotels de la cadena, passant com a objecte la cadena que estic editant i
        //el form actual per poder accedir a funcions d'aquí des del dialog
        private void buttonGestionarHotels_Click(object sender, EventArgs e)
        {
            
            FormDialogHotels form = new FormDialogHotels(cadenaAEditar, this);
            form.ShowDialog();
            


            
            
        }

        //al load, si vens a crear una cadena canvio el label i no omplo els camps
        private void FormGestCadenes_Load(object sender, EventArgs e)
        {
            if (crearCadena == true)
            {
                labelGestionarCadena.Text = "Crear Cadena";
            } else
            {
                rellenarCampos();
            }
            
        }

        private void dataGridViewHotels_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                hoteles hotel = (hoteles)dataGridViewHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = hotel.ciudades.nombre.ToString();
            }
        }

        //per omplir els camps quan l'user ve a editar una cadena, faig invisible el panel que oculta el datagrid d'hotels
        //associats a la cadena i amb un select actualitzo el seu bindingsource. A més, desactivo el camp del CIF per que 
        //l'user no pugui editar-ho
        public void rellenarCampos()
        {
            panelCrearCadena.Visible = false;
            textBoxNomCadena.Text = cadenaAEditar.nombre;
            textBoxDireccioCadena.Text = cadenaAEditar.dir_fis;
            textBoxCIFCadena.Text = cadenaAEditar.cif;
            textBoxCIFCadena.Enabled = false;

            bindingSourceHotels.DataSource = HotelesORM.SelectHotelsByCadena(cadenaAEditar);
        }

        //aquesta es la funció de crear cadena per ocultar el panel i poder accedir als seus hotels associats
        //he decidit fer-ho així perque al tenir la gestió d'hotels a un dialog no era viable modificar aquest camp
        //sense tenir la cadena creada, així que obligo l'user a crear la cadena per accedir a aquesta funcionalitat
        private void buttonCrearCadena_Click(object sender, EventArgs e)
        {
            
            if (textBoxNomCadena.Text != "" && textBoxDireccioCadena.Text != "" && textBoxCIFCadena.Text != "")
            {
                cadenaAEditar.nombre = textBoxNomCadena.Text;
                cadenaAEditar.dir_fis = textBoxDireccioCadena.Text;
                cadenaAEditar.cif = textBoxCIFCadena.Text;

                if (CIFExistente (cadenaAEditar, CadenesORM.SelectAll()) == true)
                {
                    MessageBox.Show("Aquest CIF ja existeix a la base de dades. Si us plau, escriu d'un diferent", "CIF Existent", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    //inserto la cadena a la base de dades i faig el panel invisible per permitir l'user gestionar hotels associats
                    panelCrearCadena.Visible = false;
                    CadenesORM.InsertCadena(cadenaAEditar);
                    textBoxCIFCadena.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Omple tots els camps per crear la cadena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //m'asseguro que cap cadena tingui el cif que l'user està intentant introduïr
        private bool CIFExistente (cadenas cadenaNuevoCIF, List<cadenas> cadenas)
        {
            bool existe = false;
            foreach (cadenas cadena in cadenas)
            {
                if (cadenaNuevoCIF.cif == cadena.cif)
                {
                    existe = true;
                }
            }

            return existe;
        }
    }
}
