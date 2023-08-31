using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWindowsDotNet
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HelloWorld");
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            ListesProduits listesProduits = new ListesProduits();
            listesProduits.ShowDialog();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            ListesClients listesClients = new ListesClients();
            listesClients.ShowDialog();
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            ListesCommandes listesCommandes = new ListesCommandes();
            listesCommandes.ShowDialog();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Produits produits = new Produits();
            produits.ShowDialog();
        }
    }
}
