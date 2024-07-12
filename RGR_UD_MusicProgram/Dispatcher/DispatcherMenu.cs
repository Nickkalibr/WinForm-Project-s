using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_UD_MusicProgram.Dispatcher
{
    public partial class DispatcherMenu : Form
    {
        public DispatcherMenu()
        {
            InitializeComponent();
        }

        private void Shipbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            User.ShipAdd sa = new User.ShipAdd();
            sa.Show();
        }

        private void Cargobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Executor.CargoAdd ca = new Executor.CargoAdd();
            ca.Show();
        }

        private void Pathbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Executor.PathAdd pa = new Executor.PathAdd();
        }

        private void Ordersbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
