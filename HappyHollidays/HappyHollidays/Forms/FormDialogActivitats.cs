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
    public partial class FormDialogActivitats : Form
    {
        hoteles hotelAEditar = new hoteles();
        List<actividades> actDisponibles = new List<actividades>();
        List<actividades> actHotel = new List<actividades>();

        private readonly FormGestHotels form;
        public FormDialogActivitats(hoteles hotel, FormGestHotels formGestHotels)
        {
            InitializeComponent();
            hotelAEditar = hotel;
            form = formGestHotels;
        }

        private void buttonTornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            foreach(actividades actDisponible in actDisponibles)
            {
                ActivitatsORM.DeleteActHotelByActivitat(actDisponible, hotelAEditar);
            }

            foreach(actividades actHotelIns in actHotel)
            {
                ActivitatsORM.InsertActHotelByActivitat(actHotelIns, hotelAEditar);
            }

            hotelAEditar.act_hotel.Clear();

            List<act_hotel> acts = new List<act_hotel>();
            acts = ActivitatsORM.SelectActHotelByHotel(hotelAEditar);

            foreach(act_hotel act in acts)
            {
                hotelAEditar.act_hotel.Add(act);
            }

            Orm.MySavesChanges();
            form.rellenarCampos();

            this.Close();
        }

        private void FormDialogActivitats_Load(object sender, EventArgs e)
        {
            labelDescripcio.Text = "Gestiona les activitats que oferirà l'hotel " + hotelAEditar.nombre;

            actHotel = ActivitatsORM.SelectActivitatsByHotel(hotelAEditar);
            actDisponibles = ActivitatsORM.SelectActivitatsByNotHotel(hotelAEditar);

            reLoadLists();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            if(listBoxActivitatsDisponibles.SelectedItems.Count > 0)
            {
                actividades actividadMover = new actividades();

                actividadMover = listBoxActivitatsDisponibles.SelectedItem as actividades;

                actDisponibles.Remove(actividadMover);
                actHotel.Add(actividadMover);

                reLoadLists();
            }
        }

        private void reLoadLists()
        {
            bindingSourceActDisponibles.ResetBindings(true);
            bindingSourceActHotel.ResetBindings(true);
            bindingSourceActHotel.DataSource = actHotel;
            bindingSourceActDisponibles.DataSource = actDisponibles;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxActivitatsHotel.SelectedItems.Count > 0)
            {
                actividades actividadMover = new actividades();

                actividadMover = listBoxActivitatsHotel.SelectedItem as actividades;

                actHotel.Remove(actividadMover);
                actDisponibles.Add(actividadMover);

                reLoadLists();
            }
        }
    }
}
