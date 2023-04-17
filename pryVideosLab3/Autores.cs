using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace pryVideosLab3
{
    class Autores
    {
        private string Cadena = "provider=microsoft.jet.oledb.4.0;data source=YOUTUBE_MIGUEL.mdb";
        private OleDbConnection Conector;
        private OleDbCommand Comando; //Envia el comando a la base de datos
        private OleDbDataAdapter Adaptador; //Da la orden de hacer las acciones del comando
        private DataTable Tabla;

        public Autores()
        {
            Cadena = Config.getCadena();
            Conector = new OleDbConnection(Cadena);
            Comando = new OleDbCommand();
            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Autores";
            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);

            //Cual es la clave principal de la tabla
            DataColumn[] Vector = new DataColumn[1];
            Vector[0] = Tabla.Columns["autor"];
            Tabla.PrimaryKey = Vector;
        }
        public DataTable getAutores()
        {
            return Tabla;

        }
















    }








}
