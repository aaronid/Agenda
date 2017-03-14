using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Reveil
{

    public partial class Reveil : Form
    {

        //--- Propriétés ---
        private SortedList<DateTime,Rappel> rappels = new SortedList<DateTime,Rappel>() ;
        private string nomfic = "ficserialise";

        //--- Constructeur ---
        public Reveil()
        {
            //--- initialisation des composants (méthode dans l'autre partie de la classe) ---
            InitializeComponent();

            //--- récupération des rappels sérialisés ---
            Object recup = Serialise.Recup(nomfic);
            if (recup != null)
            {
                this.rappels = (SortedList<DateTime, Rappel>)recup;
            }

            //--- sélection par défaut de la fréquence unique ---
            this.cboFrequence.SelectedIndex = 0;

            //--- remplissage éventuel de la liste des rappels ---
            this.majListeRappels(0);
        }

        //--- Sur le clic du bouton Ajout : ajout d'un nouveau rappel ---
        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (this.txtRappel.Text != "")
            {
                DateTime ladate = new DateTime(this.dtpJour.Value.Year, this.dtpJour.Value.Month, this.dtpJour.Value.Day,
                                               this.dtpHeure.Value.Hour, this.dtpHeure.Value.Minute, 0);
                if (!this.rappels.ContainsKey(ladate))
                {
                    Rappel lerappel = new Rappel(this.txtRappel.Text, ladate, this.cboFrequence.SelectedIndex);
                    this.rappels.Add(ladate, lerappel);
                    this.majListeRappels(this.rappels.IndexOfKey(ladate));
                }
                else
                {
                    MessageBox.Show("Un rappel existe déjà à cette date et heure : \r\n" +
                                    this.rappels[ladate].getDate() + " : " + this.rappels[ladate].getLibelle());
                }
            }
            else
            {
                MessageBox.Show("Le libellé du rappel doit être rempli");
            }
        }

        //--- Mise à jour de la liste des rappels avec les rappels de la collection ---
        private void majListeRappels(int actif)
        {
            lstEnsemble.Items.Clear();
            foreach (Rappel lerappel in this.rappels.Values)
            {
                this.lstEnsemble.Items.Add(lerappel.getDate().ToShortDateString() + " " + 
                                      lerappel.getDate().ToShortTimeString() + " : " + 
                                      lerappel.getLibelle());
            }
            if (this.lstEnsemble.Items.Count != 0)
            {
                this.lstEnsemble.SelectedIndex = Math.Min(actif, this.lstEnsemble.Items.Count-1) ;
            }
            Serialise.Sauve(nomfic, this.rappels);
        }

        //--- Sur le clic du bouton Vider : vide le dictionnaire des rappels ---
        private void btnVider_Click(object sender, EventArgs e)
        {
            this.rappels.Clear();
            this.majListeRappels(0);
        }

        //--- Sur le clic du bouton Suppr : supprime l'élément sélectionné ---
        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (this.lstEnsemble.SelectedIndex != -1)
            {
                this.supprRappel(this.lstEnsemble.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Un élement de la liste doit être sélectionné");
            }
        }

        //--- Sur le clic du bouton Modif : modifie l'élément sélectionné ---
        private void btnModif_Click(object sender, EventArgs e)
        {
            int k = this.lstEnsemble.SelectedIndex;
            if (k != -1)
            {
                //--- transfert des informations vers la zone d'ajout ---
                this.dtpJour.Value = this.rappels.Values[k].getDate();
                this.dtpHeure.Value = this.rappels.Values[k].getDate();
                this.cboFrequence.SelectedIndex = this.rappels.Values[k].getFrequence();
                this.txtRappel.Text = this.rappels.Values[k].getLibelle();
                
                //--- suppression du rappel dans la liste ---
                this.supprRappel(k);
            }
            else
            {
                MessageBox.Show("Un élement de la liste doit être sélectionné");
            }

        }

        //--- toutes les 30s, controle les rappels arrivés à échéance ---
        private void tmrRappel_Tick(object sender, EventArgs e)
        {
            int k = 0;
            while (k < this.rappels.Count && this.rappels.Values[k].getDate() <= DateTime.Now)
            {
                MessageBox.Show(this.rappels.Values[k].getDate()+" : "+
                                this.rappels.Values[k].getLibelle()+"\r\n"+
                                "fréquence = "+
                                this.Controls["grpEnsemble"].Controls["label"+this.rappels.Values[k].getFrequence()].Text);
                if (this.rappels.Values[k].getFrequence() == 0)
                {
                    this.supprRappel(k);  // suppression du rappel de fréquence unique
                }
                else
                {
                    this.rappels.Values[k].suivant();   // changement d'échéance pour les autres types de rappels
                    Rappel r = this.rappels.Values[k];
                    this.rappels.RemoveAt(k);
                    this.rappels.Add(r.getDate(),r);
                    this.majListeRappels(this.rappels.IndexOfKey(r.getDate()));
                }
            }
        }

        //--- Suppression d'un rappel suivant son indice ---
        private void supprRappel (int k) 
        {
            this.rappels.RemoveAt(k);
            this.majListeRappels(k);
        }

        //--- Sur l'écriture d'une ligne : gestion des couleurs ---
        private void lstEnsemble_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the color of the brush.
            Brush myBrush = new SolidBrush((this.Controls["grpEnsemble"].Controls["label"+this.rappels.Values[e.Index].getFrequence()]).ForeColor);
            // Draw the current item text based on the current Font and the custom brush settings.
            e.Graphics.DrawString(lstEnsemble.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();

        }

        //--- toutes les secondes, mise à jour de la date et l'heure actuelle ---
        private void tmrMaintenant_Tick(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Now.ToShortDateString();
            this.lblHeure.Text = DateTime.Now.ToLongTimeString();
        }

        //--- Sur la validation de la zone du libellé du rappel, idem que sur le clic d'Ajout ---
        private void txtRappel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnAjout_Click(sender, e);
            }
        }

        //--- Sur le clic du bouton Min, cache la fenêtre et fait apparaitre l'icone ---
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.icoReveil.Visible = true;
            this.Hide();
        }

        //--- Sur le clic sur l'icone, rend à nouveau la fenêtre visible ---
        private void icoReveil_Click(object sender, EventArgs e)
        {
            this.icoReveil.Visible = false;
            this.Show();
        }


    }
}