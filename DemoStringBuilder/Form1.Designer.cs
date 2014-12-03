namespace DemoStringBuilder
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
            this.NbIterations = new System.Windows.Forms.TextBox();
            this.duree = new System.Windows.Forms.Label();
            this.SansSB = new System.Windows.Forms.Button();
            this.AvecSB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NbIterations
            // 
            this.NbIterations.Location = new System.Drawing.Point(12, 12);
            this.NbIterations.Name = "NbIterations";
            this.NbIterations.Size = new System.Drawing.Size(301, 20);
            this.NbIterations.TabIndex = 0;
            this.NbIterations.Text = "1000";
            // 
            // duree
            // 
            this.duree.AutoSize = true;
            this.duree.Location = new System.Drawing.Point(12, 98);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(0, 13);
            this.duree.TabIndex = 1;
            // 
            // SansSB
            // 
            this.SansSB.Location = new System.Drawing.Point(12, 38);
            this.SansSB.Name = "SansSB";
            this.SansSB.Size = new System.Drawing.Size(119, 42);
            this.SansSB.TabIndex = 2;
            this.SansSB.Text = "Sans SB";
            this.SansSB.UseVisualStyleBackColor = true;
            this.SansSB.Click += new System.EventHandler(this.DemoSansSB);
            // 
            // AvecSB
            // 
            this.AvecSB.Location = new System.Drawing.Point(194, 38);
            this.AvecSB.Name = "AvecSB";
            this.AvecSB.Size = new System.Drawing.Size(119, 42);
            this.AvecSB.TabIndex = 3;
            this.AvecSB.Text = "Avec SB";
            this.AvecSB.UseVisualStyleBackColor = true;
            this.AvecSB.Click += new System.EventHandler(this.DemoAvecSB);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 118);
            this.Controls.Add(this.AvecSB);
            this.Controls.Add(this.SansSB);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.NbIterations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NbIterations;
        private System.Windows.Forms.Label duree;
        private System.Windows.Forms.Button SansSB;
        private System.Windows.Forms.Button AvecSB;
    }
}

