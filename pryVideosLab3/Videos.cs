﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace pryVideosLab3
{
    internal class Videos
    {
        private string Cadena = "provider=microsoft.jet.oledb.4.0;data source=YOUTUBE_MIGUEL.mdb";
        private OleDbConnection Conector;
        private OleDbCommand Comando; //Envia el comando a la base de datos
        private OleDbDataAdapter Adaptador; //Da la orden de hacer las acciones del comando
        private DataTable Tabla;

        public Videos()
        {
            Cadena = Config.getCadena();
            Conector = new OleDbConnection(Cadena);
            Comando = new OleDbCommand();
            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Videos";
            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);

            //Cual es la clave principal de la tabla
            DataColumn[] Vector = new DataColumn[1];
            Vector[0] = Tabla.Columns["video"];
            Tabla.PrimaryKey = Vector;
        }
        public DataTable getVideos()
        {
            return Tabla;

        }











    }
}
