namespace DemoRegExp
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
            this.Parse = new System.Windows.Forms.Button();
            this.Parameter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Parse
            // 
            this.Parse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Parse.Location = new System.Drawing.Point(323, 12);
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(106, 23);
            this.Parse.TabIndex = 0;
            this.Parse.Text = "Parse";
            this.Parse.UseVisualStyleBackColor = true;
            this.Parse.Click += new System.EventHandler(this.ParseData);
            // 
            // Parameter
            // 
            this.Parameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter.FormattingEnabled = true;
            this.Parameter.Location = new System.Drawing.Point(12, 41);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(417, 225);
            this.Parameter.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 279);
            this.Controls.Add(this.Parameter);
            this.Controls.Add(this.Parse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Parse;
        private System.Windows.Forms.ListBox Parameter;
    }
}

