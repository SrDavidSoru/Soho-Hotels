using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HappyHollidays.Models;

namespace HappyHollidays.ORM
{
    public static class CadenesORM
    {
        //selecciono totes les cadenes
        public static List<cadenas> SelectAll()
        {
            List<cadenas> cadenes = new List<cadenas>();

            cadenes = (from c in Orm.bd.cadenas select c).ToList();

            return cadenes;
        }

        //inserto una cadena nova
        public static String InsertCadena(cadenas cadena)
        {
            Orm.bd.cadenas.Add(cadena);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

        //selecciono cadenes que coincideixin amb el nom que l'usuari introdueix per filtrar
        public static List<cadenas> SelectCadenesByName(string nom)
        {
            List<cadenas> cadenes = new List<cadenas>();

            cadenes = (from c in Orm.bd.cadenas
                       where c.nombre.ToLower().Contains(nom.ToLower())
                       select c).ToList();

            return cadenes;
        }

        //elimino una cadena
        public static void Delete(cadenas cadena)
        {
            Orm.bd.cadenas.Remove(cadena);
            Orm.MySavesChanges();
        }
    }

    
}
