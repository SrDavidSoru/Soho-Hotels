using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyHollidays.Forms;

namespace HappyHollidays
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void hotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotels hotels = new Hotels() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(hotels);
            hotels.FormBorderStyle = FormBorderStyle.None;
            hotels.Show();
        }

        private void cadenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadenes cadenes = new Cadenes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(cadenes);
            cadenes.FormBorderStyle = FormBorderStyle.None;
            cadenes.Show();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
