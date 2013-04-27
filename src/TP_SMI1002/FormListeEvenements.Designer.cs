namespace TP_SMI1002
{
    partial class FormListeEvenements
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lsvEvenement = new System.Windows.Forms.ListView();
            this.clnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDebut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnLieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNbrPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPrix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Image = global::TP_SMI1002.Properties.Resources.Delete;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(518, 321);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Image = global::TP_SMI1002.Properties.Resources.Modify;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(437, 321);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Image = global::TP_SMI1002.Properties.Resources.New_document;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(356, 321);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Image = global::TP_SMI1002.Properties.Resources.Cancel;
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(599, 321);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lsvEvenement
            // 
            this.lsvEvenement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnNom,
            this.clnDebut,
            this.clnFin,
            this.clnLieu,
            this.clnAdresse,
            this.clnNbrPlace,
            this.clnPrix});
            this.lsvEvenement.FullRowSelect = true;
            this.lsvEvenement.Location = new System.Drawing.Point(12, 12);
            this.lsvEvenement.MultiSelect = false;
            this.lsvEvenement.Name = "lsvEvenement";
            this.lsvEvenement.Size = new System.Drawing.Size(662, 295);
            this.lsvEvenement.TabIndex = 25;
            this.lsvEvenement.UseCompatibleStateImageBehavior = false;
            this.lsvEvenement.View = System.Windows.Forms.View.Details;
            // 
            // clnNom
            // 
            this.clnNom.Text = "Nom évènement";
            this.clnNom.Width = 145;
            // 
            // clnDebut
            // 
            this.clnDebut.Text = "Début";
            this.clnDebut.Width = 102;
            // 
            // clnFin
            // 
            this.clnFin.Text = "Fin";
            this.clnFin.Width = 87;
            // 
            // clnLieu
            // 
            this.clnLieu.Text = "Lieu";
            this.clnLieu.Width = 98;
            // 
            // clnAdresse
            // 
            this.clnAdresse.Text = "Adresse";
            this.clnAdresse.Width = 87;
            // 
            // clnNbrPlace
            // 
            this.clnNbrPlace.Text = "Nbr Place";
            // 
            // clnPrix
            // 
            this.clnPrix.Text = "Prix";
            // 
            // FormListeEvenements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 356);
            this.Controls.Add(this.lsvEvenement);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FormListeEvenements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeEvenements";
            this.Load += new System.EventHandler(this.ListeEvenements_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ListView lsvEvenement;
        private System.Windows.Forms.ColumnHeader clnNom;
        private System.Windows.Forms.ColumnHeader clnDebut;
        private System.Windows.Forms.ColumnHeader clnFin;
        private System.Windows.Forms.ColumnHeader clnLieu;
        private System.Windows.Forms.ColumnHeader clnAdresse;
        private System.Windows.Forms.ColumnHeader clnNbrPlace;
        private System.Windows.Forms.ColumnHeader clnPrix;
    }
}