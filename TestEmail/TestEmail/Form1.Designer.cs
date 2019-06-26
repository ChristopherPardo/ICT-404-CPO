namespace TestEmail
{
    partial class Form1
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmdValidation = new System.Windows.Forms.Button();
            this.chkAt = new System.Windows.Forms.CheckBox();
            this.txtApres = new System.Windows.Forms.TextBox();
            this.txtAvant = new System.Windows.Forms.TextBox();
            this.lblAvant = new System.Windows.Forms.Label();
            this.lblApres = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.chkpoint = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(94, 57);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email à verifier";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(213, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(322, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // cmdValidation
            // 
            this.cmdValidation.Location = new System.Drawing.Point(681, 52);
            this.cmdValidation.Name = "cmdValidation";
            this.cmdValidation.Size = new System.Drawing.Size(75, 23);
            this.cmdValidation.TabIndex = 2;
            this.cmdValidation.Text = "Verifier";
            this.cmdValidation.UseVisualStyleBackColor = true;
            // 
            // chkAt
            // 
            this.chkAt.AutoSize = true;
            this.chkAt.Location = new System.Drawing.Point(71, 147);
            this.chkAt.Name = "chkAt";
            this.chkAt.Size = new System.Drawing.Size(85, 17);
            this.chkAt.TabIndex = 3;
            this.chkAt.Text = "\"@\" présent";
            this.chkAt.UseVisualStyleBackColor = true;
            // 
            // txtApres
            // 
            this.txtApres.Location = new System.Drawing.Point(60, 220);
            this.txtApres.Name = "txtApres";
            this.txtApres.Size = new System.Drawing.Size(24, 20);
            this.txtApres.TabIndex = 4;
            this.txtApres.Text = "4";
            this.txtApres.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtAvant
            // 
            this.txtAvant.Location = new System.Drawing.Point(60, 180);
            this.txtAvant.Name = "txtAvant";
            this.txtAvant.Size = new System.Drawing.Size(24, 20);
            this.txtAvant.TabIndex = 5;
            this.txtAvant.Text = "2";
            // 
            // lblAvant
            // 
            this.lblAvant.AutoSize = true;
            this.lblAvant.Location = new System.Drawing.Point(94, 187);
            this.lblAvant.Name = "lblAvant";
            this.lblAvant.Size = new System.Drawing.Size(108, 13);
            this.lblAvant.TabIndex = 6;
            this.lblAvant.Text = "Caractère(s) avant @";
            // 
            // lblApres
            // 
            this.lblApres.AutoSize = true;
            this.lblApres.Location = new System.Drawing.Point(94, 227);
            this.lblApres.Name = "lblApres";
            this.lblApres.Size = new System.Drawing.Size(107, 13);
            this.lblApres.TabIndex = 7;
            this.lblApres.Text = "Caractère(s) après @";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(68, 348);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(84, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom d\'utilisateur";
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(174, 348);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 20);
            this.txtNom.TabIndex = 9;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(353, 413);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(35, 13);
            this.lblConfirmation.TabIndex = 10;
            this.lblConfirmation.Text = "label5";
            // 
            // chkpoint
            // 
            this.chkpoint.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.chkpoint.AutoSize = true;
            this.chkpoint.Location = new System.Drawing.Point(71, 265);
            this.chkpoint.Name = "chkpoint";
            this.chkpoint.Size = new System.Drawing.Size(130, 17);
            this.chkpoint.TabIndex = 11;
            this.chkpoint.Text = "\".\" présent après \"@\"";
            this.chkpoint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkpoint);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblApres);
            this.Controls.Add(this.lblAvant);
            this.Controls.Add(this.txtAvant);
            this.Controls.Add(this.txtApres);
            this.Controls.Add(this.chkAt);
            this.Controls.Add(this.cmdValidation);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "Form1";
            this.Text = "Vérification d\'Email";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button cmdValidation;
        private System.Windows.Forms.CheckBox chkAt;
        private System.Windows.Forms.TextBox txtApres;
        private System.Windows.Forms.TextBox txtAvant;
        private System.Windows.Forms.Label lblAvant;
        private System.Windows.Forms.Label lblApres;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.CheckBox chkpoint;
    }
}

