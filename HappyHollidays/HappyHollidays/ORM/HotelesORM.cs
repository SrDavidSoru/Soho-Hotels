using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HappyHollidays.Forms;
using HappyHollidays.Models;

namespace HappyHollidays.ORM
{
    public static class HotelesORM
    {
        public static List<hoteles> SelectAll()
        {
            List<hoteles> hotels = new List<hoteles>();

            hotels = (from c in Orm.bd.hoteles select c).ToList();

            return hotels;
        }

        public static String InsertHotel(hoteles hotel)
        {
            Orm.bd.hoteles.Add(hotel);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }


        public static void Delete(hoteles hotel)
        {



            Orm.bd.hoteles.Remove(hotel);
            Orm.MySavesChanges();
        }

        public static List<hoteles> SelectHotelsByName(string nom)
        {
            List<hoteles> hotels = new List<hoteles>();

            hotels = (from c in Orm.bd.hoteles
                      where c.nombre.ToLower().Contains(nom.ToLower())
                      select c).ToList();

            return hotels;
        }

        public static List<hoteles> SelectHotelsByCadena(cadenas cadena)
        {
            List<hoteles> hotels = new List<hoteles>();

            hotels = (from c in Orm.bd.hoteles
                      where c.cif == cadena.cif
                      select c).ToList();

            return hotels;
        }

        public static List<hoteles> SelectHotelsByCadenaAndName(cadenas cadena, string name)
        {
            List<hoteles> hotels = new List<hoteles>();

            hotels = (from c in Orm.bd.hoteles
                      where c.cif == cadena.cif &&
                      c.nombre.ToLower().Contains(name.ToLower())
                      select c).ToList();

            return hotels;
        }

        public static List<hoteles> SelectHotelsByNotCadena(cadenas cadena)
        {
            List<hoteles> hotels = new List<hoteles>();
            List<hoteles> hotelsAEliminar = new List<hoteles>();
            hotels = (from c in Orm.bd.hoteles select c).ToList();

            try
            {
                foreach (hoteles hotel in hotels)
                {
                    if (hotel.cif == cadena.cif)
                    {
                        hotelsAEliminar.Add(hotel);
                    }
                }
                
                foreach(hoteles hotelBorrar in hotelsAEliminar)
                {
                    hotels.Remove(hotelBorrar);
                }
            } catch (Exception ex)
            {
                hotels = (from c in Orm.bd.hoteles
                          where c.cif != cadena.cif
                          select c).ToList();
            }
            

            return hotels;
        }

        public static List<hoteles> SelectHotelsByNotCadenaAndName(cadenas cadena, string name)
        {
            List<hoteles> hotels = new List<hoteles>();

            hotels = (from c in Orm.bd.hoteles
                      where c.cif != cadena.cif &&
                       c.nombre.ToLower().Contains(name.ToLower())
                      select c).ToList();

            return hotels;
        }
    }
}
