namespace DemoSerialisation
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
            this.SerializeBin = new System.Windows.Forms.Button();
            this.DeserializeBin = new System.Windows.Forms.Button();
            this.SerializeXML = new System.Windows.Forms.Button();
            this.DeserializeXML = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SerializeBin
            // 
            this.SerializeBin.Location = new System.Drawing.Point(25, 12);
            this.SerializeBin.Name = "SerializeBin";
            this.SerializeBin.Size = new System.Drawing.Size(122, 24);
            this.SerializeBin.TabIndex = 0;
            this.SerializeBin.Text = "Serialize binaire";
            this.SerializeBin.UseVisualStyleBackColor = true;
            this.SerializeBin.Click += new System.EventHandler(this.SerializeBin_Click);
            // 
            // DeserializeBin
            // 
            this.DeserializeBin.Location = new System.Drawing.Point(25, 42);
            this.DeserializeBin.Name = "DeserializeBin";
            this.DeserializeBin.Size = new System.Drawing.Size(122, 24);
            this.DeserializeBin.TabIndex = 1;
            this.DeserializeBin.Text = "Deserialize binaire";
            this.DeserializeBin.UseVisualStyleBackColor = true;
            this.DeserializeBin.Click += new System.EventHandler(this.DeserializeBin_Click);
            // 
            // SerializeXML
            // 
            this.SerializeXML.Location = new System.Drawing.Point(25, 72);
            this.SerializeXML.Name = "SerializeXML";
            this.SerializeXML.Size = new System.Drawing.Size(122, 24);
            this.SerializeXML.TabIndex = 2;
            this.SerializeXML.Text = "Serialize XML";
            this.SerializeXML.UseVisualStyleBackColor = true;
            this.SerializeXML.Click += new System.EventHandler(this.SerializeXML_Click);
            // 
            // DeserializeXML
            // 
            this.DeserializeXML.Location = new System.Drawing.Point(25, 102);
            this.DeserializeXML.Name = "DeserializeXML";
            this.DeserializeXML.Size = new System.Drawing.Size(122, 24);
            this.DeserializeXML.TabIndex = 3;
            this.DeserializeXML.Text = "Deserialize XML";
            this.DeserializeXML.UseVisualStyleBackColor = true;
            this.DeserializeXML.Click += new System.EventHandler(this.DeserializeXML_Click);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.Location = new System.Drawing.Point(165, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(120, 147);
            this.Result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 168);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.DeserializeXML);
            this.Controls.Add(this.SerializeXML);
            this.Controls.Add(this.DeserializeBin);
            this.Controls.Add(this.SerializeBin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SerializeBin;
        private System.Windows.Forms.Button DeserializeBin;
        private System.Windows.Forms.Button SerializeXML;
        private System.Windows.Forms.Button DeserializeXML;
        private System.Windows.Forms.ListBox Result;
    }
}

