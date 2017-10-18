using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculCaisse.Library;

namespace CalculCaisse.Forms
{
    public partial class CalculForm : Form
    {
        int nbB500, nbB200, nbB100, nbB50, nbB20, nbB10, nbB5;
        int nbP2, nbP1, nbP050, nbP020, nbP010, nbP005, nbP002, nbP001;
        int nbR2, nbR1, nbR050, nbR020, nbR010, nbR005, nbR002, nbR001;
        double totalCoffre, totalEspeces, totalDepot, differenceCaisse;

        Monnaie B500 = new Monnaie(500);
        Monnaie B200 = new Monnaie(200);
        Monnaie B100 = new Monnaie(100);
        Monnaie B50 = new Monnaie(50);
        Monnaie B20 = new Monnaie(20);
        Monnaie B10 = new Monnaie(10);
        Monnaie B5 = new Monnaie(5);
        Monnaie P2 = new Monnaie(2);
        Monnaie P1 = new Monnaie(1);
        Monnaie P050 = new Monnaie(0.5);
        Monnaie P020 = new Monnaie(0.2);
        Monnaie P010 = new Monnaie(0.1);
        Monnaie P005 = new Monnaie(0.05);
        Monnaie P002 = new Monnaie(0.02);
        Monnaie P001 = new Monnaie(0.01);
        Monnaie R2 = new Monnaie(50);
        Monnaie R1 = new Monnaie(25);
        Monnaie R050 = new Monnaie(20);
        Monnaie R020 = new Monnaie(8);
        Monnaie R010 = new Monnaie(4);
        Monnaie R005 = new Monnaie(2.5);
        Monnaie R002 = new Monnaie(1);
        Monnaie R001 = new Monnaie(0.5);

        public CalculForm()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
        }

        /// <summary>
        /// Exécute l'ensemble des calculs.
        /// </summary>
        private void ExecuteCalculs()
        {
            /* Récupération des données */
            if (String.IsNullOrEmpty(txtTotalCoffre.Text)) { totalCoffre = 0; } else { totalCoffre = double.Parse(txtTotalCoffre.Text); ; }
            if (String.IsNullOrEmpty(txtTotalEspeces.Text)) { totalEspeces = 0; } else { totalEspeces = double.Parse(txtTotalEspeces.Text); ; }
            if (String.IsNullOrEmpty(txtTotalDepot.Text)) { totalDepot = 0; } else { totalDepot = double.Parse(txtTotalDepot.Text); ; }

            /* Calculs */
            double totalCaisse = CalculBillets() 
                + CalculPieces() 
                + CalculRouleaux()
                + totalCoffre;

            differenceCaisse = totalCaisse - totalEspeces;

            /* Affichage */
            txtTotalCaisse.Text = totalCaisse.ToString("0.00");
            txtDifference.Text = differenceCaisse.ToString("0.00");
        }

        private void img_logo_Click(object sender, EventArgs e)
        {
            ExecuteCalculs();
        }

        /// <summary>
        /// Exécute le calcul des billest
        /// </summary>
        /// <returns>Le montant total des billets</returns>
        private double CalculBillets()
        {
            /* Récupération des données */
            if (String.IsNullOrEmpty(txtB500.Text)) { nbB500 = 0; } else { nbB500 = int.Parse(txtB500.Text); ; }
            if (String.IsNullOrEmpty(txtB200.Text)) { nbB200 = 0; } else { nbB200 = int.Parse(txtB200.Text); ; }
            if (String.IsNullOrEmpty(txtB100.Text)) { nbB100 = 0; } else { nbB100 = int.Parse(txtB100.Text); ; }
            if (String.IsNullOrEmpty(txtB50.Text)) { nbB50 = 0; } else { nbB50 = int.Parse(txtB50.Text); ; }
            if (String.IsNullOrEmpty(txtB20.Text)) { nbB20 = 0; } else { nbB20 = int.Parse(txtB20.Text); ; }
            if (String.IsNullOrEmpty(txtB10.Text)) { nbB10 = 0; } else { nbB10 = int.Parse(txtB10.Text); ; }
            if (String.IsNullOrEmpty(txtB5.Text)) { nbB5 = 0; } else { nbB5 = int.Parse(txtB5.Text); ; }

            /* Calcul */
            double totalB500 = B500.Total(nbB500);
            double totalB200 = B200.Total(nbB200);
            double totalB100 = B200.Total(nbB100);
            double totalB50 = B200.Total(nbB50);
            double totalB20 = B200.Total(nbB20);
            double totalB10 = B200.Total(nbB10);
            double totalB5 = B200.Total(nbB5);
            double totalBillets = totalB500 + totalB200 + totalB100 + totalB50 + totalB20 + totalB10 + totalB5;

            /* Affichage */
            txtTotalB500.Text = totalB500.ToString("0.00");
            txtTotalB200.Text = totalB200.ToString("0.00");
            txtTotalB100.Text = totalB100.ToString("0.00");
            txtTotalB50.Text = totalB50.ToString("0.00");
            txtTotalB20.Text = totalB20.ToString("0.00");
            txtTotalB10.Text = totalB10.ToString("0.00");
            txtTotalB5.Text = totalB5.ToString("0.00");
            txtTotalBillets.Text = totalBillets.ToString("0.00");

            return totalBillets;
        }

