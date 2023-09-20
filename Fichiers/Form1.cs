using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichiers
{
    public partial class Form1 : Form
    {
        string dossier;
        public Form1()
        {
            InitializeComponent();
        }
        private void enleveSelection(ListBox listB)
        {
            // Vérifier si un élément est sélectionné
            if (listB.SelectedIndex != -1)
            {
                // Deselectionner l'élément en réinitialisant SelectedIndex à -1
                listB.SelectedIndex = -1;
            }
        }
        private void nbFichiersListes() //Actualise le nombre de fichiers dans chaque liste
        {
            lblFichiers.Text = lstFichiers.Items.Count.ToString()+ " fichier(s) dans le dossier";
            lblFicSelec.Text = lstSelection.Items.Count.ToString()+ " fichiers(s) dans le dossier";
        }
        private void btnVider_Click(object sender, EventArgs e)
        {
            lstFichiers.Items.Clear();
            lstSelection.Items.Clear();
            lblFichiers.Text = "";
            lblFicSelec.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnVider_Click(null, null);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog rechercheDossier = new System.Windows.Forms.FolderBrowserDialog();
            rechercheDossier.Description = "Sélectionner un dossier";
            DialogResult choix = rechercheDossier.ShowDialog();
            if (choix == DialogResult.OK)
            {
                dossier = rechercheDossier.SelectedPath;
                btnVider_Click(null, null);
                foreach (string fichier in System.IO.Directory.GetFiles(dossier))
                {
                    string nom = System.IO.Path.GetFileName(fichier);
                    lstFichiers.Items.Add(nom);
                }
                if (lstFichiers.Items.Count > 0)
                {
                    nbFichiersListes();
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (lstFichiers.SelectedIndex!=-1)
            {
                bool elementTrouve = false; // Variable pour stocker le résultat de la recherche

                foreach (string item in lstSelection.Items)
                {
                    if (lstFichiers.SelectedItem.Equals(item))
                    {
                        // L'élément est trouvé dans la ListBox
                        elementTrouve = true;
                        break; // Sortir de la boucle dès que l'élément est trouvé
                    }
                }

                if (!elementTrouve) //élément non trouvé
                {
                    lstSelection.Items.Add(lstFichiers.SelectedItem);
                    lstFichiers.Items.Remove(lstFichiers.SelectedItem);
                    nbFichiersListes();
                    enleveSelection(lstFichiers);
                    enleveSelection(lstSelection);
                }
            }
        }

        private void btnTout_Click(object sender, EventArgs e)
        {
            // Parcours des éléments de lstFichiers
            for (int i=0; i< lstFichiers.Items.Count; i++)
            {
                lstSelection.Items.Add(lstFichiers.Items[i]);
            }
            lstFichiers.Items.Clear();
            enleveSelection(lstSelection);
            nbFichiersListes();
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (lstSelection.SelectedIndex != -1)
            {
                lstSelection.Items.Remove(lstSelection.SelectedItem);
                enleveSelection(lstSelection);
                nbFichiersListes();
            }
        }
    }
}
