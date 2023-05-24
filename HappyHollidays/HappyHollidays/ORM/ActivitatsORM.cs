using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HappyHollidays.Models;

namespace HappyHollidays.ORM
{
    public static class ActivitatsORM
    {

        //Selecciono les activitats enllaçades a un hotel mitjançant un join amb act_hotel
        public static List<actividades> SelectActivitatsByHotel(hoteles hotel)
        {
            List<actividades> actividades = new List<actividades>();

            actividades = (from a in Orm.bd.actividades
                           join ah in Orm.bd.act_hotel
                           on a.id_act equals ah.id_act
                           where ah.id_ciudad == hotel.id_ciudad
                           && ah.nombre == hotel.nombre
                           select a).ToList();

            return actividades;
        }

        //Selecciono totes les activitats i li resto les enllaçades a un hotel concret mitjançant un Except
        public static List<actividades> SelectActivitatsByNotHotel(hoteles hotel)
        {
            List<actividades> actividades = new List<actividades>();

            actividades = (from a in Orm.bd.actividades
                           select a).ToList();

            List<actividades> actividadesHotel = new List<actividades>();

            actividadesHotel = ActivitatsORM.SelectActivitatsByHotel(hotel);

            List<actividades> actividadesFinal = new List<actividades>();
            actividadesFinal = actividades.Except(actividadesHotel).ToList();


            return actividadesFinal;
        }

        public static void DeleteActHotelByActivitat(actividades act, hoteles hotel)
        {
            act_hotel ah = new act_hotel();
            try
            {
                ah = (from a in Orm.bd.act_hotel
                      where a.id_act == act.id_act
                      && a.id_ciudad == hotel.id_ciudad
                      && a.nombre == hotel.nombre
                      select a).Single();

                Orm.bd.act_hotel.Remove(ah);
                Orm.MySavesChanges();
            } catch (Exception ex)
            {

            }
            
        }

        public static void InsertActHotelByActivitat (actividades act, hoteles hotel)
        {
            act_hotel ah = new act_hotel();

            ah.id_act = act.id_act;
            ah.actividades = act;
            ah.id_ciudad = hotel.id_ciudad;
            ah.nombre = hotel.nombre;
            ah.hoteles = hotel;
            ah.grado = 2;

            Orm.bd.act_hotel.Add(ah);
            Orm.MySavesChanges();
        }

        public static List<act_hotel> SelectActHotelByHotel(hoteles hotel)
        {
            List<act_hotel> ahList = new List<act_hotel>();

            ahList = (from ah in Orm.bd.act_hotel
                      where ah.id_ciudad == hotel.id_ciudad
                      && ah.nombre == hotel.nombre
                      select ah).ToList();

            return ahList;
        }


    }
}
