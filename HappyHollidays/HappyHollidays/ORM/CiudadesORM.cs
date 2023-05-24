using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyHollidays.Models;

namespace HappyHollidays.ORM
{
    public static class CiudadesORM
    {
        public static List<ciudades> SelectAll()
        {
            List<ciudades> ciutats= new List<ciudades>();

            ciutats = (from c in Orm.bd.ciudades select c).ToList();

            return ciutats;
        }
    }
}
