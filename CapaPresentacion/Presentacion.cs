using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Presentacion : Form
    {

        public Presentacion()
        {
            InitializeComponent();
        }

        private void pBox_Cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_iniSesion_Click(object sender, EventArgs e)
        {
            Logica logica = new Logica();
            if (logica.revisarCredenciales(txt_usuario.Text, txt_contaseña.Text) == true)
            {
                Mesas mesas = new Mesas();
                this.Visible = false;
                mesas.Show();
            }
            else {
                MessageBox.Show(logica.getAlerta());
            }
            
        }
    }
}
