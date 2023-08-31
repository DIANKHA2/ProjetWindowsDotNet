using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetWindowsDotNet
{

    public partial class Produits : Form
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-NJSVP6Q\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
        SqlCommand cmd;
        public Produits()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Produits_Load(object sender, EventArgs e)
        {
           // this.sqlDataAdapter1.Fill(this.dataSet1);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {

            if (ProductName.Text == "Nom produit")
            {
                ProductName.Text = " ";
            }
        }

        private void SupplierID_TextChanged(object sender, EventArgs e)
        {
            if (SupplierID.Text == " Supplier")
            {
                SupplierID.Text = " ";
            }
        }

        private void CategoryID_TextChanged(object sender, EventArgs e)
        {
            if (CategoryID.Text == " Categorie du produit")
            {
                CategoryID.Text = "";
            }
        }

        private void QuantityPerUnit_TextChanged(object sender, EventArgs e)
        {
            if (QuantityPerUnit.Text == " Quantite prix Unitaire")
            {
                QuantityPerUnit.Text = "";
            }
        }

        private void UnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (UnitPrice.Text == "Prix Uniataire")
            {
                UnitPrice.Text = " ";
            }
        }

        private void UnitsInStock_TextChanged(object sender, EventArgs e)
        {
            if (UnitsInStock.Text == "unite stock")
            {
                UnitsInStock.Text = " ";

            }
        }

        private void UnitsOnOrder_TextChanged(object sender, EventArgs e)
        {
            if (UnitsOnOrder.Text == "unite Commande")
            {
                UnitsOnOrder.Text = "";
            }
        }

        private void ReorderLevel_TextChanged(object sender, EventArgs e)
        {
            if (ReorderLevel.Text == "Reorder Level")
            {
                ReorderLevel.Text = " ";
            }
        }

        private void Discontinued_TextChanged(object sender, EventArgs e)
        {
            if (Discontinued.Text == "Deconnecter")
            {
                Discontinued.Text = "";
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            con.Open();
            String nomproduit = ProductName.Text;
            String supplierid = SupplierID.Text;
            String categorieid = CategoryID.Text;
            String quantiteprix = QuantityPerUnit.Text;
            String prixUnitaire = UnitPrice.Text;
            String uniteStock = UnitsInStock.Text;
            String UniteCommande = UnitsOnOrder.Text;
            String niveauReapprovisionnement = ReorderLevel.Text;
            String deconnect = Discontinued.Text;

            if (nomproduit != "" && supplierid != "" && categorieid != "" && quantiteprix != "" && prixUnitaire != ""
                && uniteStock != "" && UniteCommande != "" && niveauReapprovisionnement != "" && deconnect != "")
            {

                cmd.CommandText = " insert into Products values('" + nomproduit + "' ,'" + supplierid + "', '" + categorieid + "' ,'" + quantiteprix + "', '" + prixUnitaire + "', '" + uniteStock + "' ,'" + UniteCommande + "' ,'" + niveauReapprovisionnement + "' ,'" + deconnect + "')";
                if (cmd.ExecuteNonQuery() > 0)//renvoi nombre de lignes affectées

                {
                    MessageBox.Show(this, "Le produit" + nomproduit + "a été  inséré avec succès");
                }
                else
                {
                    MessageBox.Show(this, "Veuillez remplir les champs ");

                }

            }
            con.Close();
        }
      
    }
}
