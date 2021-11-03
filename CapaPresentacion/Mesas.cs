using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Mesas : Form
    {

        int posMouseFormX, posMouseFormY;
        int posMouseBotonX, posMouseBotonY;
        int posActBotonX, posActBotonY;
        bool botonPresionado = false;
        int count = 150;
        int index = 0;

        List<Button> lista_mesas = new List<Button>();

        public Mesas()
        {
            InitializeComponent();
            btn_mesa1.Visible = false;
        }

        private void Mesas_load1(object sender, EventArgs e)
        {
            posActBotonX = btn_mesa1.Location.X;
            posActBotonY = btn_mesa1.Location.Y;
        }

        private void Mesas_MauseMove(object sender, MouseEventArgs e)
        {
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
        }

        private void btn1Mover_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posActBotonY + e.Location.Y;
            if (botonPresionado == true) moverBoton();
        }

        private void moverBoton()
        {
            btn_mesa1.Location = new System.Drawing.Point(posMouseFormX - posMouseBotonX, posMouseFormY - posMouseBotonY);
            posActBotonX = btn_mesa1.Location.X;
            posActBotonY = btn_mesa1.Location.Y;
        }

        private void btn_mesa1_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
            botonPresionado = true;

        }

        private void btnMesa1_MouseUp(object sender, MouseEventArgs e)
        {
            botonPresionado = false;
        }






        private void agregarMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn_mesa = new Button();
            caractButton(btn_mesa);
            Controls.Add(btn_mesa);
            lista_mesas.ElementAt(index).Location = new System.Drawing.Point(count, count);
            index = index + 1;
            count = count + 100;
        }

        private void caractButton(Button btn_mesa){
            btn_mesa.Font = btn_mesa1.Font;
            btn_mesa.TextAlign = btn_mesa1.TextAlign;
            btn_mesa.ImageAlign = btn_mesa1.ImageAlign;
            btn_mesa.BackColor = btn_mesa1.BackColor;
            btn_mesa.Image = btn_mesa1.Image;
            btn_mesa.Location = new System.Drawing.Point(18, 206);
            btn_mesa.Enabled = true;
            btn_mesa.Visible = true;
            btn_mesa.Size = btn_mesa1.Size;
            int num = lista_mesas.Count() + 1;
            btn_mesa.TabIndex = num;
            btn_mesa.Text = "Mesa " + num;
            lista_mesas.Add(btn_mesa);
        }

        // Cerrar Sesion
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion presentacion = new Presentacion();
            presentacion.Show();
            this.Close();
        }

        

    }
}
