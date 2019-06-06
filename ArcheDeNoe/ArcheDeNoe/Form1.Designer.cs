namespace ArcheDeNoe
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
            this.LAB_Terre = new System.Windows.Forms.Label();
            this.LAB_Bord = new System.Windows.Forms.Label();
            this.BT_Ajout = new System.Windows.Forms.Button();
            this.BT_Retrait = new System.Windows.Forms.Button();
            this.LB_Terre = new System.Windows.Forms.ListBox();
            this.LB_Bord = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LAB_Terre
            // 
            this.LAB_Terre.AutoSize = true;
            this.LAB_Terre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Terre.Location = new System.Drawing.Point(95, 47);
            this.LAB_Terre.Name = "LAB_Terre";
            this.LAB_Terre.Size = new System.Drawing.Size(213, 33);
            this.LAB_Terre.TabIndex = 0;
            this.LAB_Terre.Text = "Encore à terre";
            // 
            // LAB_Bord
            // 
            this.LAB_Bord.AutoSize = true;
            this.LAB_Bord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Bord.Location = new System.Drawing.Point(577, 47);
            this.LAB_Bord.Name = "LAB_Bord";
            this.LAB_Bord.Size = new System.Drawing.Size(106, 33);
            this.LAB_Bord.TabIndex = 1;
            this.LAB_Bord.Text = "À bord";
            // 
            // BT_Ajout
            // 
            this.BT_Ajout.Location = new System.Drawing.Point(380, 175);
            this.BT_Ajout.Name = "BT_Ajout";
            this.BT_Ajout.Size = new System.Drawing.Size(75, 23);
            this.BT_Ajout.TabIndex = 3;
            this.BT_Ajout.Text = "==>";
            this.BT_Ajout.UseVisualStyleBackColor = true;
            this.BT_Ajout.Click += new System.EventHandler(this.BT_Ajout_Click);
            // 
            // BT_Retrait
            // 
            this.BT_Retrait.Location = new System.Drawing.Point(380, 240);
            this.BT_Retrait.Name = "BT_Retrait";
            this.BT_Retrait.Size = new System.Drawing.Size(75, 23);
            this.BT_Retrait.TabIndex = 4;
            this.BT_Retrait.Text = "<==";
            this.BT_Retrait.UseVisualStyleBackColor = true;
            this.BT_Retrait.Click += new System.EventHandler(this.BT_Retrait_Click);
            // 
            // LB_Terre
            // 
            this.LB_Terre.FormattingEnabled = true;
            this.LB_Terre.Items.AddRange(new object[] {
            "Araignée",
            "Chat",
            "Cheval",
            "Chien",
            "Cobra",
            "Coccinelle",
            "Kangourou",
            "Perroquet",
            "Rat",
            "Ver de terre"});
            this.LB_Terre.Location = new System.Drawing.Point(101, 98);
            this.LB_Terre.Name = "LB_Terre";
            this.LB_Terre.Size = new System.Drawing.Size(197, 264);
            this.LB_Terre.TabIndex = 6;

            // 
            // LB_Bord
            // 
            this.LB_Bord.FormattingEnabled = true;
            this.LB_Bord.Location = new System.Drawing.Point(541, 98);
            this.LB_Bord.Name = "LB_Bord";
            this.LB_Bord.Size = new System.Drawing.Size(197, 264);
            this.LB_Bord.TabIndex = 7;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Bord);
            this.Controls.Add(this.LB_Terre);
            this.Controls.Add(this.BT_Retrait);
            this.Controls.Add(this.BT_Ajout);
            this.Controls.Add(this.LAB_Bord);
            this.Controls.Add(this.LAB_Terre);
            this.Name = "Form1";
            this.Text = "Arche de Noé";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_Terre;
        private System.Windows.Forms.Label LAB_Bord;
        private System.Windows.Forms.Button BT_Ajout;
        private System.Windows.Forms.Button BT_Retrait;
        private System.Windows.Forms.ListBox LB_Terre;
        private System.Windows.Forms.ListBox LB_Bord;
    }
}

