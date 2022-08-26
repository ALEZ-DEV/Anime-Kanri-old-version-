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
            this.fileExplorerBox = new System.Windows.Forms.ListBox();
            this.setting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileExplorerBox
            // 
            this.fileExplorerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileExplorerBox.FormattingEnabled = true;
            this.fileExplorerBox.ItemHeight = 20;
            this.fileExplorerBox.Location = new System.Drawing.Point(219, 15);
            this.fileExplorerBox.Name = "fileExplorerBox";
            this.fileExplorerBox.Size = new System.Drawing.Size(569, 404);
            this.fileExplorerBox.TabIndex = 0;
            //this.fileExplorerBox.SelectedIndexChanged += new System.EventHandler(this.FileExplorerBox_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.fileExplorerBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fileExplorerBox;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Label label1;
    }
}

