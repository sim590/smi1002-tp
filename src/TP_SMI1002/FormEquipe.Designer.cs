namespace TP_SMI1002
{
    partial class FormEquipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvMembre = new System.Windows.Forms.ListView();
            this.btnSupprimerMembre = new System.Windows.Forms.Button();
            this.btnAjouterMembre = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(27, 24);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 18;
            this.lblNom.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Site web :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(86, 21);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(226, 20);
            this.txtNom.TabIndex = 20;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(88, 46);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(224, 20);
            this.txtSite.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Membre :";
            // 
            // lsvMembre
            // 
            this.lsvMembre.FullRowSelect = true;
            this.lsvMembre.Location = new System.Drawing.Point(33, 116);
            this.lsvMembre.MultiSelect = false;
            this.lsvMembre.Name = "lsvMembre";
            this.lsvMembre.Size = new System.Drawing.Size(279, 97);
            this.lsvMembre.TabIndex = 23;
            this.lsvMembre.UseCompatibleStateImageBehavior = false;
            this.lsvMembre.View = System.Windows.Forms.View.Details;
            // 
            // btnSupprimerMembre
            // 
            this.btnSupprimerMembre.Image = global::TP_SMI1002.Properties.Resources.Delete;
            this.btnSupprimerMembre.Location = new System.Drawing.Point(285, 89);
            this.btnSupprimerMembre.Name = "btnSupprimerMembre";
            this.btnSupprimerMembre.Size = new System.Drawing.Size(27, 23);
            this.btnSupprimerMembre.TabIndex = 25;
            this.btnSupprimerMembre.UseVisualStyleBackColor = true;
            // 
            // btnAjouterMembre
            // 
            this.btnAjouterMembre.Image = global::TP_SMI1002.Properties.Resources.Create;
            this.btnAjouterMembre.Location = new System.Drawing.Point(252, 89);
            this.btnAjouterMembre.Name = "btnAjouterMembre";
            this.btnAjouterMembre.Size = new System.Drawing.Size(27, 23);
            this.btnAjouterMembre.TabIndex = 24;
            this.btnAjouterMembre.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrer.Image = global::TP_SMI1002.Properties.Resources.Apply;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(228, 242);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(84, 23);
            this.btnEnregistrer.TabIndex = 17;
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
            this.btnAnnuler.Location = new System.Drawing.Point(147, 242);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 277);
            this.Controls.Add(this.btnSupprimerMembre);
            this.Controls.Add(this.btnAjouterMembre);
            this.Controls.Add(this.lsvMembre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "FormEquipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Équipe";
            this.Load += new System.EventHandler(this.FormEquipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvMembre;
        private System.Windows.Forms.Button btnAjouterMembre;
        private System.Windows.Forms.Button btnSupprimerMembre;
    }
}