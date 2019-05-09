namespace ExoBonjour
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
            this.blQuestion = new System.Windows.Forms.Label();
            this.blName = new System.Windows.Forms.TextBox();
            this.btBienvenue = new System.Windows.Forms.Button();
            this.rp = new System.Windows.Forms.Label();
            this.btCroix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blQuestion
            // 
            this.blQuestion.AutoSize = true;
            this.blQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blQuestion.Location = new System.Drawing.Point(102, 97);
            this.blQuestion.Name = "blQuestion";
            this.blQuestion.Size = new System.Drawing.Size(198, 42);
            this.blQuestion.TabIndex = 0;
            this.blQuestion.Text = "Votre nom";
            this.blQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // blName
            // 
            this.blName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blName.Location = new System.Drawing.Point(330, 90);
            this.blName.Name = "blName";
            this.blName.Size = new System.Drawing.Size(410, 49);
            this.blName.TabIndex = 1;
            this.blName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btBienvenue
            // 
            this.btBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBienvenue.Location = new System.Drawing.Point(282, 366);
            this.btBienvenue.Name = "btBienvenue";
            this.btBienvenue.Size = new System.Drawing.Size(227, 71);
            this.btBienvenue.TabIndex = 2;
            this.btBienvenue.Text = "Bienvenue";
            this.btBienvenue.UseVisualStyleBackColor = true;
            this.btBienvenue.Click += new System.EventHandler(this.btBienvenue_Click);
            // 
            // rp
            // 
            this.rp.AutoSize = true;
            this.rp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp.Location = new System.Drawing.Point(102, 231);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(51, 42);
            this.rp.TabIndex = 3;
            this.rp.Text = "...";
            this.rp.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btCroix
            // 
            this.btCroix.BackgroundImage = global::ExoBonjour.Properties.Resources.delete;
            this.btCroix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCroix.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btCroix.Location = new System.Drawing.Point(608, 366);
            this.btCroix.Name = "btCroix";
            this.btCroix.Size = new System.Drawing.Size(83, 83);
            this.btCroix.TabIndex = 4;
            this.btCroix.UseVisualStyleBackColor = true;
            this.btCroix.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 487);
            this.Controls.Add(this.btCroix);
            this.Controls.Add(this.rp);
            this.Controls.Add(this.btBienvenue);
            this.Controls.Add(this.blName);
            this.Controls.Add(this.blQuestion);
            this.Name = "Form1";
            this.Text = "Bonjour Qui ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blQuestion;
        private System.Windows.Forms.TextBox blName;
        private System.Windows.Forms.Button btBienvenue;
        private System.Windows.Forms.Label rp;
        private System.Windows.Forms.Button btCroix;
    }
}

