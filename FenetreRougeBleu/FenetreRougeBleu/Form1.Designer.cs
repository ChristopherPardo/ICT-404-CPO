namespace FenetreRougeBleu
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
            this.Bt_HG = new System.Windows.Forms.Button();
            this.Bt_HD = new System.Windows.Forms.Button();
            this.Bt_BG = new System.Windows.Forms.Button();
            this.Bt_BD = new System.Windows.Forms.Button();
            this.Bt_bleu = new System.Windows.Forms.Button();
            this.Bt_Rouge = new System.Windows.Forms.Button();
            this.Bt_Stats = new System.Windows.Forms.Button();
            this.Bt_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_HG
            // 
            this.Bt_HG.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_HG.Location = new System.Drawing.Point(12, 12);
            this.Bt_HG.Name = "Bt_HG";
            this.Bt_HG.Size = new System.Drawing.Size(109, 39);
            this.Bt_HG.TabIndex = 0;
            this.Bt_HG.Text = "Haut/Gauche";
            this.Bt_HG.UseVisualStyleBackColor = true;
            this.Bt_HG.Click += new System.EventHandler(this.Bt_HG_Click);
            // 
            // Bt_HD
            // 
            this.Bt_HD.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_HD.Location = new System.Drawing.Point(677, 12);
            this.Bt_HD.Name = "Bt_HD";
            this.Bt_HD.Size = new System.Drawing.Size(111, 39);
            this.Bt_HD.TabIndex = 1;
            this.Bt_HD.Text = "Haut/Droite";
            this.Bt_HD.UseVisualStyleBackColor = true;
            this.Bt_HD.Click += new System.EventHandler(this.Bt_HD_Click);
            // 
            // Bt_BG
            // 
            this.Bt_BG.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_BG.Location = new System.Drawing.Point(12, 397);
            this.Bt_BG.Name = "Bt_BG";
            this.Bt_BG.Size = new System.Drawing.Size(109, 38);
            this.Bt_BG.TabIndex = 2;
            this.Bt_BG.Text = "Bas/Gauche";
            this.Bt_BG.UseVisualStyleBackColor = true;
            this.Bt_BG.Click += new System.EventHandler(this.Bt_BG_Click);
            // 
            // Bt_BD
            // 
            this.Bt_BD.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_BD.Location = new System.Drawing.Point(677, 398);
            this.Bt_BD.Name = "Bt_BD";
            this.Bt_BD.Size = new System.Drawing.Size(111, 37);
            this.Bt_BD.TabIndex = 3;
            this.Bt_BD.Text = "Bas/Droite";
            this.Bt_BD.UseVisualStyleBackColor = true;
            this.Bt_BD.Click += new System.EventHandler(this.Bt_BD_Click);
            // 
            // Bt_bleu
            // 
            this.Bt_bleu.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_bleu.Location = new System.Drawing.Point(349, 108);
            this.Bt_bleu.Name = "Bt_bleu";
            this.Bt_bleu.Size = new System.Drawing.Size(111, 37);
            this.Bt_bleu.TabIndex = 4;
            this.Bt_bleu.Text = "Bleu";
            this.Bt_bleu.UseVisualStyleBackColor = true;
            this.Bt_bleu.Click += new System.EventHandler(this.Bt_bleu_Click);
            // 
            // Bt_Rouge
            // 
            this.Bt_Rouge.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_Rouge.Location = new System.Drawing.Point(349, 168);
            this.Bt_Rouge.Name = "Bt_Rouge";
            this.Bt_Rouge.Size = new System.Drawing.Size(111, 37);
            this.Bt_Rouge.TabIndex = 5;
            this.Bt_Rouge.Text = "Rouge";
            this.Bt_Rouge.UseVisualStyleBackColor = true;
            this.Bt_Rouge.Click += new System.EventHandler(this.Bt_Rouge_Click);
            // 
            // Bt_Stats
            // 
            this.Bt_Stats.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_Stats.Location = new System.Drawing.Point(349, 265);
            this.Bt_Stats.Name = "Bt_Stats";
            this.Bt_Stats.Size = new System.Drawing.Size(111, 37);
            this.Bt_Stats.TabIndex = 6;
            this.Bt_Stats.Text = "Stats";
            this.Bt_Stats.UseVisualStyleBackColor = true;
            // 
            // Bt_Quit
            // 
            this.Bt_Quit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_Quit.Location = new System.Drawing.Point(349, 322);
            this.Bt_Quit.Name = "Bt_Quit";
            this.Bt_Quit.Size = new System.Drawing.Size(111, 37);
            this.Bt_Quit.TabIndex = 7;
            this.Bt_Quit.Text = "Quitter";
            this.Bt_Quit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_Quit);
            this.Controls.Add(this.Bt_Stats);
            this.Controls.Add(this.Bt_Rouge);
            this.Controls.Add(this.Bt_bleu);
            this.Controls.Add(this.Bt_BD);
            this.Controls.Add(this.Bt_BG);
            this.Controls.Add(this.Bt_HD);
            this.Controls.Add(this.Bt_HG);
            this.Name = "Form1";
            this.Text = "Fenetre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_HG;
        private System.Windows.Forms.Button Bt_HD;
        private System.Windows.Forms.Button Bt_BD;
        private System.Windows.Forms.Button Bt_bleu;
        private System.Windows.Forms.Button Bt_Rouge;
        private System.Windows.Forms.Button Bt_Stats;
        private System.Windows.Forms.Button Bt_Quit;
        private System.Windows.Forms.Button Bt_BG;
    }
}

