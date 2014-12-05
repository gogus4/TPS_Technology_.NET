namespace DemoData
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
            this.ParProgramme = new System.Windows.Forms.Button();
            this.MaGrille = new System.Windows.Forms.DataGridView();
            this.ReadXML = new System.Windows.Forms.Button();
            this.WriteXML = new System.Windows.Forms.Button();
            this.ReadSQL = new System.Windows.Forms.Button();
            this.WriteSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaGrille)).BeginInit();
            this.SuspendLayout();
            // 
            // ParProgramme
            // 
            this.ParProgramme.Location = new System.Drawing.Point(12, 12);
            this.ParProgramme.Name = "ParProgramme";
            this.ParProgramme.Size = new System.Drawing.Size(152, 23);
            this.ParProgramme.TabIndex = 0;
            this.ParProgramme.Text = "Par Programme";
            this.ParProgramme.UseVisualStyleBackColor = true;
            this.ParProgramme.Click += new System.EventHandler(this.ParProgramme_Click);
            // 
            // MaGrille
            // 
            this.MaGrille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaGrille.Location = new System.Drawing.Point(12, 41);
            this.MaGrille.Name = "MaGrille";
            this.MaGrille.Size = new System.Drawing.Size(651, 318);
            this.MaGrille.TabIndex = 1;
            // 
            // ReadXML
            // 
            this.ReadXML.Location = new System.Drawing.Point(170, 12);
            this.ReadXML.Name = "ReadXML";
            this.ReadXML.Size = new System.Drawing.Size(75, 23);
            this.ReadXML.TabIndex = 2;
            this.ReadXML.Text = "Read XML";
            this.ReadXML.UseVisualStyleBackColor = true;
            this.ReadXML.Click += new System.EventHandler(this.ReadXML_Click);
            // 
            // WriteXML
            // 
            this.WriteXML.Location = new System.Drawing.Point(251, 12);
            this.WriteXML.Name = "WriteXML";
            this.WriteXML.Size = new System.Drawing.Size(75, 23);
            this.WriteXML.TabIndex = 3;
            this.WriteXML.Text = "Write XML";
            this.WriteXML.UseVisualStyleBackColor = true;
            this.WriteXML.Click += new System.EventHandler(this.WriteXML_Click);
            // 
            // ReadSQL
            // 
            this.ReadSQL.Location = new System.Drawing.Point(332, 12);
            this.ReadSQL.Name = "ReadSQL";
            this.ReadSQL.Size = new System.Drawing.Size(75, 23);
            this.ReadSQL.TabIndex = 4;
            this.ReadSQL.Text = "Read SQL";
            this.ReadSQL.UseVisualStyleBackColor = true;
            this.ReadSQL.Click += new System.EventHandler(this.ReadSQL_Click);
            // 
            // WriteSQL
            // 
            this.WriteSQL.Location = new System.Drawing.Point(413, 12);
            this.WriteSQL.Name = "WriteSQL";
            this.WriteSQL.Size = new System.Drawing.Size(75, 23);
            this.WriteSQL.TabIndex = 5;
            this.WriteSQL.Text = "Write SQL";
            this.WriteSQL.UseVisualStyleBackColor = true;
            this.WriteSQL.Click += new System.EventHandler(this.WriteSQL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 371);
            this.Controls.Add(this.WriteSQL);
            this.Controls.Add(this.ReadSQL);
            this.Controls.Add(this.WriteXML);
            this.Controls.Add(this.ReadXML);
            this.Controls.Add(this.MaGrille);
            this.Controls.Add(this.ParProgramme);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MaGrille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ParProgramme;
        private System.Windows.Forms.DataGridView MaGrille;
        private System.Windows.Forms.Button ReadXML;
        private System.Windows.Forms.Button WriteXML;
        private System.Windows.Forms.Button ReadSQL;
        private System.Windows.Forms.Button WriteSQL;
    }
}

