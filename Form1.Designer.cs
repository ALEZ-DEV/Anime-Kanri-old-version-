namespace AnimeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FileExplorerBox = new System.Windows.Forms.ListBox();
            this.setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileExplorerBox
            // 
            this.FileExplorerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExplorerBox.FormattingEnabled = true;
            this.FileExplorerBox.ItemHeight = 25;
            this.FileExplorerBox.Location = new System.Drawing.Point(219, 15);
            this.FileExplorerBox.Name = "FileExplorerBox";
            this.FileExplorerBox.Size = new System.Drawing.Size(569, 404);
            this.FileExplorerBox.TabIndex = 0;
            this.FileExplorerBox.SelectedIndexChanged += new System.EventHandler(this.FileExplorerBox_SelectedIndexChanged);
            // 
            // setting
            // 
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.Location = new System.Drawing.Point(13, 370);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(50, 50);
            this.setting.TabIndex = 1;
            this.setting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.FileExplorerBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FileExplorerBox;
        private System.Windows.Forms.Button setting;
    }
}

