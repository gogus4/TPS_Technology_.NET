namespace ClientCalc
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
            this.Ajouter = new System.Windows.Forms.Button();
            this.Multiplier = new System.Windows.Forms.Button();
            this.VA = new System.Windows.Forms.TextBox();
            this.VB = new System.Windows.Forms.TextBox();
            this.Resultat = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.Activate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(29, 106);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Multiplier
            // 
            this.Multiplier.Location = new System.Drawing.Point(201, 106);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(75, 23);
            this.Multiplier.TabIndex = 1;
            this.Multiplier.Text = "Multiplier";
            this.Multiplier.UseVisualStyleBackColor = true;
            this.Multiplier.Click += new System.EventHandler(this.Multiplier_Click);
            // 
            // VA
            // 
            this.VA.Location = new System.Drawing.Point(29, 57);
            this.VA.Name = "VA";
            this.VA.Size = new System.Drawing.Size(100, 20);
            this.VA.TabIndex = 2;
            this.VA.Text = "10";
            // 
            // VB
            // 
            this.VB.Location = new System.Drawing.Point(176, 57);
            this.VB.Name = "VB";
            this.VB.Size = new System.Drawing.Size(100, 20);
            this.VB.TabIndex = 3;
            this.VB.Text = "122";
            // 
            // Resultat
            // 
            this.Resultat.Location = new System.Drawing.Point(29, 151);
            this.Resultat.Name = "Resultat";
            this.Resultat.ReadOnly = true;
            this.Resultat.Size = new System.Drawing.Size(247, 20);
            this.Resultat.TabIndex = 4;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(29, 12);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(166, 20);
            this.URL.TabIndex = 5;
            this.URL.Text = "tcp://localhost:12345/CalcESGI";
            // 
            // Activate
            // 
            this.Activate.Location = new System.Drawing.Point(201, 12);
            this.Activate.Name = "Activate";
            this.Activate.Size = new System.Drawing.Size(75, 23);
            this.Activate.TabIndex = 6;
            this.Activate.Text = "Activate";
            this.Activate.UseVisualStyleBackColor = true;
            this.Activate.Click += new System.EventHandler(this.Activate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 193);
            this.Controls.Add(this.Activate);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.VB);
            this.Controls.Add(this.VA);
            this.Controls.Add(this.Multiplier);
            this.Controls.Add(this.Ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Multiplier;
        private System.Windows.Forms.TextBox VA;
        private System.Windows.Forms.TextBox VB;
        private System.Windows.Forms.TextBox Resultat;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button Activate;
    }
}

