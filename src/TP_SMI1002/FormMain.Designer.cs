namespace TP_SMI1002
{
    partial class FormMain
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.optQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListe = new System.Windows.Forms.ToolStripMenuItem();
            this.optEquipes = new System.Windows.Forms.ToolStripMenuItem();
            this.optEvenements = new System.Windows.Forms.ToolStripMenuItem();
            this.optJeux = new System.Windows.Forms.ToolStripMenuItem();
            this.optJoueur = new System.Windows.Forms.ToolStripMenuItem();
            this.optPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.optTypePersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.typeDeJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.optAProposDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tournoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuListe,
            this.mnuAide});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(699, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // optQuitter
            // 
            this.optQuitter.Name = "optQuitter";
            this.optQuitter.Size = new System.Drawing.Size(111, 22);
            this.optQuitter.Text = "&Quitter";
            this.optQuitter.Click += new System.EventHandler(this.optQuitter_Click);
            // 
            // mnuListe
            // 
            this.mnuListe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optEquipes,
            this.optEvenements,
            this.optJeux,
            this.optJoueur,
            this.optPersonnel,
            this.optTypePersonnel,
            this.typeDeJeuToolStripMenuItem,
            this.tournoiToolStripMenuItem});
            this.mnuListe.Name = "mnuListe";
            this.mnuListe.Size = new System.Drawing.Size(43, 20);
            this.mnuListe.Text = "&Liste";
            // 
            // optEquipes
            // 
            this.optEquipes.Name = "optEquipes";
            this.optEquipes.Size = new System.Drawing.Size(171, 22);
            this.optEquipes.Text = "&Équipes";
            this.optEquipes.Click += new System.EventHandler(this.optEquipes_Click);
            // 
            // optEvenements
            // 
            this.optEvenements.Name = "optEvenements";
            this.optEvenements.Size = new System.Drawing.Size(171, 22);
            this.optEvenements.Text = "&Évènement";
            this.optEvenements.Click += new System.EventHandler(this.optEvenements_Click);
            // 
            // optJeux
            // 
            this.optJeux.Name = "optJeux";
            this.optJeux.Size = new System.Drawing.Size(171, 22);
            this.optJeux.Text = "&Jeux";
            this.optJeux.Click += new System.EventHandler(this.optJeux_Click);
            // 
            // optJoueur
            // 
            this.optJoueur.Name = "optJoueur";
            this.optJoueur.Size = new System.Drawing.Size(171, 22);
            this.optJoueur.Text = "&Joueur";
            this.optJoueur.Click += new System.EventHandler(this.optJoueur_Click);
            // 
            // optPersonnel
            // 
            this.optPersonnel.Name = "optPersonnel";
            this.optPersonnel.Size = new System.Drawing.Size(171, 22);
            this.optPersonnel.Text = "&Personnel";
            this.optPersonnel.Click += new System.EventHandler(this.optPersonnel_Click);
            // 
            // optTypePersonnel
            // 
            this.optTypePersonnel.Name = "optTypePersonnel";
            this.optTypePersonnel.Size = new System.Drawing.Size(171, 22);
            this.optTypePersonnel.Text = "&Type de personnel";
            this.optTypePersonnel.Click += new System.EventHandler(this.optTypePersonnel_Click);
            // 
            // typeDeJeuToolStripMenuItem
            // 
            this.typeDeJeuToolStripMenuItem.Name = "typeDeJeuToolStripMenuItem";
            this.typeDeJeuToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.typeDeJeuToolStripMenuItem.Text = "Type de Jeu";
            this.typeDeJeuToolStripMenuItem.Click += new System.EventHandler(this.typeDeJeuToolStripMenuItem_Click);
            // 
            // mnuAide
            // 
            this.mnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optAProposDe});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(24, 20);
            this.mnuAide.Text = "&?";
            // 
            // optAProposDe
            // 
            this.optAProposDe.Name = "optAProposDe";
            this.optAProposDe.Size = new System.Drawing.Size(147, 22);
            this.optAProposDe.Text = "À propos de...";
            this.optAProposDe.Click += new System.EventHandler(this.optAProposDe_Click);
            // 
            // tournoiToolStripMenuItem
            // 
            this.tournoiToolStripMenuItem.Name = "tournoiToolStripMenuItem";
            this.tournoiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.tournoiToolStripMenuItem.Text = "Tournoi";
            this.tournoiToolStripMenuItem.Click += new System.EventHandler(this.tournoiToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 480);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAN UQTR";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem optQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem optAProposDe;
        private System.Windows.Forms.ToolStripMenuItem mnuListe;
        private System.Windows.Forms.ToolStripMenuItem optEquipes;
        private System.Windows.Forms.ToolStripMenuItem optEvenements;
        private System.Windows.Forms.ToolStripMenuItem optJeux;
        private System.Windows.Forms.ToolStripMenuItem optJoueur;
        private System.Windows.Forms.ToolStripMenuItem optPersonnel;
        private System.Windows.Forms.ToolStripMenuItem optTypePersonnel;
        private System.Windows.Forms.ToolStripMenuItem typeDeJeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournoiToolStripMenuItem;
    }
}

