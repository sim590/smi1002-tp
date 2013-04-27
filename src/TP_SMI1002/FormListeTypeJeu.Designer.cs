namespace TP_SMI1002
{
    partial class FormListeTypeJeu
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lsvTypeJeu = new System.Windows.Forms.ListView();
            this.clnTypeJeu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Image = global::TP_SMI1002.Properties.Resources.Cancel;
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(292, 183);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Image = global::TP_SMI1002.Properties.Resources.Delete;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(211, 183);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Image = global::TP_SMI1002.Properties.Resources.Modify;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(130, 183);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Image = global::TP_SMI1002.Properties.Resources.New_document;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(49, 183);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // lsvTypeJeu
            // 
            this.lsvTypeJeu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTypeJeu});
            this.lsvTypeJeu.FullRowSelect = true;
            this.lsvTypeJeu.Location = new System.Drawing.Point(12, 12);
            this.lsvTypeJeu.MultiSelect = false;
            this.lsvTypeJeu.Name = "lsvTypeJeu";
            this.lsvTypeJeu.Size = new System.Drawing.Size(327, 155);
            this.lsvTypeJeu.TabIndex = 25;
            this.lsvTypeJeu.UseCompatibleStateImageBehavior = false;
            this.lsvTypeJeu.View = System.Windows.Forms.View.Details;
            // 
            // clnTypeJeu
            // 
            this.clnTypeJeu.Text = "TypeJeu";
            this.clnTypeJeu.Width = 322;
            // 
            // FormListeTypeJeu
            // 
            this.ClientSize = new System.Drawing.Size(379, 218);
            this.Controls.Add(this.lsvTypeJeu);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FormListeTypeJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type Jeu";
            this.Load += new System.EventHandler(this.FormListeTypeJeu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListView lsvTypeJeu;
        private System.Windows.Forms.ColumnHeader clnTypeJeu;
    }
}
