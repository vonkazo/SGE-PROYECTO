using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeBurger
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            OpenChildForm(new Empleado(this));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEmpleado_Click(object sender, EventArgs e)
        {

        }

        public void OpenChildForm(object formHija)
        {
            if (this.pContenedor.Controls.Count > 0)
            {
                this.pContenedor.Controls.RemoveAt(0);
            }

            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(fh);
            this.pContenedor.Tag = fh;
            fh.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void bProductos_Click(object sender, EventArgs e)
        {

        }

        private void bEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void bPedidos_Click(object sender, EventArgs e)
        {

        }

        private void bDistribuidores_Click(object sender, EventArgs e)
        {

        }

        private void bFacturas_Click(object sender, EventArgs e)
        {

        }

        private void bInventario_Click(object sender, EventArgs e)
        {

        }
    }
}
