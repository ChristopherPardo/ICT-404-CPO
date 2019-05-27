namespace CommandeDePizza
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
            this.TB_Table = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Com = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Com = new System.Windows.Forms.Label();
            this.RD_EF = new System.Windows.Forms.RadioButton();
            this.RD_F = new System.Windows.Forms.RadioButton();
            this.RD_N = new System.Windows.Forms.RadioButton();
            this.RD_E = new System.Windows.Forms.RadioButton();
            this.CB_A = new System.Windows.Forms.CheckBox();
            this.CB_Cap = new System.Windows.Forms.CheckBox();
            this.CB_J = new System.Windows.Forms.CheckBox();
            this.CB_Crev = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // TB_Table
            // 
            this.TB_Table.Location = new System.Drawing.Point(221, 36);
            this.TB_Table.Name = "TB_Table";
            this.TB_Table.Size = new System.Drawing.Size(46, 20);
            this.TB_Table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // BT_Com
            // 
            this.BT_Com.Location = new System.Drawing.Point(434, 290);
            this.BT_Com.Name = "BT_Com";
            this.BT_Com.Size = new System.Drawing.Size(113, 35);
            this.BT_Com.TabIndex = 10;
            this.BT_Com.Text = "Commander";
            this.BT_Com.UseVisualStyleBackColor = true;
            this.BT_Com.Click += new System.EventHandler(this.BT_Com_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Commande";
            // 
            // TB_Com
            // 
            this.TB_Com.AutoSize = true;
            this.TB_Com.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Com.Location = new System.Drawing.Point(232, 355);
            this.TB_Com.Name = "TB_Com";
            this.TB_Com.Size = new System.Drawing.Size(24, 33);
            this.TB_Com.TabIndex = 13;
            this.TB_Com.Text = ".";
            // 
            // RD_EF
            // 
            this.RD_EF.AutoSize = true;
            this.RD_EF.Location = new System.Drawing.Point(146, 127);
            this.RD_EF.Name = "RD_EF";
            this.RD_EF.Size = new System.Drawing.Size(69, 17);
            this.RD_EF.TabIndex = 14;
            this.RD_EF.TabStop = true;
            this.RD_EF.Text = "Extra-fine";
            this.RD_EF.UseVisualStyleBackColor = true;
            // 
            // RD_F
            // 
            this.RD_F.AutoSize = true;
            this.RD_F.Location = new System.Drawing.Point(146, 150);
            this.RD_F.Name = "RD_F";
            this.RD_F.Size = new System.Drawing.Size(45, 17);
            this.RD_F.TabIndex = 15;
            this.RD_F.TabStop = true;
            this.RD_F.Text = "Fine";
            this.RD_F.UseVisualStyleBackColor = true;
            // 
            // RD_N
            // 
            this.RD_N.AutoSize = true;
            this.RD_N.Location = new System.Drawing.Point(146, 173);
            this.RD_N.Name = "RD_N";
            this.RD_N.Size = new System.Drawing.Size(64, 17);
            this.RD_N.TabIndex = 16;
            this.RD_N.TabStop = true;
            this.RD_N.Text = "Normale";
            this.RD_N.UseVisualStyleBackColor = true;
            // 
            // RD_E
            // 
            this.RD_E.AutoSize = true;
            this.RD_E.Location = new System.Drawing.Point(146, 196);
            this.RD_E.Name = "RD_E";
            this.RD_E.Size = new System.Drawing.Size(62, 17);
            this.RD_E.TabIndex = 17;
            this.RD_E.TabStop = true;
            this.RD_E.Text = "Epaisse";
            this.RD_E.UseVisualStyleBackColor = true;
            // 
            // CB_A
            // 
            this.CB_A.AutoSize = true;
            this.CB_A.Location = new System.Drawing.Point(384, 127);
            this.CB_A.Name = "CB_A";
            this.CB_A.Size = new System.Drawing.Size(64, 17);
            this.CB_A.TabIndex = 6;
            this.CB_A.Text = "Anchois";
            this.CB_A.UseVisualStyleBackColor = true;
            // 
            // CB_Cap
            // 
            this.CB_Cap.AutoSize = true;
            this.CB_Cap.Location = new System.Drawing.Point(384, 150);
            this.CB_Cap.Name = "CB_Cap";
            this.CB_Cap.Size = new System.Drawing.Size(59, 17);
            this.CB_Cap.TabIndex = 7;
            this.CB_Cap.Text = "Câpres";
            this.CB_Cap.UseVisualStyleBackColor = true;
            // 
            // CB_J
            // 
            this.CB_J.AutoSize = true;
            this.CB_J.Location = new System.Drawing.Point(384, 173);
            this.CB_J.Name = "CB_J";
            this.CB_J.Size = new System.Drawing.Size(63, 17);
            this.CB_J.TabIndex = 8;
            this.CB_J.Text = "Jambon";
            this.CB_J.UseVisualStyleBackColor = true;
            // 
            // CB_Crev
            // 
            this.CB_Crev.AutoSize = true;
            this.CB_Crev.Location = new System.Drawing.Point(384, 196);
            this.CB_Crev.Name = "CB_Crev";
            this.CB_Crev.Size = new System.Drawing.Size(71, 17);
            this.CB_Crev.TabIndex = 9;
            this.CB_Crev.Text = "Crevettes";
            this.CB_Crev.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(118, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 151);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pâte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 468);
            this.Controls.Add(this.RD_E);
            this.Controls.Add(this.RD_N);
            this.Controls.Add(this.RD_F);
            this.Controls.Add(this.RD_EF);
            this.Controls.Add(this.TB_Com);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_Com);
            this.Controls.Add(this.CB_Crev);
            this.Controls.Add(this.CB_J);
            this.Controls.Add(this.CB_Cap);
            this.Controls.Add(this.CB_A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Table);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Com;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TB_Com;
        private System.Windows.Forms.RadioButton RD_EF;
        private System.Windows.Forms.RadioButton RD_F;
        private System.Windows.Forms.RadioButton RD_N;
        private System.Windows.Forms.RadioButton RD_E;
        private System.Windows.Forms.CheckBox CB_A;
        private System.Windows.Forms.CheckBox CB_Cap;
        private System.Windows.Forms.CheckBox CB_J;
        private System.Windows.Forms.CheckBox CB_Crev;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

