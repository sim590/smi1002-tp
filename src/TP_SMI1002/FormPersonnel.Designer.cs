namespace TP_SMI1002
{
    partial class FormPersonnel
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
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(39, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(39, 51);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(102, 13);
            this.lblDateNaissance.TabIndex = 2;
            this.lblDateNaissance.Text = "Date de naissance :";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(39, 73);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(48, 13);
            this.lblCourriel.TabIndex = 3;
            this.lblCourriel.Text = "Courriel :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(147, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(255, 20);
            this.txtNom.TabIndex = 4;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(147, 52);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(130, 20);
            this.dtpDateNaissance.TabIndex = 5;
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(147, 73);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(255, 20);
            this.txtCourriel.TabIndex = 6;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrer.Image = global::TP_SMI1002.Properties.Resources.Apply;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(318, 110);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(84, 23);
            this.btnEnregistrer.TabIndex = 8;
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
            this.btnAnnuler.Location = new System.Drawing.Point(237, 110);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 146);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtCourriel);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.lblNom);
            this.Name = "FormPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.FormPersonnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}