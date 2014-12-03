namespace DemoConvertions
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
            this.Source = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.TextBox();
            this.Type2String = new System.Windows.Forms.Button();
            this.String2Type = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Source
            // 
            this.Source.Location = new System.Drawing.Point(31, 12);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(288, 20);
            this.Source.TabIndex = 0;
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(31, 54);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(288, 20);
            this.Destination.TabIndex = 1;
            // 
            // Type2String
            // 
            this.Type2String.Location = new System.Drawing.Point(31, 96);
            this.Type2String.Name = "Type2String";
            this.Type2String.Size = new System.Drawing.Size(102, 23);
            this.Type2String.TabIndex = 2;
            this.Type2String.Text = "Type -> String";
            this.Type2String.UseVisualStyleBackColor = true;
            this.Type2String.Click += new System.EventHandler(this.Type2String_Click);
            // 
            // String2Type
            // 
            this.String2Type.Location = new System.Drawing.Point(225, 96);
            this.String2Type.Name = "String2Type";
            this.String2Type.Size = new System.Drawing.Size(94, 23);
            this.String2Type.TabIndex = 3;
            this.String2Type.Text = "String -> Type";
            this.String2Type.UseVisualStyleBackColor = true;
            this.String2Type.Click += new System.EventHandler(this.String2Type_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 138);
            this.Controls.Add(this.String2Type);
            this.Controls.Add(this.Type2String);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Source);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Source;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.Button Type2String;
        private System.Windows.Forms.Button String2Type;
    }
}

