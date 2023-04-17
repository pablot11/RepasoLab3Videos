using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVideosLab3
{
    internal class Config
    {
        //Al declarar esta funcion static puedo llamar sin necesidad de crear un obj
        public static string getCadena()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=YOUTUBE_MIGUEL.mdb";
            return cadena;
        }












    }
}
