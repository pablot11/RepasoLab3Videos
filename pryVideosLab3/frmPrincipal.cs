using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVideosLab3
{
    public partial class Form1 : Form
    {
        Autores a;
        Videos v;
        string Archivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            wmpVideos.URL = "VIDEOS/11.mp4" + Archivo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArmarArbolito();
            wmpVideos.uiMode = "None";

        }

        private void ArmarArbolito()
        {
            a = new Autores();
            v = new Videos();
            TreeNode abuelo;
            TreeNode padre;
            TreeNode hijo;

            abuelo = tvVideos.Nodes.Add("Autores");

            DataTable tablautores = a.getAutores();
            DataTable tablavideos = v.getVideos();
            foreach (DataRow filautores in tablautores.Rows)
            {
                padre = abuelo.Nodes.Add(filautores["nombre"].ToString());

                foreach (DataRow filavideos in tablavideos.Rows)
                {
                    if (filautores["autor"].ToString() == filavideos["autor"].ToString())
                    {
                        hijo = padre.Nodes.Add(filavideos["Video"].ToString());
                        hijo.Tag = filavideos["archivo"].ToString();

                    }
                }


            }




        }

        private void tvVideos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                Archivo = e.Node.Tag.ToString();
            }
        }
    }
}
