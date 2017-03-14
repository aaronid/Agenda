namespace Reveil
{
    partial class Reveil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reveil));
            this.grpRappel = new System.Windows.Forms.GroupBox();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRappel = new System.Windows.Forms.TextBox();
            this.cboFrequence = new System.Windows.Forms.ComboBox();
            this.dtpJour = new System.Windows.Forms.DateTimePicker();
            this.btnAjout = new System.Windows.Forms.Button();
            this.grpEnsemble = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.lstEnsemble = new System.Windows.Forms.ListBox();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.grpMaintenant = new System.Windows.Forms.GroupBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrRappel = new System.Windows.Forms.Timer(this.components);
            this.tmrMaintenant = new System.Windows.Forms.Timer(this.components);
            this.icoReveil = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMin = new System.Windows.Forms.Button();
            this.grpRappel.SuspendLayout();
            this.grpEnsemble.SuspendLayout();
            this.grpMaintenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRappel
            // 
            this.grpRappel.Controls.Add(this.dtpHeure);
            this.grpRappel.Controls.Add(this.label9);
            this.grpRappel.Controls.Add(this.label7);
            this.grpRappel.Controls.Add(this.label6);
            this.grpRappel.Controls.Add(this.txtRappel);
            this.grpRappel.Controls.Add(this.cboFrequence);
            this.grpRappel.Controls.Add(this.dtpJour);
            this.grpRappel.Controls.Add(this.btnAjout);
            this.grpRappel.Location = new System.Drawing.Point(12, 12);
            this.grpRappel.Name = "grpRappel";
            this.grpRappel.Size = new System.Drawing.Size(373, 84);
            this.grpRappel.TabIndex = 0;
            this.grpRappel.TabStop = false;
            this.grpRappel.Text = "Un rappel";
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(104, 35);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.ShowUpDown = true;
            this.dtpHeure.Size = new System.Drawing.Size(73, 20);
            this.dtpHeure.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "fréquence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "heure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "date";
            // 
            // txtRappel
            // 
            this.txtRappel.Location = new System.Drawing.Point(6, 59);
            this.txtRappel.Name = "txtRappel";
            this.txtRappel.Size = new System.Drawing.Size(298, 20);
            this.txtRappel.TabIndex = 5;
            this.txtRappel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRappel_KeyPress);
            // 
            // cboFrequence
            // 
            this.cboFrequence.FormattingEnabled = true;
            this.cboFrequence.Items.AddRange(new object[] {
            "Unique",
            "Journalier",
            "Hebdomadaire",
            "Mensuel",
            "Annuel"});
            this.cboFrequence.Location = new System.Drawing.Point(183, 34);
            this.cboFrequence.Name = "cboFrequence";
            this.cboFrequence.Size = new System.Drawing.Size(121, 21);
            this.cboFrequence.TabIndex = 4;
            // 
            // dtpJour
            // 
            this.dtpJour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJour.Location = new System.Drawing.Point(6, 35);
            this.dtpJour.Name = "dtpJour";
            this.dtpJour.Size = new System.Drawing.Size(92, 20);
            this.dtpJour.TabIndex = 1;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(310, 35);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(57, 45);
            this.btnAjout.TabIndex = 0;
            this.btnAjout.Text = "Ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // grpEnsemble
            // 
            this.grpEnsemble.Controls.Add(this.label4);
            this.grpEnsemble.Controls.Add(this.label3);
            this.grpEnsemble.Controls.Add(this.label2);
            this.grpEnsemble.Controls.Add(this.label1);
            this.grpEnsemble.Controls.Add(this.label0);
            this.grpEnsemble.Controls.Add(this.lstEnsemble);
            this.grpEnsemble.Controls.Add(this.btnVider);
            this.grpEnsemble.Controls.Add(this.btnSuppr);
            this.grpEnsemble.Controls.Add(this.btnModif);
            this.grpEnsemble.Location = new System.Drawing.Point(12, 102);
            this.grpEnsemble.Name = "grpEnsemble";
            this.grpEnsemble.Size = new System.Drawing.Size(516, 193);
            this.grpEnsemble.TabIndex = 1;
            this.grpEnsemble.TabStop = false;
            this.grpEnsemble.Text = "Ensemble des rappels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(401, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Annuel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(307, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mensuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(180, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hebdomadaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(87, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Journalier";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.Color.Black;
            this.label0.Location = new System.Drawing.Point(6, 169);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(47, 13);
            this.label0.TabIndex = 4;
            this.label0.Text = "Unique";
            // 
            // lstEnsemble
            // 
            this.lstEnsemble.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEnsemble.FormattingEnabled = true;
            this.lstEnsemble.Location = new System.Drawing.Point(6, 19);
            this.lstEnsemble.Name = "lstEnsemble";
            this.lstEnsemble.Size = new System.Drawing.Size(441, 147);
            this.lstEnsemble.TabIndex = 3;
            this.lstEnsemble.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstEnsemble_DrawItem);
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(453, 121);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(57, 45);
            this.btnVider.TabIndex = 2;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(453, 70);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(57, 45);
            this.btnSuppr.TabIndex = 1;
            this.btnSuppr.Text = "Suppr";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(453, 19);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(57, 45);
            this.btnModif.TabIndex = 0;
            this.btnModif.Text = "Modif";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // grpMaintenant
            // 
            this.grpMaintenant.Controls.Add(this.lblHeure);
            this.grpMaintenant.Controls.Add(this.lblDate);
            this.grpMaintenant.Location = new System.Drawing.Point(391, 12);
            this.grpMaintenant.Name = "grpMaintenant";
            this.grpMaintenant.Size = new System.Drawing.Size(137, 84);
            this.grpMaintenant.TabIndex = 2;
            this.grpMaintenant.TabStop = false;
            this.grpMaintenant.Text = "Maintenant";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(11, 46);
            this.lblHeure.MinimumSize = new System.Drawing.Size(120, 20);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(120, 20);
            this.lblHeure.TabIndex = 1;
            this.lblHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(11, 18);
            this.lblDate.MinimumSize = new System.Drawing.Size(120, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrRappel
            // 
            this.tmrRappel.Enabled = true;
            this.tmrRappel.Interval = 30000;
            this.tmrRappel.Tick += new System.EventHandler(this.tmrRappel_Tick);
            // 
            // tmrMaintenant
            // 
            this.tmrMaintenant.Enabled = true;
            this.tmrMaintenant.Interval = 1000;
            this.tmrMaintenant.Tick += new System.EventHandler(this.tmrMaintenant_Tick);
            // 
            // icoReveil
            // 
            this.icoReveil.Icon = ((System.Drawing.Icon)(resources.GetObject("icoReveil.Icon")));
            this.icoReveil.Text = "liste des rappels";
            this.icoReveil.Click += new System.EventHandler(this.icoReveil_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(500, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(27, 11);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Reveil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 306);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.grpMaintenant);
            this.Controls.Add(this.grpEnsemble);
            this.Controls.Add(this.grpRappel);
            this.Name = "Reveil";
            this.Text = "Réveil";
            this.grpRappel.ResumeLayout(false);
            this.grpRappel.PerformLayout();
            this.grpEnsemble.ResumeLayout(false);
            this.grpEnsemble.PerformLayout();
            this.grpMaintenant.ResumeLayout(false);
            this.grpMaintenant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRappel;
        private System.Windows.Forms.GroupBox grpEnsemble;
        private System.Windows.Forms.GroupBox grpMaintenant;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.DateTimePicker dtpJour;
        private System.Windows.Forms.ComboBox cboFrequence;
        private System.Windows.Forms.TextBox txtRappel;
        private System.Windows.Forms.ListBox lstEnsemble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.DateTimePicker dtpHeure;
        private System.Windows.Forms.Timer tmrRappel;
        private System.Windows.Forms.Timer tmrMaintenant;
        private System.Windows.Forms.NotifyIcon icoReveil;
        private System.Windows.Forms.Button btnMin;
    }
}

