namespace TP_SMI1002
{
    partial class FormEvenement
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSupprimerMembre = new System.Windows.Forms.Button();
            this.btnAjouterTournoi = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifierTournoi = new System.Windows.Forms.Button();
            this.txtNbrPlace = new System.Windows.Forms.TextBox();
            this.lblNombrePlace = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 19);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(22, 44);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(42, 13);
            this.lblDebut.TabIndex = 1;
            this.lblDebut.Text = "Début :";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(22, 67);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(27, 13);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Fin :";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(22, 89);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(33, 13);
            this.lblLieu.TabIndex = 3;
            this.lblLieu.Text = "Lieu :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(22, 111);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(22, 135);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(120, 16);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(248, 20);
            this.txtNom.TabIndex = 16;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(120, 44);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(145, 20);
            this.dtpDebut.TabIndex = 17;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(120, 67);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(145, 20);
            this.dtpFin.TabIndex = 18;
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(119, 89);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(248, 20);
            this.txtLieu.TabIndex = 19;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(119, 111);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(248, 20);
            this.txtAdresse.TabIndex = 20;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(119, 132);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(248, 20);
            this.txtVille.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Liste des tournois";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(28, 234);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(341, 167);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSupprimerMembre
            // 
            this.btnSupprimerMembre.Image = global::TP_SMI1002.Properties.Resources.Delete;
            this.btnSupprimerMembre.Location = new System.Drawing.Point(342, 208);
            this.btnSupprimerMembre.Name = "btnSupprimerMembre";
            this.btnSupprimerMembre.Size = new System.Drawing.Size(27, 23);
            this.btnSupprimerMembre.TabIndex = 27;
            this.btnSupprimerMembre.UseVisualStyleBackColor = true;
            // 
            // btnAjouterTournoi
            // 
            this.btnAjouterTournoi.Image = global::TP_SMI1002.Properties.Resources.Create;
            this.btnAjouterTournoi.Location = new System.Drawing.Point(276, 208);
            this.btnAjouterTournoi.Name = "btnAjouterTournoi";
            this.btnAjouterTournoi.Size = new System.Drawing.Size(27, 23);
            this.btnAjouterTournoi.TabIndex = 26;
            this.btnAjouterTournoi.UseVisualStyleBackColor = true;
            this.btnAjouterTournoi.Click += new System.EventHandler(this.btnAjouterMembre_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrer.Image = global::TP_SMI1002.Properties.Resources.Apply;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(286, 410);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(84, 23);
            this.btnEnregistrer.TabIndex = 15;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Image = global::TP_SMI1002.Properties.Resources.Cancel;
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(205, 410);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifierTournoi
            // 
            this.btnModifierTournoi.Image = global::TP_SMI1002.Properties.Resources.Modify;
            this.btnModifierTournoi.Location = new System.Drawing.Point(309, 208);
            this.btnModifierTournoi.Name = "btnModifierTournoi";
            this.btnModifierTournoi.Size = new System.Drawing.Size(27, 23);
            this.btnModifierTournoi.TabIndex = 28;
            this.btnModifierTournoi.UseVisualStyleBackColor = true;
            // 
            // txtNbrPlace
            // 
            this.txtNbrPlace.Location = new System.Drawing.Point(119, 153);
            this.txtNbrPlace.Name = "txtNbrPlace";
            this.txtNbrPlace.Size = new System.Drawing.Size(120, 20);
            this.txtNbrPlace.TabIndex = 30;
            // 
            // lblNombrePlace
            // 
            this.lblNombrePlace.AutoSize = true;
            this.lblNombrePlace.Location = new System.Drawing.Point(22, 159);
            this.lblNombrePlace.Name = "lblNombrePlace";
            this.lblNombrePlace.Size = new System.Drawing.Size(94, 13);
            this.lblNombrePlace.TabIndex = 29;
            this.lblNombrePlace.Text = "Nombre de place :";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(119, 175);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(120, 20);
            this.txtPrix.TabIndex = 32;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(22, 181);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(30, 13);
            this.lblPrix.TabIndex = 31;
            this.lblPrix.Text = "Prix :";
            // 
            // FormEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 445);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtNbrPlace);
            this.Controls.Add(this.lblNombrePlace);
            this.Controls.Add(this.btnModifierTournoi);
            this.Controls.Add(this.btnSupprimerMembre);
            this.Controls.Add(this.btnAjouterTournoi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblNom);
            this.Name = "FormEvenement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Évènement";
            this.Load += new System.EventHandler(this.FormEvenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSupprimerMembre;
        private System.Windows.Forms.Button btnAjouterTournoi;
        private System.Windows.Forms.Button btnModifierTournoi;
        private System.Windows.Forms.TextBox txtNbrPlace;
        private System.Windows.Forms.Label lblNombrePlace;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblPrix;
    }
}