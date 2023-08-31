
namespace ProjetWindowsDotNet
{
    partial class Produits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.SupplierID = new System.Windows.Forms.TextBox();
            this.CategoryID = new System.Windows.Forms.TextBox();
            this.UnitPrice = new System.Windows.Forms.TextBox();
            this.QuantityPerUnit = new System.Windows.Forms.TextBox();
            this.UnitsInStock = new System.Windows.Forms.TextBox();
            this.UnitsOnOrder = new System.Windows.Forms.TextBox();
            this.ReorderLevel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Discontinued = new System.Windows.Forms.TextBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SupplierID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CategoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "QuantityPerUnit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "UnitPrice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "UnitsInStock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "UnitsOnOrder";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "ReorderLevel";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(177, 23);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(129, 26);
            this.ProductName.TabIndex = 8;
            this.ProductName.TextChanged += new System.EventHandler(this.ProductName_TextChanged);
            // 
            // SupplierID
            // 
            this.SupplierID.Location = new System.Drawing.Point(177, 68);
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.Size = new System.Drawing.Size(129, 26);
            this.SupplierID.TabIndex = 9;
            this.SupplierID.TextChanged += new System.EventHandler(this.SupplierID_TextChanged);
            // 
            // CategoryID
            // 
            this.CategoryID.Location = new System.Drawing.Point(177, 118);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(129, 26);
            this.CategoryID.TabIndex = 10;
            this.CategoryID.TextChanged += new System.EventHandler(this.CategoryID_TextChanged);
            // 
            // UnitPrice
            // 
            this.UnitPrice.Location = new System.Drawing.Point(177, 225);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(129, 26);
            this.UnitPrice.TabIndex = 11;
            this.UnitPrice.TextChanged += new System.EventHandler(this.UnitPrice_TextChanged);
            // 
            // QuantityPerUnit
            // 
            this.QuantityPerUnit.Location = new System.Drawing.Point(177, 169);
            this.QuantityPerUnit.Name = "QuantityPerUnit";
            this.QuantityPerUnit.Size = new System.Drawing.Size(129, 26);
            this.QuantityPerUnit.TabIndex = 12;
            this.QuantityPerUnit.TextChanged += new System.EventHandler(this.QuantityPerUnit_TextChanged);
            // 
            // UnitsInStock
            // 
            this.UnitsInStock.Location = new System.Drawing.Point(177, 288);
            this.UnitsInStock.Name = "UnitsInStock";
            this.UnitsInStock.Size = new System.Drawing.Size(129, 26);
            this.UnitsInStock.TabIndex = 13;
            this.UnitsInStock.TextChanged += new System.EventHandler(this.UnitsInStock_TextChanged);
            // 
            // UnitsOnOrder
            // 
            this.UnitsOnOrder.Location = new System.Drawing.Point(177, 360);
            this.UnitsOnOrder.Name = "UnitsOnOrder";
            this.UnitsOnOrder.Size = new System.Drawing.Size(129, 26);
            this.UnitsOnOrder.TabIndex = 14;
            this.UnitsOnOrder.TextChanged += new System.EventHandler(this.UnitsOnOrder_TextChanged);
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.Location = new System.Drawing.Point(177, 442);
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.Size = new System.Drawing.Size(129, 26);
            this.ReorderLevel.TabIndex = 15;
            this.ReorderLevel.TextChanged += new System.EventHandler(this.ReorderLevel_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Discontinued";
            // 
            // Discontinued
            // 
            this.Discontinued.Location = new System.Drawing.Point(177, 529);
            this.Discontinued.Name = "Discontinued";
            this.Discontinued.Size = new System.Drawing.Size(129, 26);
            this.Discontinued.TabIndex = 17;
            this.Discontinued.TextChanged += new System.EventHandler(this.Discontinued_TextChanged);
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(452, 146);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(120, 49);
            this.enregistrer.TabIndex = 18;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 652);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.Discontinued);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ReorderLevel);
            this.Controls.Add(this.UnitsOnOrder);
            this.Controls.Add(this.UnitsInStock);
            this.Controls.Add(this.QuantityPerUnit);
            this.Controls.Add(this.UnitPrice);
            this.Controls.Add(this.CategoryID);
            this.Controls.Add(this.SupplierID);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Produits";
            this.Text = "Clirnts";
            this.Load += new System.EventHandler(this.Produits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox SupplierID;
        private System.Windows.Forms.TextBox CategoryID;
        private System.Windows.Forms.TextBox UnitPrice;
        private System.Windows.Forms.TextBox QuantityPerUnit;
        private System.Windows.Forms.TextBox UnitsInStock;
        private System.Windows.Forms.TextBox UnitsOnOrder;
        private System.Windows.Forms.TextBox ReorderLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Discontinued;
        private System.Windows.Forms.Button enregistrer;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.DataSet dataSet1;
    }
}