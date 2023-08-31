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
    public partial class ListesCommandes : Form
    {
        public ListesCommandes()
        {
            InitializeComponent();
        }

        private void ListesCommandes_Load(object sender, EventArgs e)
        {
            this.sqlDataAdapter1.Fill(this.dataSet1); //Charger les données au niveau des dataSet ou on appelle la methode FILL qui prend en parametre le dataSet11
            this.dataGridView1.DataSource = this.dataSet1; //Source de Données pour les dataGrid
            this.dataGridView1.DataMember = "Orders"; //dataMember preciser la table a afficher  de la propriété dataMember

        }
    }
}