        /// <summary>
        /// Exécute le calcul des pièces
        /// </summary>
        /// <returns>Le montant total des pièces</returns>
        private double CalculPieces()
        {
            /* Récupération des données */
            if (String.IsNullOrEmpty(txtP2.Text)) { nbP2 = 0; } else { nbP2 = int.Parse(txtP2.Text); ; }
            if (String.IsNullOrEmpty(txtP1.Text)) { nbP1 = 0; } else { nbP1 = int.Parse(txtP1.Text); ; }
            if (String.IsNullOrEmpty(txtP050.Text)) { nbP050 = 0; } else { nbP050 = int.Parse(txtP050.Text); ; }
            if (String.IsNullOrEmpty(txtP020.Text)) { nbP020 = 0; } else { nbP020 = int.Parse(txtP020.Text); ; }
            if (String.IsNullOrEmpty(txtP010.Text)) { nbP010 = 0; } else { nbP010 = int.Parse(txtP010.Text); ; }
            if (String.IsNullOrEmpty(txtP005.Text)) { nbP005 = 0; } else { nbP005 = int.Parse(txtP005.Text); ; }
            if (String.IsNullOrEmpty(txtP002.Text)) { nbP002 = 0; } else { nbP002 = int.Parse(txtP002.Text); ; }
            if (String.IsNullOrEmpty(txtP001.Text)) { nbP001 = 0; } else { nbP001 = int.Parse(txtP001.Text); ; }

            /* Calcul */
            double totalP2 = P2.Total(nbP2);
            double totalP1 = P1.Total(nbP1);
            double totalP050 = P050.Total(nbP050);
            double totalP020 = P020.Total(nbP020);
            double totalP010 = P010.Total(nbP010);
            double totalP005 = P005.Total(nbP005);
            double totalP002 = P002.Total(nbP002);
            double totalP001 = P001.Total(nbP001);

            double totalPieces = totalP1 + totalP2 + totalP050 + totalP020 + totalP010 + totalP005 + totalP002 + totalP001;

            /* Affichage */
            txtTotalP2.Text = totalP2.ToString("0.00");
            txtTotalP1.Text = totalP1.ToString("0.00");
            txtTotalP050.Text = totalP050.ToString("0.00");
            txtTotalP020.Text = totalP020.ToString("0.00");
            txtTotalP010.Text = totalP010.ToString("0.00");
            txtTotalP005.Text = totalP005.ToString("0.00");
            txtTotalP002.Text = totalP002.ToString("0.00");
            txtTotalP001.Text = totalP001.ToString("0.00");
            txtTotalPieces.Text = totalPieces.ToString("0.00");

            return totalPieces;
        }

        /// <summary>
        /// Exécute le calcul des rouleaux
        /// </summary>
        /// <returns>Le montant total des rouleaux</returns>
        private double CalculRouleaux()
        {
            /* Récupération des données */
            if (String.IsNullOrEmpty(txtR2.Text)) { nbR2 = 0; } else { nbR2 = int.Parse(txtR2.Text); ; }
            if (String.IsNullOrEmpty(txtR1.Text)) { nbR1 = 0; } else { nbR1 = int.Parse(txtR1.Text); ; }
            if (String.IsNullOrEmpty(txtR050.Text)) { nbR050 = 0; } else { nbR050 = int.Parse(txtR050.Text); ; }
            if (String.IsNullOrEmpty(txtR020.Text)) { nbR020 = 0; } else { nbR020 = int.Parse(txtR020.Text); ; }
            if (String.IsNullOrEmpty(txtR010.Text)) { nbR010 = 0; } else { nbR010 = int.Parse(txtR010.Text); ; }
            if (String.IsNullOrEmpty(txtR005.Text)) { nbR005 = 0; } else { nbR005 = int.Parse(txtR005.Text); ; }
            if (String.IsNullOrEmpty(txtR002.Text)) { nbR002 = 0; } else { nbR002 = int.Parse(txtR002.Text); ; }
            if (String.IsNullOrEmpty(txtR001.Text)) { nbR001 = 0; } else { nbR001 = int.Parse(txtR001.Text); ; }

            /* Calcul */
            double totalR2 = R2.Total(nbR2);
            double totalR1 = R1.Total(nbR1);
            double totalR050 = R050.Total(nbR050);
            double totalR020 = R020.Total(nbR020);
            double totalR010 = R010.Total(nbR010);
            double totalR005 = R005.Total(nbR005);
            double totalR002 = R002.Total(nbR002);
            double totalR001 = R001.Total(nbR001);

            double totalRouleaux = totalR2 + totalR1 + totalR050 + totalR020 + totalR010 + totalR005 + totalR002 + totalR001;

            /* Affichage */
            txtTotalR2.Text = totalR2.ToString("0.00");
            txtTotalR1.Text = totalR1.ToString("0.00");
            txtTotalR050.Text = totalR050.ToString("0.00");
            txtTotalR020.Text = totalR020.ToString("0.00");
            txtTotalR010.Text = totalR010.ToString("0.00");
            txtTotalR005.Text = totalR005.ToString("0.00");
            txtTotalR002.Text = totalR002.ToString("0.00");
            txtTotalR001.Text = totalR001.ToString("0.00");
            txtTotalRouleaux.Text = totalRouleaux.ToString("0.00");

            return totalRouleaux;
        }
    }
}
